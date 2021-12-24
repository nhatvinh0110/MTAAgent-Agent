using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.FILE;
using Common;
using Common.SMO;

namespace ManagementCenter.GUI
{
    public partial class frmDatabaseRestore : Form
    {
        public frmDatabaseRestore()
        {
            InitializeComponent();
        }

        private string BackupPath = Constant.FolderName_DatabaseBackup + @"\";


        public void LoadData()
        {
            pnItems.Controls.Clear();
            List<string> temp = File_Helper.Get_ListFile(BackupPath);

            for(int i = 0; i< temp.Count; i++)
            {
                if (i + 1 == temp.Count)
                {
                    pnItems.Controls.Add(CreateItem(temp[i], true));
                }
                else
                {
                    pnItems.Controls.Add(CreateItem(temp[i], false));
                }
            }
        }

        RadioButton CreateItem(string Name, bool Checked)
        {
            RadioButton rdItem = new RadioButton();
            rdItem.Appearance = System.Windows.Forms.Appearance.Button;
            rdItem.BackColor = System.Drawing.SystemColors.ControlLight;
            rdItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            rdItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            rdItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rdItem.Dock = System.Windows.Forms.DockStyle.Top;
            rdItem.Location = new System.Drawing.Point(0, 0);
            rdItem.Name = Name;
            rdItem.Size = new System.Drawing.Size(431, 34);
            rdItem.TabIndex = 0;
            rdItem.Text = @"...\\" + Constant.FolderName_DatabaseBackup + @"\\" + Name;
            rdItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rdItem.UseVisualStyleBackColor = true;
            rdItem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            rdItem.Checked = Checked;
            return rdItem;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb.Checked)
            {
                btnRestoreNow.Text = "Khôi phục phiên bản \n" + rb.Name;
                btnRestoreNow.Tag = rb.Name;
            }
        }

        private void btnRestoreNow_Click(object sender, EventArgs e)
        {
            try
            {
                SMOClient.ExcuteScript(BackupPath + btnRestoreNow.Tag.ToString(), frmMain.config.SQL_SERVER, frmMain.config.SQL_USER, frmMain.config.SQL_PASSWORD, frmMain.config.SQL_DB_NAME);

            }
            catch (Exception op)
            {
                //return op;
            }
        }
    }
}
