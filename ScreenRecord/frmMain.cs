using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.FFMPEG;
using AForge.Video;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using Common;

namespace ScreenRecord
{
    public partial class frmMain : Form
    {

        bool flag = false;

        int i = 0;
        string namevideo = null;
        string namevideoold = "";
        bool interupt = false;
        [StructLayout(LayoutKind.Sequential)]
        private struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINTAPI
        {
            public int x;
            public int y;
        }
        //bien check viec lưu video thanh cong hay chưa


        [DllImport("user32.dll")]
        private static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool DrawIconEx(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyHeight, int istepIfAniCur, IntPtr hbrFlickerFreeDraw, int diFlags);

        private const Int32 CURSOR_SHOWING = 0x0001;
        private const Int32 DI_NORMAL = 0x0003;

        private bool _isRecording;
        private List<string> _screenNames;
        //private Rectangle _screenSize;
        private UInt32 _frameCount;
        private VideoFileWriter _writer;
        private int _width;
        private int _height;
        private ScreenCaptureStream _streamVideo;
        private Stopwatch _stopWatch;
        private Rectangle _screenArea;

        private string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoRecords";

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public frmMain()
        {
            InitializeComponent();
           
         
        }
        private void video()
        {

            GrantAccess(SavePath);


            Hide();
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;

            _isRecording = false;
            //_screenSize = Screen.PrimaryScreen.Bounds;
            _frameCount = 0;
            _width = SystemInformation.VirtualScreen.Width;
            _height = SystemInformation.VirtualScreen.Height;
            _stopWatch = new Stopwatch();
            _screenArea = Rectangle.Empty;

            bt_Save.Enabled = false;
            _writer = new VideoFileWriter();

            _screenNames = new List<string>();
            _screenNames.Add(@"Select ALL");
            foreach (var screen in Screen.AllScreens)
            {
                _screenNames.Add(screen.DeviceName);
            }
            cb_screenSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_screenSelector.DataSource = _screenNames;

            // Codec ComboBox
            cb_VideoCodec.DataSource = Enum.GetValues(typeof(VideoCodec));
            cb_VideoCodec.DropDownStyle = ComboBoxStyle.DropDownList;

            // BitRate 2000kbit/s 2000000 1000000
            cb_BitRate.DataSource = Enum.GetValues(typeof(BitRate));
            cb_BitRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_BitRate.SelectedIndex = 4;

            timer1.Interval = 60 * 1000 * 2;   // 30 phuts
            timer1.Enabled = true;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            try
            {
                video();
                IsFileChange();
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }


        }


        private void recorder_start()
        {

            new Thread(() => {
                try
                {
                    Thread.CurrentThread.IsBackground = true;
                    DirectoryInfo info = new DirectoryInfo(SavePath);
                    FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();

                    /* for (int i = 0; i < files.Count() - 48; i++)
                     {
                         files[i].Delete();
                     }*/

                }
                catch
                {

                }

            }).Start();

            try
            {
                if (tb_SaveFolder.Text.Length < 1)
                {
                    StartRec(SavePath);
                }
                else
                {
                    StartRec(tb_SaveFolder.Text);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void StartRec(string path)
        {

            if (_isRecording == false)
            {

                SetScreenArea();


                SetVisible(true);

                _frameCount = 0;

                tb_SaveFolder.Text = path;
                string fullName = string.Format(@"{0}\{1}_{2}.avi", path, namevideo, ++i);

                //  string fullName = string.Format(@"{0}\{1}_{2}.avi", path, Environment.MachineName.ToUpper(), DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
                Common.video.path = fullName;
                //duong dan den file video
                // Save File option
                _writer.Open(
                    fullName,
                    _width,
                    _height,
                    (int)nud_FPS.Value,
                    (VideoCodec)cb_VideoCodec.SelectedValue,
                    (int)(BitRate)cb_BitRate.SelectedValue);

                // Start main work
                StartRecord();
                //this.ghitext();
            }
        }

        private void SetScreenArea()
        {
            // get entire desktop area size

            string screenName = cb_screenSelector.SelectedValue.ToString();
            if (string.Compare(screenName, @"Select ALL", StringComparison.OrdinalIgnoreCase) == 0)
            {
                foreach (Screen screen in Screen.AllScreens)
                {
                    _screenArea = Rectangle.Union(_screenArea, screen.Bounds);
                }
            }
            else
            {
                _screenArea = Screen.AllScreens.First(scr => scr.DeviceName.Equals(screenName)).Bounds;
                _width = _screenArea.Width;
                _height = _screenArea.Height;
                //  Size s = Screen.PrimaryScreen.Bounds.Size;
                //  _width = s.Width;
                //  _height = s.Height;
            }
        }

        private void StartRecord() //Object stateInfo
        {
            // create screen capture video source
            _streamVideo = new ScreenCaptureStream(_screenArea);

            // set NewFrame event handler
            _streamVideo.NewFrame += new NewFrameEventHandler(video_NewFrame);
            _streamVideo.PlayingFinished += new PlayingFinishedEventHandler(video_autoReStart);


            // start the video source
            _streamVideo.Start();

            // _stopWatch
            _stopWatch.Start();
        }


        //insert datetime to frame
        private Bitmap Stamp(Bitmap b, DateTime dt, string format)
        {
            string stampString;

            if (!string.IsNullOrEmpty(format)) { stampString = dt.ToString(format); }
            else { stampString = dt.ToString(); }

            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(Brushes.Transparent, 0, 0, b.Width, 20);

            g.DrawString(stampString, new Font("Arial", 24f), Brushes.Red, 2, 2);



            CURSORINFO pci;
            pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));

            if (GetCursorInfo(out pci))
            {
                if (pci.flags == CURSOR_SHOWING)
                {
                    var hdc = g.GetHdc();
                    DrawIconEx(hdc, pci.ptScreenPos.x - _screenArea.X, pci.ptScreenPos.y - _screenArea.Y, pci.hCursor, 0, 0, 0, IntPtr.Zero, DI_NORMAL);
                    g.ReleaseHdc();
                }
            }

            g.Flush();
            return b;
        }


        private void video_autoReStart(object sender, ReasonToFinishPlaying e)
        {
            Invoke(new Action(() =>
            {

                recorder_start();

            }));

        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (_isRecording)
            {
                _frameCount++;
                _writer.WriteVideoFrame(Stamp(eventArgs.Frame, DateTime.Now, "yyyy-MM-dd HH:mm:ss"));

                //lb_1.Invoke( new Action( () =>
                //{
                //    lb_1.Text = string.Format( @"Frames: {0}", _frameCount );
                //} ) );

                lb_stopWatch.Invoke(new Action(() =>
                {
                    lb_stopWatch.Text = _stopWatch.Elapsed.ToString();
                }));

            }
            else
            {
                _stopWatch.Reset();

                _streamVideo.SignalToStop();

                _writer.Close();
            }

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
            SetVisible(false);
            MessageBox.Show(@"File saved!");
            //hoan thanh va luu video

        }

        private void SetVisible(bool visible)
        {
            bt_Save.Enabled = visible;
            _isRecording = visible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isRecording = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetVisible(false);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            //ShowInTaskbar = true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void GrantAccess(string file)
        {
            bool exists = System.IO.Directory.Exists(file);
            if (!exists)
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(file);
                //Console.WriteLine("The Folder is created Sucessfully");
            }


            DirectorySecurity sec = Directory.GetAccessControl(file);

            // Using this instead of the "Everyone" string means we work on non-English systems.
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl | FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(file, sec);
        }

        public void IsFileChange()
        {

            FileSystemWatcher myWatcher = new FileSystemWatcher();
            myWatcher.Path = "C:/ProgramData/EXON/"; //Đường dẫn cần theo dõi
            myWatcher.Filter = "*.txt"; //Bộ lọc loại tập tin
            myWatcher.EnableRaisingEvents = true; // Cho phép sử dụng các sự kiện khi có thay đổi
            myWatcher.IncludeSubdirectories = true; //Bao gồm thư mục con
            //Bộ lọc đối với sự kiện Changed
            myWatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            //Xử lý các sự kiện                                                            
            myWatcher.Created += new FileSystemEventHandler(myWatcher_Created);
            myWatcher.Changed += new FileSystemEventHandler(myWatcher_Changed);
         


        }


        public void myWatcher_Created(object sender, FileSystemEventArgs e)
        {

            int startIndex = e.FullPath.IndexOf(@"\");
            int lastIndex = e.FullPath.IndexOf(".txt");
            namevideoold = namevideo;
            namevideo = e.FullPath.Substring(startIndex, lastIndex - startIndex);
            // timer1.Start();
            flag = false;
            i = 0;
            Invoke(new Action(() =>
            {
                video();
                recorder_start();
            }));
        }
        public void myWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            int startIndex = e.FullPath.IndexOf(@"\");
            int lastIndex = e.FullPath.IndexOf(".txt");

            string namepathvideo = e.FullPath.Substring(0, startIndex - 1) + e.FullPath.Substring(startIndex, lastIndex - startIndex) + ".txt";

            FileAttributes attributes = File.GetAttributes(namepathvideo);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                flag = true;
                _streamVideo.Stop();
                _writer.Close();
                interupt = true;
                //_isRecording = true;
                //  timer1.Stop();
                _streamVideo.NewFrame -= new NewFrameEventHandler(video_NewFrame);
                _streamVideo.PlayingFinished -= new PlayingFinishedEventHandler(video_autoReStart);
            }
            if((attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly && interupt)
            {
                interupt = false;
                Invoke(new Action(() =>
                {
                    namevideo = e.FullPath.Substring(startIndex, lastIndex - startIndex);
                    string[] fileArray1 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoRecords\");
                    i = fileArray1.Length  ;
                   
                    flag = false;
                    video();
                    recorder_start();
                }));
            }    

        }

    }


    public enum BitRate
    {
        _50kbit = 5000,
        _100kbit = 10000,
        _500kbit = 50000,
        _1000kbit = 1000000,
        _2000kbit = 2000000,
        _3000kbit = 3000000

    }

}
