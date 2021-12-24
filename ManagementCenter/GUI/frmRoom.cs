using Common;
using Common.DTO;
using ManagementCenter.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.DATA;
using DevComponents.DotNetBar;

namespace ManagementCenter
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }        

        void InitGridView()
        {
            gridColumn_STT.Name = Constant.STT;

            gridColumn_RoomName.DataPropertyName = nameof(Room.RoomName);
            gridColumn_RoomName.Name = Constant.RoomName_vi;

            gridColumn_ComputerCount.Name = Constant.ComputerCount;

            gridColumn_LastUpdate.Name = Constant.LastUpdate_vi;
            gridColumn_LastUpdate.DataPropertyName = nameof(Room.UpdatedDate);

            gridColumn_State.DataPropertyName = nameof(Room.Status);
            gridColumn_State.Name = Constant.Status_vi;

            gridColumn_Action.Name = Constant.Action_vi;
            gridColumn_Action.EditorType = typeof(CustomRadiaMenuRoom);

            gridColumn_ComputerCount.DataPropertyName = "ComputerCount";

            gridColumn1.Name = Constant.RoomID;
            gridColumn1.DataPropertyName = nameof(Room.RoomID);

			gridColumn2.DataPropertyName = nameof(Room.ComputerNameTemplate);



            ((CustomControl.CustomRadiaMenuRoom)gridColumn_Action.EditControl).ItemClick += RadialDevice_ItemClick;
            ((CustomControl.CustomRadiaMenuRoom)gridColumn_Action.EditControl).Click += RadialDevice_Click;


        }

        static List<Room> ls_Rooms;
        public static void LoadData()
        {
            ls_Rooms = DAL_Rooms.get_Rooms_Include_ComputerCount();
            superGridControl1.PrimaryGrid.DataSource = ls_Rooms;
        }

        int curentRoomID;
        private void RadialDevice_Click(object sender, EventArgs e)
        {
            try
            {
                curentRoomID = (int)superGridControl1.GetCell(superGridControl1.ActiveRow.Index, superGridControl1.PrimaryGrid.Columns[Constant.RoomID].ColumnIndex).Value;
            }
            catch
            {
                RadialMenu rd = sender as RadialMenu;
                rd.IsOpen = false;
            }
        }


        private void RadialDevice_ItemClick(object sender, EventArgs e)
        {

            if (((BaseItem)sender).Tag != null)
            {
                RadialActionRoom action = (RadialActionRoom)((BaseItem)sender).Tag;
                Room _room = ls_Rooms.Where(x => x.RoomID == curentRoomID).FirstOrDefault();

                if (action == RadialActionRoom.Delete)
                {
                    if (MessageBoxEx.Show(this, "<font size='14'><b>Bạn có chắc chắn muốn <font color='#B02B2C'><u>Xóa</u></font>?</b></font>", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_room.ComputerCount == 0)
                        {
                            if (DAL_Rooms.DeleteRoom(_room.RoomID) > 0)
                            {
                                MessageBoxEx.Show(this, "<h3>Xóa thành công!</h3>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBoxEx.Show(this, "<h2>Có lỗi xảy ra khi xóa dữ liệu!</h2><h3>Vui lòng thử lại.</h3>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show(this, "<font size='14'><b>Không thể <font color='#B02B2C'><u>Xóa</u></font> phòng đang có số máy tính khác 0.</b></font>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadData();
                    }

                }
                else if (action == RadialActionRoom.Edit)
                {
                    frmRoomAdd frmRoomAdd = new frmRoomAdd(_room);
                    frmRoomAdd.Text = "Cập nhật phòng";

                    frmRoomAdd.ShowDialog();
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmRoomAdd frmRoomAdd = new frmRoomAdd();

            frmRoomAdd.ShowDialog();
        }

        private void superGridControl1_GetCellValue(object sender, DevComponents.DotNetBar.SuperGrid.GridGetCellValueEventArgs e)
        {
            if (e.GridCell.GridColumn == gridColumn_STT)
            {
                e.GridCell.Value = e.GridCell.GridRow.Index + 1;
            }
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmRoom_Shown(object sender, EventArgs e)
        {

        }
    }
}
