using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.DTO;
using DevComponents.DotNetBar;

namespace ManagementCenter
{
    public partial class frmComputerDetail : Form
    {
        public frmComputerDetail(Computer computer)
        {
            InitializeComponent();

            this.Text = computer.ComputerName;

            txtComputerName.Text = computer.ComputerName;
            txtCPU.Text = computer.CPUName;
            txtCreatedDate.Text = computer.CreateAt.ToString(Constant.DateTimeFormat);
            txtNetVer.Text = computer.DotNetVersion;
            txtOS.Text = computer.OS;
            txtOSVer.Text = computer.OSReleaseId.ToString();
            txtRAM.Text = computer.RAM.ToString() + " GB";
            _computer = computer;

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

        Computer _computer = new Computer();

        private void frmComputerDetail_Load(object sender, EventArgs e)
        {
            new Thread(() => {

                Invoke((MethodInvoker)delegate
                {
                    dataGridViewX1.DataSource = DAL_NetworkInterface.get_Interface_by_ComputerID(_computer.ComputerID);

                    swActive.Value = _computer.Status;
                });

            }).Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
