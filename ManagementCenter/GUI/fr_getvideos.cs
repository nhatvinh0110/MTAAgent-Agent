using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Common;
using Common.CONFIG;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ManagementCenter.GUI
{
    public partial class fr_getvideos : Form
    {
        List<string> input = new List<string>();
        string data_path;
        public fr_getvideos()
        {
            InitializeComponent();
            filePath.Text = Directory.GetCurrentDirectory();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                filePath.Text = dlg.SelectedPath;
            data_path = dlg.SelectedPath;
        }
        void getfile(string curpath)
        {

            data_path = curpath;
            if (File.Exists(data_path + "\\output.avi"))
            {
                File.Delete(data_path + "\\output.avi");
            }

            string src = Directory.GetCurrentDirectory() + "\\output.avi";
            if (File.Exists(src))
            {
                File.Delete(src);
            }
            foreach (string filename in Directory.GetFiles(data_path))
            {
                input.Add(filename);
            }
            del();
            foreach (var file in input)
            {
                File.Copy(file, $"Temp\\{Path.GetFileName(file)}");
            }
        }
        void del()
        {
            foreach (var it in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Temp"))
            {
                File.Delete(it);
            }

        }
        void runCmdCommand(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {command}";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        void mergeVideo(string cur_path)
        {
            string checkFile = cur_path + "\\output.avi";
            if (File.Exists(checkFile))
            {
                File.Delete(checkFile);
            }
            data_path = cur_path;
            foreach (string filename in Directory.GetFiles(data_path))
            {
                input.Add(filename);
            }
            string fn = "";
            int i = 0;
            using (var stw = new StreamWriter("videos.txt"))
            {
                foreach (var fileName in input)
                {
                    fn = Path.GetFileName(fileName);
                    stw.WriteLine($"file '{cur_path + "\\" + fn}'");
                    i++;
                }
            }
            runCmdCommand($"ffmpeg -f concat -safe 0 -i videos.txt -c copy {"\"" + cur_path + "\\" + "output.avi" + "\""}");

        }
        private SqlConnection GetSqlConnection()
        {
            //string con = Config_Helper.GetValue("CON", "");
            //return new SqlConnection(@"Data Source = DESKTOP-FSU3LJ4; Initial Catalog = MTAAgent; Persist Security Info = True; User ID = sa; Password = 12345; Connection Timeout = 20; MultipleActiveResultSets=True;");

            return new SqlConnection(frmMain.con);
        }
        public void Start_Get_Videos()
        {

            using (SqlConnection cn = GetSqlConnection())
            {
                cn.Open();
                string query_0 = "UPDATE dbo.StatusVideoLog SET StatusVideo = '1'";
                using (SqlCommand cmd = new SqlCommand(query_0, cn))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }
        public void getVideos(string choose_file_path, fr_getvideos this_fr)
        {
            while (true)
            {
                using (SqlConnection cn = GetSqlConnection())
                {
                    cn.Open();
                    string query = "SELECT dbo.StoreVideo.StudentID,NamePath,ContentVideo,StatusVideoLog.ComputerID,StatusVideo FROM dbo.StoreVideo,dbo.StatusVideoLog WHERE dbo.StoreVideo.ComputerID = dbo.StatusVideoLog.ComputerID AND StatusVideo != '0' ";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    DataTable table = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                    bool kt = false;

                    foreach (DataRow row in table.Rows)
                    {
                        if (row["StatusVideo"].ToString() != "3")
                        {
                            kt = true;
                            continue;
                        }
                        try
                        {
                            kt = true;
                            var bytes = (byte[])row["ContentVideo"];
                            string name_path = row["NamePath"].ToString();
                            string name = row["StudentID"].ToString();
                            string comuterID = row["ComputerID"].ToString();
                            string path_1 = @"" + choose_file_path;
                            string path = GetNameFoder(@"" + name_path);
                            string Ten_may = GetTenMay(@"" + name_path);
                            if (!File.Exists(@"" + path_1 + @"\" + path + @"\" + Ten_may))
                            {
                                Directory.CreateDirectory(@"" + path_1 + @"\" + path + @"\" + Ten_may);
                            }
                            var list = Directory.GetFiles(@"" + path_1 + @"\" + path + @"\" + Ten_may + @"\", "*.avi");
                            File.WriteAllBytes(@"" + path_1 + @"\" + path + @"\" + Ten_may + @"\" + list.Length.ToString() + ".avi", bytes);
                            this_fr.textBox_contents.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this_fr.textBox_contents.Text += (@"" + path_1 + @"\" + path + @"\" + Ten_may + @"\" + list.Length.ToString() + ".avi đã được lưu \r\n");
                            });
                            string query2 = "UPDATE dbo.StatusVideoLog SET StatusVideo = '1' WHERE ComputerID = '" + comuterID + "'";
                            using (SqlCommand cmd2 = new SqlCommand(query2, cn))
                            {
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        catch (Exception E)
                        {
                            continue;
                        }
                    }
                    if (kt == false)
                    {
                        this_fr.textBox_contents.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this_fr.textBox_contents.Text += "Nhận xong toàn bộ video\r\n";
                        });
                        //this_fr.textBox_contents.Text += "Nhận xong toàn bộ video\r\n";
                        //this_fr.Refresh();
                        cn.Close();
                        break;
                    }
                    cn.Close();
                }
                //Thread.Sleep(1);
            }

        }
        //ham dung de lay so thu tu cua video -- hien tai khong dung toi
        public string GetIndex(string namepath)
        {
            int i = namepath.Length - 1;
            while (namepath[i] != '_')
            {
                i--;
            }
            return (namepath.Substring(i + 1, namepath.Length - i - 1));


        }
        public string GetNameFoder(string namepath)
        {
            namepath = namepath.Replace("?", "_");
            namepath = namepath.Replace("\\", "/");
            int i = namepath.Length - 1;
            while (namepath[i] != '_')
            {
                i--;
            }
            int j = 0;
            while (namepath[j] != '/')
            {
                j++;
            }
            Console.WriteLine(namepath.Substring(j + 1, i - j - 1));
            return namepath.Substring(j + 1, i - j - 1);


        }
        public string GetTenMay(string namepath)
        {
            namepath = namepath.Replace("?", "_");
            namepath = namepath.Replace("\\", "/");
            int i = 0;
            while (namepath[i] != '/')
            {
                i++;
            }
            return (namepath.Substring(0, i));


        }

        private void button_getVideos_Click(object sender, EventArgs e)
        {
            Start_Get_Videos();
            textBox_contents.Text += "Bắt đầu nhận video từ các máy!\r\n";
            this.Refresh();
            //Thread trd = new Thread( new ThreadStart(this.getVideos) );
            //trd.Start(data_path);
            //Process.Start(this.getVideos(data_path, this));
            //getVideos(data_path, this);
            this.button_getVideos.Enabled = false;
            this.buttonMerge.Enabled = false;
            this.buttonX2.Enabled = false;
            this.button_stop.Enabled = true;
            Thread getVd = new Thread(() =>
            {
                getVideos(data_path, this);
                this.button_getVideos.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.button_getVideos.Enabled = true;
                });
                this.buttonMerge.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.buttonMerge.Enabled = true;
                });
                this.buttonX2.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.buttonX2.Enabled = true;
                });
                this.button_stop.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.button_stop.Enabled = true;
                });
            });
            //getVd.IsBackground = true;
            getVd.Start();

        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            foreach (var it3 in Directory.GetDirectories(filePath.Text))
            {

                foreach (var it2 in Directory.GetDirectories(it3))
                {
                    if (Directory.EnumerateFiles(it2, "*.avi").Count() >= 2)
                    {



                        buttonMerge.Enabled = false;
                        buttonMerge.Text = "Đang ghép";
                        textBox_contents.Text += "Đang ghép" + it2.ToString() + "\r\n";

                        Thread T = new Thread(() =>
                        {
                            mergeVideo(it2);

                        });
                        T.IsBackground = true;
                        T.Start();
                        T.Join();
                        buttonMerge.Enabled = true;
                        buttonMerge.Text = "Ghép video";
                    }

                    input.Clear();
                }

            }
            textBox_contents.Text += "Ghép xong \r\n";
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                cn.Open();
                string query_0 = "UPDATE dbo.StatusVideoLog SET StatusVideo = '0'";
                using (SqlCommand cmd = new SqlCommand(query_0, cn))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            frmEditQTYVideo new_fr = new frmEditQTYVideo();
            new_fr.Show();
        }
    }
}
