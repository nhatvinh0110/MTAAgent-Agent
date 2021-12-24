using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.DATA;
using System.Threading;
using DevComponents.DotNetBar.SuperGrid;
using ManagementCenter.GUI;
using DevComponents.DotNetBar;
using ManagementCenter.CustomControl;
using Common.CONFIG;
using Common.DTO;

namespace ManagementCenter
{
    public partial class frmComputer : Form
    {
        public frmComputer()
        {
            InitializeComponent();

            InitGridView();

            currentFilter = rbAll;


            //timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Tick);
            //timer.Interval = 8000;
        }

        System.Threading.Timer timer = null;

        System.Threading.Timer timer_ping = null;

        string searchRoom_temp, searchName_temp;

        string pingState;

        List<Computer> ls_Computers_temp = new List<Computer>();
        List<Computer> ls_Computers = new List<Computer>();

        bool TimerStopped = false;

        RadioButton currentFilter;

        //GridColumn gridColumn_Sort;

        //SortDirection gridColumn_sortDirection;

        frmError frmError;

        void InitGridView()
        {
            gridColumn_STT.Name = Constant.STT;

            gridColumn_RoomName.DataPropertyName = nameof(Computer.RoomName);
            gridColumn_RoomName.Name = Constant.RoomName_vi;

            gridColumn_ComputerName.DataPropertyName = nameof(Computer.ComputerName);
            gridColumn_ComputerName.Name = Constant.ComputerName_vi;

            gridColumn_AgentVer.DataPropertyName = nameof(Computer.AgentVersion);
            gridColumn_AgentVer.Name = Constant.AgentVersion_vi;

            gridColumn_LastUpdate.Name = Constant.LastUpdate_vi;
            gridColumn_LastUpdate.DataPropertyName = nameof(Computer.LastUpdate);

            gridColumn_Ping.Name = Constant.Ping_vi;
            gridColumn_Ping.DataPropertyName = nameof(Computer.Ping);

            gridColumn_State.EditorType = typeof(CustomGridImageEdit);
			gridColumn_State.DataPropertyName = nameof(Computer.S_State);
			gridColumn_State.Name = Constant.Status_vi;

            gridColumn_Action.Name = Constant.Action_vi;
            gridColumn_Action.EditorType = typeof(CustomRadiaMenu);

            ((CustomControl.CustomRadiaMenu)gridColumn_Action.EditControl).ItemClick += RadialDevice_ItemClick;
            ((CustomControl.CustomRadiaMenu)gridColumn_Action.EditControl).Click += RadialDevice_Click;

            gridColumn_CPUName.DataPropertyName = nameof(Computer.CPUName);
            gridColumn_CPUName.Name = Constant.CPUName_vi;

            gridColumn_Ram.DataPropertyName = nameof(Computer.RAM);
            gridColumn_Ram.Name = Constant.RAM_vi;

            gridColumn_OS.DataPropertyName = nameof(Computer.OS);
            gridColumn_OS.Name = Constant.OS_vi;

            gridColumn_OSReleaseId.DataPropertyName = nameof(Computer.OSReleaseId);
            gridColumn_OSReleaseId.Name = Constant.OSReleaseId_vi;

            gridColumn_Status.DataPropertyName = nameof(Computer.Status);
            gridColumn_Status.Name = nameof(Computer.Status);

            gridColumn_CreateAt.DataPropertyName = nameof(Computer.CreateAt);
            gridColumn_CreateAt.Name = Constant.CreateAt_vi;

            gridColumn_RoomID.DataPropertyName = nameof(Computer.RoomID);
            gridColumn_RoomID.Name = Constant.RoomID_vi;

            gridColumn_DotNetVersion.DataPropertyName = nameof(Computer.DotNetVersion);
            gridColumn_DotNetVersion.Name = Constant.DotNetVersion_vi;

            gridColumn_ComputerID.DataPropertyName = nameof(Computer.ComputerID);
            gridColumn_ComputerID.Name = Constant.ComputerID_vi;

            gridColumn_SecondsDiff.DataPropertyName = nameof(Computer.SecondsDiff);
            gridColumn_SecondsDiff.Name = nameof(Computer.SecondsDiff);

            gridColumn_S_State.DataPropertyName = nameof(Computer.State);
            gridColumn_S_State.Name = nameof(Computer.State);

        }


        string curentComputerID;
        private void RadialDevice_Click(object sender, EventArgs e)
        {
            try
            {
                curentComputerID = superGridControl1.GetCell(superGridControl1.ActiveRow.Index, superGridControl1.PrimaryGrid.Columns[Constant.ComputerID_vi].ColumnIndex).Value.ToString();
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
                RadialAction action = (RadialAction)((BaseItem)sender).Tag;

                Computer _computer = ls_Computers.Where(x => x.ComputerID == curentComputerID).FirstOrDefault();

                if (_computer == null)
                {
                    MessageBoxEx.Show("Có lỗi khi thực hiện yêu cầu!\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (action == RadialAction.Delete)
                {
                    if (frmMain.config.AUTO_UPDATE_COMPUTERSTATE)
                    {
                        MessageBoxEx.Show(this, "<h2>Tính năng <font color='#B02B2C'><u>tự động cập nhật dữ liệu</u></font> đang được <font color='#B02B2C'><u>bật</u></font>!</h2><h3>Vui lòng tắt trước khi trước khi thực hiện thao tác này!</h3>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBoxEx.Show(this, "<font size='14'><b>Bạn có chắc chắn muốn <font color='#B02B2C'><u>Xóa</u></font>?</b></font>", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_computer.State == Constant.Offline)
                        {
                            if (DAL_Computer.del_Computer(curentComputerID) > 0)
                            {
                                timer.Change(0, Timeout.Infinite);
                                MessageBoxEx.Show(this, "<h3>Xóa thành công!</h3>", "Xong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBoxEx.Show(this, "<h2>Có lỗi xảy ra khi xóa dữ liệu!</h2><h3>Vui lòng thử lại.</h3>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show(this, "<font size='14'><b>Không thể <font color='#B02B2C'><u>Xóa</u></font> máy đang <font color='#B02B2C'><u>Online</u></font>!</b></font>", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else if (action == RadialAction.Detail)
                {
                    frmComputerDetail frmComputerDetail = new frmComputerDetail(_computer);
                    frmComputerDetail.ShowDialog();
                }
                else if (action == RadialAction.Rename)
                {

                    frmComputerRoomChange frmComputerName = new frmComputerRoomChange(_computer.RoomID, _computer.ComputerID);
                    frmComputerName.ShowDialog();

                }
                else if (action == RadialAction.Network)
                {

                    DataTable dt = DAL_NetworkInterface.get_Interface_by_ComputerID(_computer.ComputerID);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBoxEx.Show("Không tìm thấy Card Internet của máy trạm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        frmComputer_NIC frmComputer_NIC = new frmComputer_NIC(dt, _computer.ComputerName);
                        frmComputer_NIC.ShowDialog();
                    }

                }
                else if(action == RadialAction.Event)
                {
                    frmComputerEvent frmComputerEvent = new frmComputerEvent(_computer.ComputerID);
                    frmComputerEvent.ShowDialog();
                }
            }
        }

        void filter(string state)
        {
            if (state == Constant.All)
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Computers_temp;
            }
            else if (state == Constant.Online)
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Computers_temp.Where(x => x.State == Constant.Online).ToList();
            }
            else
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Computers_temp.Where(x => x.State == Constant.Offline).ToList();
            }
        }

        private void rb_filter_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentFilter = rb;
            if (rb.Name == rbAll.Name)
            {
                filter(Constant.All);
            }
            else if (rb.Name == rbOnline.Name)
            {
                filter(Constant.Online);
            }
            else
            {
                filter(Constant.Offline);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                searchName_temp = cbComputerName.Text;
                searchRoom_temp = cbRooms.Text;
            }

            if (searchRoom_temp == Constant.All_vi && string.IsNullOrEmpty(searchName_temp))
            {
                // all room - all computer
                Search();
            }
            else if (searchRoom_temp != Constant.All_vi && !string.IsNullOrEmpty(searchName_temp))
            {
                // search room - search computer
                Search(searchName_temp, searchRoom_temp);
            }
            else if (searchRoom_temp == Constant.All_vi && !string.IsNullOrEmpty(searchName_temp))
            {
                // all room - search computer
                Search(searchName_temp);
            }
            else
            {
                // search room - all computer
                Search(searchName_temp + searchRoom_temp);
            }

            rb_filter_CheckedChanged(currentFilter, null);
        }

        void Search()
        {
            ls_Computers_temp = ls_Computers;
        }

        void Search(string ComputerName_Or_RoomName)
        {
            ls_Computers_temp = ls_Computers.Where(x => x.ComputerName.Contains(ComputerName_Or_RoomName) || x.RoomName.Contains(ComputerName_Or_RoomName)).ToList();
        }

        void Search(string ComputerName, string RoomName)
        {
            ls_Computers_temp = ls_Computers.Where(x => x.ComputerName.Contains(ComputerName) && x.RoomName.Contains(RoomName)).ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            searchName_temp = "";
            searchRoom_temp = Constant.All_vi;

            cbComputerName.Text = "";
            cbRooms.Text = Constant.All_vi;

            btnSearch_Click(null, null);

            rbAll.Checked = true;
            //rb_filter_Click(rbAll, null);
        }


        private void btnBlockRemote_Click(object sender, EventArgs e)
        {

            if (btnBlockRemote.Checked == false)
            {
                DialogResult result = MessageBoxEx.Show("Chặn dịch vụ Remote Desktop?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DAL_Setting.update_SettingValue(Constant.isDisableRemoteDesktop, "true") > 0)
                    {
                        btnBlockRemote.Checked = true;
                    }
                    else
                    {
                        MessageBoxEx.Show("Có lỗi khi lưu dữ liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBoxEx.Show("Hủy chặn dịch vụ Remote Desktop?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DAL_Setting.update_SettingValue(Constant.isDisableRemoteDesktop, "false") > 0)
                    {
                        btnBlockRemote.Checked = false;
                    }
                    else
                    {
                        MessageBoxEx.Show("Có lỗi khi lưu dữ liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBlockWifi_Click(object sender, EventArgs e)
        {
            if (btnBlockWifi.Checked == false)
            {
                DialogResult result = MessageBoxEx.Show("Chặn dịch vụ Wifi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DAL_Setting.update_SettingValue(Constant.isDisableWifi, "true") > 0)
                    {
                        btnBlockWifi.Checked = true;
                    }
                    else
                    {
                        MessageBoxEx.Show("Có lỗi khi lưu dữ liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                DialogResult result = MessageBoxEx.Show("Hủy chặn dịch vụ Wifi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DAL_Setting.update_SettingValue(Constant.isDisableWifi, "false") > 0)
                    {
                        btnBlockWifi.Checked = false;
                    }
                    else
                    {
                        MessageBoxEx.Show("Có lỗi khi lưu dữ liệu vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBlockWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBlockWifi.Checked == true)
            {
                btnBlockWifi.Text = Constant.UnBlockWifi;
            }
            else
            {
                btnBlockWifi.Text = Constant.BlockWifi;
            }
        }

        private void btnBlockRemote_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBlockRemote.Checked == true)
            {
                btnBlockRemote.Text = Constant.UnBlockRemote;
            }
            else
            {
                btnBlockRemote.Text = Constant.BlockRemote;
            }
        }

        private void frmComputer_Shown(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Invoke((MethodInvoker)delegate
                {
                    pnItems.Hide();
                    circularProgress1.Show();
                    circularProgress1.Value += 2;
                    circularProgress1.IsRunning = !circularProgress1.IsRunning;
                    circularProgress1.Refresh();
                });

                try
                {
                    DataTable dt_Rooms = DAL_Rooms.get_Rooms_Active();

                    DataRow dr = dt_Rooms.NewRow();
                    dr[Constant.RoomName] = Constant.All_vi;
                    dr[Constant.RoomID] = 0;

                    DataRow _dr = dt_Rooms.NewRow();
                    _dr[Constant.RoomName] = Constant.NotAvailable;
                    _dr[Constant.RoomID] = -1;
                    dt_Rooms.Rows.InsertAt(dr, 0);
                    dt_Rooms.Rows.InsertAt(_dr, 1);
                    Invoke((MethodInvoker)delegate
                    {
                        cbRooms.DataSource = dt_Rooms;
                        cbRooms.DisplayMember = Constant.RoomName;
                        cbRooms.ValueMember = Constant.RoomID;

                        cbComputerName.DisplayMember = Constant.ComputerName;
                        cbComputerName.ValueMember = Constant.ComputerID;

                    });

                    DataTable dt_Setting = DAL_Setting.get_Setting();

                    for (int i = 0; i < dt_Setting.Rows.Count; i++)
                    {
                        string key = dt_Setting.Rows[i][Constant.SettingKey].ToString();
                        string value = dt_Setting.Rows[i][Constant.SettingValue].ToString();

                        switch (key)
                        {
                            case Constant.isDisableRemoteDesktop:

                                Invoke((MethodInvoker)delegate
                                {
                                    if (Convert.ToBoolean(value) == true)
                                    {
                                        btnBlockRemote.Checked = true;
                                    }
                                    else
                                    {
                                        btnBlockRemote.Checked = false;
                                    }
                                });

                                break;
                            case Constant.isDisableWifi:

                                Invoke((MethodInvoker)delegate
                                {
                                    if (Convert.ToBoolean(value) == true)
                                    {
                                        btnBlockWifi.Checked = true;
                                    }
                                    else
                                    {
                                        btnBlockWifi.Checked = false;
                                    }
                                });

                                break;
                        }
                    }
                }
                catch (Exception io)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        frmError = new frmError(io.Message);
                        frmError.TopLevel = false;
                        frmError.Dock = DockStyle.Fill;
                        this.Controls.Add(frmError);
                        frmError.Show();
                        frmError.BringToFront();
                    });
                    TimerStopped = true;
                    Log_Helper.Error(io.Message, io);
                }
                finally
                {
                    Invoke((MethodInvoker)delegate
                    {
                        circularProgress1.Hide();
                        pnItems.Show();
                    });

                    timer_ping = new System.Threading.Timer(this.timerPing_tick, null, 0, frmMain.config.AUTO_PING * 1000);
                }
            }).Start();

            if (Convert.ToBoolean(frmMain.config.AUTO_UPDATE_COMPUTERSTATE) == true)
            {
                timer = new System.Threading.Timer(this.timer_Tick, null, Timeout.Infinite, Timeout.Infinite);

                switchAutoUpdate.Value = true;
            }
            else
            {
                timer = new System.Threading.Timer(this.timer_Tick, null, 0, Timeout.Infinite);

                switchAutoUpdate.Value = false;
            }

            sliderAutoUpdate.Value = frmMain.config.AUTO_UPDATE_COMPUTERDATA;
        }

        private void timer_Tick(object sender)
        {
            try
            {
                ls_Computers = DAL_Computer.get_ComputersAsList_Include_RoomName(frmMain.dataProvider_timerComputer).OrderBy(x => x.ComputerName).ToList();
                ls_Computers_temp = ls_Computers;
                int CountOnline = 0;
                int CountOffline = 0;


                for (int i = 0; i < ls_Computers_temp.Count; i++)
                {
                    if (ls_Computers_temp[i].SecondsDiff > 10)
                    {
                        ls_Computers_temp[i].S_State = Properties.Resources.offline;
                        ls_Computers_temp[i].State = Constant.Offline;
                        ls_Computers_temp[i].Ping = Constant.NotAvailable;

                        CountOffline++;
                    }
                    else
                    {
                        ls_Computers_temp[i].S_State = Properties.Resources.online;
                        ls_Computers_temp[i].State = Constant.Online;
                        CountOnline++;
                    }
                }

                Invoke((MethodInvoker)delegate
                {

                    superGridControl1.Enabled = false;
                    btnSearch_Click(null, null);
                    //superGridControl1.PrimaryGrid.SetSort(gridColumn_Sort, gridColumn_sortDirection);
                    superGridControl1.Enabled = true;

                    lball.Text = ls_Computers.Count.ToString();
                    lbOffline.Text = CountOffline.ToString();
                    lbOnline.Text = CountOnline.ToString();

                    string temp = cbComputerName.Text;
                    cbComputerName.DataSource = ls_Computers.OrderBy(x => x.ComputerName).ToList();
                    cbComputerName.Text = temp;
                    cbComputerName.SelectionStart = cbComputerName.Text.Length;
                    lbLastUpdate.Text = Constant.LastUpdate_vi + ": " + DateTime.Now.ToString(Constant.DateTimeFormat2);

                    if (frmMain.config.AUTO_UPDATE_COMPUTERSTATE)
                    {
                        lbAuto.Symbol = Constant.AutoUpdate_ON_Icon;
                        lbAuto.Text = Constant.AutoUpdate_ON;
                    }
                    else
                    {
                        lbAuto.Symbol = Constant.AutoUpdate_OFF_Icon;
                        lbAuto.Text = Constant.AutoUpdate_OFF;
                    }
                });

            }
            catch (Exception op)
            {
                Invoke((MethodInvoker)delegate
                {
                    timer.Change(Timeout.Infinite, Timeout.Infinite);
                    TimerStopped = true;

                    lbAuto.Symbol = Constant.AutoUpdate_Error_Icon;
                    lbAuto.Text = Constant.AutoUpdate_Error;
                });
            }
        }

        private void timerPing_tick(object sender)
        {
            lbPing.Invoke((MethodInvoker)delegate
            {
                lbPing.Text = Common.Network.NetTool.Ping(frmMain.dataProvider.cnn.DataSource, ref pingState);
                if (pingState == Constant.Success)
                {
                    lbPing.SymbolColor = Color.DarkGreen;

                    if (TimerStopped && frmMain.config.AUTO_UPDATE_COMPUTERSTATE)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (frmError != null)
                                frmError.Hide();
                        });
                        TimerStopped = false;
                        timer.Change(0, frmMain.config.AUTO_UPDATE_COMPUTERDATA * 1000);
                    }
                }
                else if (pingState == Constant.Error)
                {
                    lbPing.SymbolColor = Color.Red;
                }
                else
                {
                    lbPing.SymbolColor = Color.DarkOrange;
                }
            });
        }

        private void superGridControl1_ColumnHeaderClick(object sender, GridColumnHeaderClickEventArgs e)
        {
            //gridColumn_Sort = e.GridColumn;

            //if (gridColumn_sortDirection == SortDirection.None || gridColumn_sortDirection == SortDirection.Ascending)
            //{
            //    gridColumn_sortDirection = SortDirection.Descending;
            //}
            //else
            //{
            //    gridColumn_sortDirection = SortDirection.Ascending;
            //}

            //superGridControl1.PrimaryGrid.SetSort(gridColumn_Sort, gridColumn_sortDirection);
        }

        private void superGridControl1_GetRowCellStyle(object sender, GridGetRowCellStyleEventArgs e)
        {
            if (e.GridRow.Index % 2 == 0)
            {
                e.Style.Background = new DevComponents.DotNetBar.SuperGrid.Style.Background(Color.Snow);
            }
            else
            {
                e.Style.Background = new DevComponents.DotNetBar.SuperGrid.Style.Background(Color.FromArgb(232, 232, 232));
            }


            //e.Style.BorderPattern = new Style.BorderPattern(DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Dot);
            //e.Style.BorderColor = new Style.BorderColor(Color.Red);
            // this.superGridControl1.PrimaryGrid.GridLines

        }

        private void superGridControl1_GetColumnHeaderStyle(object sender, GridGetColumnHeaderStyleEventArgs e)
        {
            //e.Style.BorderColor = new Style.BorderColor(Color.Red);
            e.Style.Background = new DevComponents.DotNetBar.SuperGrid.Style.Background(Color.LightSteelBlue);
        }

        private void sliderAutoUpdate_ValueChanged(object sender, EventArgs e)
        {
            if (Config_Helper.SetValue(Constant.AUTO_UPDATE_COMPUTERDATA, sliderAutoUpdate.Value.ToString()))
            {
                sliderAutoUpdate.Text = Constant.Slider_AutoUpdate_Text.Replace("%", sliderAutoUpdate.Value.ToString());
            }
            else
            {
                MessageBoxEx.Show(string.Join(Environment.NewLine, new string[] { "Có lỗi khi lưu tệp tin cấu hình!", "Vui lòng thử lại." }), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchAutoUpdate_ValueChanged(object sender, EventArgs e)
        {
            if (Config_Helper.SetValue(Constant.AUTO_UPDATE_COMPUTERSTATE, switchAutoUpdate.Value.ToString()))
            {
                if (switchAutoUpdate.Value)
                {
                    frmMain.config.AUTO_UPDATE_COMPUTERSTATE = switchAutoUpdate.Value;
                    lbAuto.Text = Constant.AutoUpdate_ON;
                    lbAuto.Symbol = Constant.AutoUpdate_ON_Icon;

                    timer.Change(0, frmMain.config.AUTO_UPDATE_COMPUTERDATA * 1000);
                }
                else
                {
                    frmMain.config.AUTO_UPDATE_COMPUTERSTATE = switchAutoUpdate.Value;
                    lbAuto.Text = Constant.AutoUpdate_OFF;
                    lbAuto.Symbol = Constant.AutoUpdate_OFF_Icon;

                    timer.Change(Timeout.Infinite, Timeout.Infinite);
                }
            }
            else
            {
                MessageBoxEx.Show(string.Join(Environment.NewLine, new string[] { "Có lỗi khi lưu tệp tin cấu hình!", "Vui lòng thử lại." }), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void superGridControl1_GetCellValue(object sender, GridGetCellValueEventArgs e)
        {
            if (e.GridCell.GridColumn == gridColumn_STT)
            {
                e.GridCell.Value = e.GridCell.GridRow.Index + 1;
            }
        }
    }
}
