using Common.DTO;
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCenter
{
    public partial class frmRoomAdd : Form
    {
        public frmRoomAdd()
        {
            init();

        }

        void init()
        {
            InitializeComponent();

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

        public frmRoomAdd(Room room)
        {
            init();

            txtRoomName.Text = room.RoomName;
            cbActive.Checked = room.Status;
			txtComputerNameTemplate.Text = room.ComputerNameTemplate;
            isUpdate = true;
            _room = room;
        }

        private Room _room;
        private bool isUpdate;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRoomName.Text))
            {
                MessageBoxEx.Show("Tên phòng không được để trống!", "Lỗi");
            }
			else if (string.IsNullOrEmpty(txtComputerNameTemplate.Text))
			{
				MessageBoxEx.Show("Tên quy tắc đặt tên máy không được để trống!", "Lỗi");
			}
			else if(!isUpdate)
            {
                try
                {
                    int temp = DAL_Rooms.InsertRoom(new Room() { RoomName = txtRoomName.Text, Status = cbActive.Checked, ComputerNameTemplate = txtComputerNameTemplate.Text });
                    if (temp > 0)
                    {
                        MessageBoxEx.Show("Tạo phòng thành công!", "Xong");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBoxEx.Show("Tạo phòng thất bại!", "Lỗi");
                }

                frmRoom.LoadData();

                this.Close();
            }
            else if(isUpdate)
            {
                try
                {
                    _room.RoomName = txtRoomName.Text;
                    _room.Status = cbActive.Checked;
					_room.ComputerNameTemplate = txtComputerNameTemplate.Text;

                    int temp = DAL_Rooms.UpdateRoom(_room);
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

                frmRoom.LoadData();

                this.Close();
            }
        }
    }
}
