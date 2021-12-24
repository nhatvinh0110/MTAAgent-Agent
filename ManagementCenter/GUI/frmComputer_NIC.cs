using System;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using System.Collections;

namespace ManagementCenter
{
    public partial class frmComputer_NIC : Form
    {
        public frmComputer_NIC(DataTable networkInterface, string computerName)
        {
            InitializeComponent();
            this.Text = computerName + " Internet Connection";
            dataGridViewX1.DataSource = networkInterface;

            // ẩn button minimize
            ArrayList items = ribbonControl1.RibbonStrip.GetItems("", typeof(SystemCaptionItem));
            foreach (SystemCaptionItem sci in items)
            {
                if (!sci.IsSystemIcon)
                {
                    sci.MinimizeEnabled = false;
                    sci.MinimizeVisible = false;

                    sci.RestoreMaximizeVisible = false;
                    sci.RestoreEnabled = false;
                    break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
