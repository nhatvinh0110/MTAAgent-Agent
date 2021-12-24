using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ManagementCenter.GUI;
using Common.DATA;
using Common;
using Common.DTO;
using Common.CONFIG;
using ManagementCenter.GUI_TEST;

namespace ManagementCenter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // ẩn button minimize
            //ArrayList items = ribbonControlMain.RibbonStrip.GetItems("", typeof(SystemCaptionItem));
            //foreach (SystemCaptionItem sci in items)
            //{
            //    if (!sci.IsSystemIcon)
            //    {
            //        sci.MinimizeEnabled = false;
            //        sci.MinimizeVisible = false;
            //        break;
            //    }
            //}
        }

        public static string con;

        public static AppConfig config = new AppConfig();

        public static DataProvider dataProvider;

        public static DataProvider dataProvider_timerComputer;

        public static DataProvider dataProvider_timerNIC;

        frmComputer frmComputer;

        frmDatabaseBackup frmdatabaseBackup;

        frmDatabaseRestore frmDatabaseRestore;

        frmConnectMSSQL frmConnectMSSQL;

        frm_Network frmNetwork;

        frmRoom frmRoom;

        frmReport frmReport;

        frmEvent frmEvent;

        fm_LogInfo fm_LogInfo;
        fr_getvideos fr_Getvideos;

        public static void Add_Controls(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }


        private void btnTrangthai_Click(object sender, EventArgs e)
        {
            frmComputer.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSaoluuCSDL_Click(object sender, EventArgs e)
        {
            frmdatabaseBackup.BringToFront();
            frmdatabaseBackup.LoadData();
        }

        private void btnKhoiphucCSDL_Click(object sender, EventArgs e)
        {
            frmDatabaseRestore.BringToFront();
            frmDatabaseRestore.LoadData();
        }

        private void btnKetnoiSQL_Click(object sender, EventArgs e)
        {
            frmConnectMSSQL.BringToFront();
        }


        private void btnInternet_Click(object sender, EventArgs e)
        {
            frmNetwork.BringToFront();
        }

        private void ribbonControlMain_Resize(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            //this.Hide();
        }

        private void frmMain_ClientSizeChanged(object sender, EventArgs e)
        {
            //this.ResumeLayout();
            //this.Show();
        }


        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x0112) // WM_SYSCOMMAND
        //    {
        //        // Check your window state here
        //        if (m.WParam == new IntPtr(0xF030) || m.WParam == new IntPtr(0XF120)) // Maximize event - SC_MAXIMIZE from Winuser.h
        //        {


        //            //this.Hide();

        //            //new Thread(() =>
        //            //{
        //            //    Thread.CurrentThread.IsBackground = true;
        //            //    Thread.Sleep(1000);
        //            //    pnCenter.Invoke(new Action(() => pnCenter.Show()));
        //            //}).Start();
        //            // THe window is being maximized
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

        public static void LoadConfig()
        {

            try
            {
                config.SQL_DB_NAME = Config_Helper.GetValue(Constant.SQL_DB_NAME, "");

                config.SQL_PASSWORD = Config_Helper.GetValue(Constant.SQL_PASSWORD, "");

                config.SQL_SERVER = Config_Helper.GetValue(Constant.SQL_SERVER, "");

                config.SQL_USER = Config_Helper.GetValue(Constant.SQL_USER, "");

                config.AUTO_PING = Convert.ToInt32(Config_Helper.GetValue(Constant.AUTO_PING, "2"));

                config.AUTO_UPDATE_COMPUTERDATA = Convert.ToInt32(Config_Helper.GetValue(Constant.AUTO_UPDATE_COMPUTERDATA, "8"));

                config.AUTO_UPDATE_COMPUTERSTATE = Convert.ToBoolean(Config_Helper.GetValue(Constant.AUTO_UPDATE_COMPUTERSTATE, "true"));

                config.AUTO_UPDATE_NICDATA = Convert.ToInt32(Config_Helper.GetValue(Constant.AUTO_UPDATE_NICDATA, "8"));

                config.AUTO_UPDATE_NICSTATE = Convert.ToBoolean(Config_Helper.GetValue(Constant.AUTO_UPDATE_NICSTATE, "true"));

                con = @"Data Source = " + config.SQL_SERVER
                + "; Initial Catalog = " + config.SQL_DB_NAME + "; User ID = "
                + config.SQL_USER + "; Password = "
                + config.SQL_PASSWORD + ";multipleactiveresultsets=True ; Connection Timeout = 10";

                dataProvider = new DataProvider(con);

                dataProvider_timerComputer = new DataProvider(con);

                dataProvider_timerNIC = new DataProvider(con);

            }
            catch (Exception io)
            {
                MessageBoxEx.Show("Có lỗi khi đọc tệp tin cấu hình!" + Environment.NewLine + Environment.NewLine + io.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            LoadConfig();

            new Thread(() =>
            {
                Log_Helper.customDBAppender = new CustomDBAppender(con);
            }).Start();

            frmConnectMSSQL = new frmConnectMSSQL();

            frmComputer = new frmComputer();

            frmdatabaseBackup = new frmDatabaseBackup();

            frmDatabaseRestore = new frmDatabaseRestore();

            frmNetwork = new frm_Network();

            frmRoom = new frmRoom();

            frmReport = new frmReport();

            frmEvent = new frmEvent();

            fm_LogInfo = new fm_LogInfo();
            fr_Getvideos = new fr_getvideos();

            Add_Controls(frmComputer, pnCenter);

            Add_Controls(frmdatabaseBackup, pnCenter);

            Add_Controls(frmDatabaseRestore, pnCenter);

            Add_Controls(frmConnectMSSQL, pnCenter);

            Add_Controls(frmNetwork, pnCenter);

            Add_Controls(frmRoom, pnCenter);

            Add_Controls(frmReport, pnCenter);

            Add_Controls(frmEvent, pnCenter);
            Add_Controls(fm_LogInfo, pnCenter);
            Add_Controls(fr_Getvideos, pnCenter);

            //this.ClientSizeChanged += new System.EventHandler(this.frmMain_ClientSizeChanged);

        }

        private void btnDanhsachPhong_Click(object sender, EventArgs e)
        {
            frmRoom.BringToFront();
            frmRoom.LoadData();
        }

        private void btnComputerName_Click(object sender, EventArgs e)
        {
            frmReport.BringToFront();
            frmReport.LoadData();

        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            frmEvent.BringToFront();
        }

       
        

        

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            fm_LogInfo.BringToFront();
        }

        private void button_get_videos_Click(object sender, EventArgs e)
        {
            fr_Getvideos.BringToFront();
        }
    }
}
