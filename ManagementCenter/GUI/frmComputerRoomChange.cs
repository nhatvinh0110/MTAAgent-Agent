using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.ANSIBLE;
using Common;
using DevComponents.DotNetBar;
using System.Collections;

namespace ManagementCenter
{
    public partial class frmComputerRoomChange : Form
    {
        public frmComputerRoomChange(int CurentRoomID, string computerID)
        {
            InitializeComponent();
            _CurentRoomID = CurentRoomID;
            _ComputerID = computerID;

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

            DataTable dt_Rooms = DAL_Rooms.get_Rooms_Active();
            cbRooms.DataSource = dt_Rooms;
            cbRooms.DisplayMember = Constant.RoomName;
            cbRooms.ValueMember = Constant.RoomID;

            cbRooms.SelectedValue = CurentRoomID;

        }

        private int _CurentRoomID;
        private string _ComputerID;

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = DAL_Computer.Update_ComputerRoom((int)cbRooms.SelectedValue, _ComputerID);
                if (temp > 0)
                {
                    MessageBoxEx.Show("Cập nhật phòng thành công!", "Xong");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBoxEx.Show("Cập nhật phòng thất bại!", "Lỗi");
            }

            this.Close();
        }

    }
}
