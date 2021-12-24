using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Common;


namespace ManagementCenter
{
    public partial class pnInterfaceItem : UserControl
    {
        public pnInterfaceItem()
        {
            InitializeComponent();
        }

        public void SetColor(int stt)
        {
            if (stt % 2 == 0)
            {
                this.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
        }

        //public NetInterface xcomputer = new NetInterface();

        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    if(lbState.Text == Constant.Offline)
        //    {
        //        //frmMain.dataProvider.ExecuteNonQuery("");
        //    }
        //    else
        //    {
        //        MessageBoxEx.Show("Không thể xóa khi máy đang Online!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnDetail_Click(object sender, EventArgs e)
        //{
        //    frmComputerDetail computerDetail = new frmComputerDetail(computer);
        //    computerDetail.ShowDialog();
        //}

        //private void btnChangeName_Click(object sender, EventArgs e)
        //{
        //    frmComputerNameChange frmComputerName = new frmComputerNameChange(computer.roomName, computer.ComputerID, computer.ComputerName);
        //    frmComputerName.ShowDialog();
        //}
    }
}
