using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ManagementCenter.GUI;
using Common.DATA;
using Common;
using Common.DTO;
using ManagementCenter.CustomControl;
using DevComponents.DotNetBar.SuperGrid;
using System.Drawing;
using Common.CONFIG;
using DevComponents.DotNetBar;

namespace ManagementCenter.GUI_TEST
{
    public partial class frm_Network : Form
    {
        public frm_Network()
        {
            InitializeComponent();

            InitGridView();

            currentFilter = rbAll;

        }

        System.Threading.Timer timer = null;

        System.Threading.Timer timer_ping = null;

        RadioButton currentFilter;

        string searchIP_temp, searchMAC_temp;

        Dictionary<string, pnInterfaceItem> Dic_pnInterface = new Dictionary<string, pnInterfaceItem>();

        List<pnInterfaceItem> ls_pnInterface = new List<pnInterfaceItem>();

        string pingState;

        frmError frmError;

        void InitGridView()
        {
            gridColumn_STT.Name = Constant.STT;

            gridColumn_nicName.DataPropertyName = nameof(NetInterface.NetInterfaceName);
            gridColumn_nicName.Name = Constant.NetworkConnection_vi;

            gridColumn_nicID.DataPropertyName = nameof(NetInterface.NetInterfaceID);
            gridColumn_nicID.Name = Constant.NetInterfaceID;

            gridColumn_ComputerName.DataPropertyName = nameof(NetInterface.ComputerName);
            gridColumn_ComputerName.Name = Constant.ComputerName_vi;

            gridColumn_IP.DataPropertyName = nameof(NetInterface.List_IPv4);
            gridColumn_IP.Name = Constant.IP;

            gridColumn_LastUpdate.Name = Constant.LastUpdate_vi;
            gridColumn_LastUpdate.DataPropertyName = nameof(NetInterface.LastUpdate);

            gridColumn_MAC.Name = Constant.MAC;
            gridColumn_MAC.DataPropertyName = nameof(NetInterface.MAC);

            gridColumn_State_icon.DataPropertyName = nameof(NetInterface.State_icon);
            gridColumn_State_icon.EditorType = typeof(CustomGridImageEdit);
            gridColumn_State_icon.Name = Constant.Status_vi;

            gridColumn_Description.DataPropertyName = nameof(NetInterface.Description);
            gridColumn_Description.Name = Constant.Description_vi;

            gridColumn_Status.DataPropertyName = nameof(NetInterface.Status);
            gridColumn_Status.Name = nameof(NetInterface.Status);

            gridColumn_ComputerID.DataPropertyName = nameof(NetInterface.ComputerID);
            gridColumn_ComputerID.Name = Constant.ComputerID_vi;

            gridColumn_SecondsDiff.DataPropertyName = nameof(NetInterface.SecondsDiff);
            gridColumn_SecondsDiff.Name = nameof(NetInterface.SecondsDiff);

            gridColumn_state.DataPropertyName = nameof(NetInterface.State);
            gridColumn_state.Name = nameof(NetInterface.State);

        }

        List<NetInterface> ls_Interfaces;

        List<NetInterface> ls_Interfaces_temp;

        bool TimerStopped = false;

        private void timer_Tick(object sender)
        {
            try
            {
                ls_Interfaces = DAL_NetworkInterface.get_InterfaceAsList_Include_ComputerName(frmMain.dataProvider_timerNIC).OrderBy(x => x.ComputerName).ToList();

                ls_Interfaces_temp = ls_Interfaces;

                int CountUp = 0;
                int CountDown = 0;
                int CountOffline = 0;


                for (int i = 0; i < ls_Interfaces_temp.Count; i++)
                {

                    if (ls_Interfaces_temp[i].SecondsDiff > 8)
                    {
                        ls_Interfaces_temp[i].State_icon = Properties.Resources.offline;
                        ls_Interfaces_temp[i].State = Constant.Offline;


                        CountOffline++;
                    }
                    else if (ls_Interfaces_temp[i].SecondsDiff <= 8 && ls_Interfaces_temp[i].State.ToLower() == Constant.Up.ToLower())
                    {
                        ls_Interfaces_temp[i].State_icon = Properties.Resources.online;
                        ls_Interfaces_temp[i].State = Constant.Up;

                        CountUp++;


                    }
                    else
                    {
                        ls_Interfaces_temp[i].State_icon = Properties.Resources.warning_1;
                        ls_Interfaces_temp[i].State = Constant.Down;

                        CountDown++;

                    }
                }

                Invoke((MethodInvoker)delegate
                {
                    superGridControl1.Enabled = false;
                    btnSearch_Click(null, null);
                    superGridControl1.Enabled = true;


                    lball.Text = ls_Interfaces.Count.ToString();
                    lbOffline.Text = CountOffline.ToString();
                    lbUp.Text = CountUp.ToString();
                    lbDown.Text = CountDown.ToString();


                    string temp = cbMAC.Text;
                    cbMAC.DataSource = ls_Interfaces.Select(x => x.MAC).Distinct().ToList();
                    cbMAC.DisplayMember = Constant.MAC;
                    cbMAC.Text = temp;
                    cbMAC.SelectionStart = cbMAC.Text.Length;

                    string temp1 = cbIP.Text;
                    List<string> listIP = new List<string>();

                    foreach (var lip in ls_Interfaces.Select(t => t.List_IPv4).ToList().OrderBy(x => x).ToList())
                    {
                        listIP.AddRange(lip.Split(new string[] { Constant.char_Join }, StringSplitOptions.None));
                    }

                    cbIP.DataSource = listIP.Distinct().ToList();
                    cbIP.Text = temp1;
                    cbIP.SelectionStart = cbIP.Text.Length;

                    lbLastUpdate.Text = Constant.LastUpdate_vi + ": " + DateTime.Now.ToString(Constant.DateTimeFormat2);

                    if (frmMain.config.AUTO_UPDATE_NICSTATE)
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
            catch (Exception io)
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

                    if (TimerStopped && frmMain.config.AUTO_UPDATE_NICSTATE)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (frmError != null)
                                frmError.Hide();
                        });
                        TimerStopped = false;
                        timer.Change(0, frmMain.config.AUTO_UPDATE_NICDATA * 1000);
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


        void filter(string state)
        {
            if (state == Constant.All)
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Interfaces_temp;
            }
            else if (state == Constant.Up)
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Interfaces_temp.Where(x => x.State == Constant.Up).ToList();
            }
            else if (state == Constant.Offline)
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Interfaces_temp.Where(x => x.State == Constant.Offline).ToList();
            }
            else
            {
                superGridControl1.PrimaryGrid.DataSource = ls_Interfaces_temp.Where(x => x.State == Constant.Down).ToList();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                searchIP_temp = cbIP.Text;
                searchMAC_temp = cbMAC.Text;
            }

            if (string.IsNullOrEmpty(searchMAC_temp) && string.IsNullOrEmpty(searchIP_temp))
            {
                // all
                Search();
            }
            else if (!string.IsNullOrEmpty(searchMAC_temp) && !string.IsNullOrEmpty(searchIP_temp))
            {
                // all IP and search MAC
                Search(searchMAC_temp, searchIP_temp);
            }
            else
            {
                // search IP or - search MAC
                Search(searchIP_temp + searchMAC_temp);
            }

            rb_filter_CheckedChanged(currentFilter, null);

        }

        private void rb_filter_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            currentFilter = rb;
            if (rb.Name == rbAll.Name)
            {
                filter(Constant.All);
            }
            else if (rb.Name == rbUp.Name)
            {
                filter(Constant.Up);
            }
            else if (rb.Name == rbDown.Name)
            {
                filter(Constant.Down);
            }
            else
            {
                filter(Constant.Offline);
            }
        }

        void Search()
        {
            ls_Interfaces_temp = ls_Interfaces;
        }

        void Search(string MAC_Or_IP)
        {
            ls_Interfaces_temp = ls_Interfaces.Where(x => x.List_IPv4.Contains(MAC_Or_IP) || x.MAC.Contains(MAC_Or_IP)).ToList();
        }

        void Search(string MAC, string IP)
        {
            ls_Interfaces_temp = ls_Interfaces.Where(x => x.MAC.Contains(MAC) && x.List_IPv4.Contains(IP)).ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            searchMAC_temp = "";
            searchIP_temp = "";

            cbMAC.Text = "";
            cbIP.Text = "";

            btnSearch_Click(null, null);

            rbAll.Checked = true;

        }

        private void pnItems_ClientSizeChanged(object sender, EventArgs e)
        {
            //if (pnItems.VerticalScroll.Visible && ScrollActived == false)
            //{
            //    ScrollActived = true;
            //    tableLayoutPanel1.ColumnStyles[7].Width = tableLayoutPanel1.ColumnStyles[7].Width + SystemInformation.VerticalScrollBarWidth;
            //}
            //else if (pnItems.VerticalScroll.Visible == false && ScrollActived == true)
            //{
            //    ScrollActived = false;
            //    tableLayoutPanel1.ColumnStyles[7].Width = tableLayoutPanel1.ColumnStyles[7].Width - SystemInformation.VerticalScrollBarWidth;
            //}
        }

        private void frmNetwork_Shown(object sender, EventArgs e)
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

                Thread.Sleep(2000);

                try
                {
                    if (frmMain.dataProvider_timerNIC.cnn.State == ConnectionState.Closed)
                        frmMain.dataProvider_timerNIC.cnn.Open();
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

                if (Convert.ToBoolean(frmMain.config.AUTO_UPDATE_NICSTATE) == true)
                {
                    timer = new System.Threading.Timer(this.timer_Tick, null, Timeout.Infinite, Timeout.Infinite);

                    switchAutoUpdate.Value = true;
                }
                else
                {
                    timer = new System.Threading.Timer(this.timer_Tick, null, 0, Timeout.Infinite);

                    switchAutoUpdate.Value = false;
                }

                sliderAutoUpdate.Value = frmMain.config.AUTO_UPDATE_NICDATA;

            }).Start();
        }

        private void switchAutoUpdate_ValueChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (Config_Helper.SetValue(Constant.AUTO_UPDATE_NICSTATE, switchAutoUpdate.Value.ToString()))
                {
                    if (switchAutoUpdate.Value)
                    {
                        frmMain.config.AUTO_UPDATE_NICSTATE = switchAutoUpdate.Value;
                        lbAuto.Text = Constant.AutoUpdate_ON;
                        lbAuto.Symbol = Constant.AutoUpdate_ON_Icon;

                        timer.Change(0, frmMain.config.AUTO_UPDATE_NICDATA * 1000);
                    }
                    else
                    {
                        frmMain.config.AUTO_UPDATE_NICSTATE = switchAutoUpdate.Value;
                        lbAuto.Text = Constant.AutoUpdate_OFF;
                        lbAuto.Symbol = Constant.AutoUpdate_OFF_Icon;

                        timer.Change(Timeout.Infinite, Timeout.Infinite);
                    }
                }
                else
                {
                    MessageBoxEx.Show(string.Join(Environment.NewLine, new string[] { "Có lỗi khi lưu tệp tin cấu hình!", "Vui lòng thử lại." }), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }


        private void superGridControl1_GetColumnHeaderStyle(object sender, GridGetColumnHeaderStyleEventArgs e)
        {
            //e.Style.BorderColor = new Style.BorderColor(Color.Red);
            e.Style.Background = new DevComponents.DotNetBar.SuperGrid.Style.Background(Color.LightSteelBlue);
        }

        private void superGridControl1_GetCellValue(object sender, GridGetCellValueEventArgs e)
        {
            if (e.GridCell.GridColumn == gridColumn_STT)
            {
                e.GridCell.Value = e.GridCell.GridRow.Index + 1;
            }
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

        private void sliderAutoUpdate_ValueChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (Config_Helper.SetValue(Constant.AUTO_UPDATE_NICDATA, sliderAutoUpdate.Value.ToString()))
                {
                    sliderAutoUpdate.Text = Constant.Slider_AutoUpdate_Text.Replace("%", sliderAutoUpdate.Value.ToString());
                }
                else
                {
                    MessageBoxEx.Show(string.Join(Environment.NewLine, new string[] { "Có lỗi khi lưu tệp tin cấu hình!", "Vui lòng thử lại." }), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }



    }
}
