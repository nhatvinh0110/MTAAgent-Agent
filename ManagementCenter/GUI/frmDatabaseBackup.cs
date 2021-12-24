using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Common;
using Common.SMO;
using Common.FILE;

namespace ManagementCenter.GUI
{
    public partial class frmDatabaseBackup : Form
    {
        public frmDatabaseBackup()
        {
            InitializeComponent();
            circularProgress1.Hide();
            circularProgress1.Value += 2;
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            circularProgress1.Refresh();
        }

        private string BackupPath = Constant.FolderName_DatabaseBackup + @"\";

        private void btnBackupNow_Click(object sender, EventArgs e)
        {
            btnBackupNow.Enabled = false;
            new Thread(() =>
            {
                Invoke((MethodInvoker)delegate {
                    circularProgress1.Show();
                });

                SMOClient.GetTransferScript(BackupPath + DateTime.Now.ToString(Constant.FileName_DateTimeFormat) + ".sql", frmMain.config.SQL_SERVER, frmMain.config.SQL_USER, frmMain.config.SQL_PASSWORD, frmMain.config.SQL_DB_NAME);

                Invoke((MethodInvoker)delegate
                {
                    LoadData();
                    circularProgress1.Hide();
                    btnBackupNow.Enabled = true;
                });
            }).Start();

        }

        private void lbItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
            //MessageBoxEx.Show(BackupPath + linkLabel.Name);
            Process.Start("notepad.exe", BackupPath + linkLabel.Name);
        }

        LinkLabel CreateItem(string Name)
        {
            LinkLabel lbItem = new LinkLabel();
            lbItem.Dock = DockStyle.Top;
            lbItem.Location = new Point(0, 0);
            lbItem.Name = Name;
            lbItem.Size = new Size(651, 34);
            lbItem.TabIndex = 2;
            lbItem.TabStop = true;
            lbItem.Text = @"...\\" + Constant.FolderName_DatabaseBackup + @"\\" + Name;
            lbItem.TextAlign = ContentAlignment.MiddleCenter;
            lbItem.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lbItem_LinkClicked);
            return lbItem;
        }

        public void LoadData()
        {
            pnItems.Controls.Clear();
            List<string> temp = File_Helper.Get_ListFile(BackupPath);

            foreach (var i in temp)
            {
                pnItems.Controls.Add(CreateItem(i));
            }
        }
    }
}
