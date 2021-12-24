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

namespace ManagementCenter
{
    public partial class frmNetwork : Form
    {
        public frmNetwork()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Tick);
            timer.Interval = 5000;
        }

        DataProvider timer_dataProvider = new DataProvider(frmMain.con);

        System.Timers.Timer timer = null;

        Dictionary<string, pnInterfaceItem> Dic_pnInterface = new Dictionary<string, pnInterfaceItem>();

        List<pnInterfaceItem> ls_pnInterface = new List<pnInterfaceItem>();

        bool isSearch = false;

        bool ScrollActived = false;

        private void frmNetwork_Load(object sender, EventArgs e)
        {
            //new Thread(() =>
            //{
            //    Thread.CurrentThread.IsBackground = true;

            //    Invoke((MethodInvoker)delegate
            //    {
            //        circularProgress1.Show();
            //        circularProgress1.Value += 2;
            //        circularProgress1.IsRunning = !circularProgress1.IsRunning;
            //        circularProgress1.Refresh();
            //    });

            //    try
            //    {
            //        //DataTable dt_Rooms = DAL_NetworkInterface.get_InterfaceAsList_Include_ComputerName();

            //        //DataRow dr = dt_Rooms.NewRow();
            //        //dr[Constant.RoomName] = Constant.All_vi;
            //        //dr[Constant.RoomID] = 0;
            //        //dt_Rooms.Rows.InsertAt(dr, 0);
            //        //Invoke((MethodInvoker)delegate
            //        //{
            //        //    //cbRooms.DataSource = dt_Rooms;
            //        //    cbIP.DisplayMember = Constant.List_IPv4;
            //        //    cbIP.ValueMember = Constant.RoomID;

            //        //    //DataTable dt_Computers = DAL_Computer.get_Computers_Active();
            //        //    //cbComputerName.DataSource = dt_Computers;
            //        //    cbMAC.DisplayMember = Constant.ComputerName;
            //        //    cbMAC.ValueMember = Constant.ComputerID;

            //        //});

            //        //DataTable dt_Setting = DAL_Setting.get_Setting();

            //        //for (int i = 0; i < dt_Setting.Rows.Count; i++)
            //        //{
            //        //    string key = dt_Setting.Rows[i][Constant.SettingKey].ToString();
            //        //    string value = dt_Setting.Rows[i][Constant.SettingValue].ToString();

            //        //    switch (key)
            //        //    {
            //        //        case Constant.isDisableRemoteDesktop:

            //        //            Invoke((MethodInvoker)delegate
            //        //            {
            //        //                if (Convert.ToBoolean(value) == true)
            //        //                {
            //        //                    btnBlockRemote.Checked = true;
            //        //                }
            //        //                else
            //        //                {
            //        //                    btnBlockRemote.Checked = false;
            //        //                }
            //        //            });

            //        //            break;
            //        //        case Constant.isDisableWifi:

            //        //            Invoke((MethodInvoker)delegate
            //        //            {
            //        //                if (Convert.ToBoolean(value) == true)
            //        //                {
            //        //                    btnBlockWifi.Checked = true;
            //        //                }
            //        //                else
            //        //                {
            //        //                    btnBlockWifi.Checked = false;
            //        //                }
            //        //            });

            //        //            break;
            //        //    }
            //        //}


            //        Thread.Sleep(2000);

            //        timer_Tick(null, null);

            //        timer.Start();

            //    }
            //    catch (Exception io)
            //    {
            //        Invoke((MethodInvoker)delegate
            //        {
            //            frmError frmError = new frmError(io.Message);
            //            frmError.TopLevel = false;
            //            frmError.Dock = DockStyle.Fill;
            //            this.Controls.Add(frmError);
            //            frmError.Show();
            //            frmError.BringToFront();
            //        });
            //    }
            //    finally
            //    {
            //        Invoke((MethodInvoker)delegate
            //        {
            //            circularProgress1.Hide();
            //        });
            //    }
            //}).Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            List<NetInterface> ls_Interfaces = DAL_NetworkInterface.get_InterfaceAsList_Include_ComputerName(timer_dataProvider).OrderByDescending(x => x.ComputerName).ToList();

            Dictionary<string, NetInterface> Dic_Computer = new Dictionary<string, NetInterface>();

            for (int i = 0; i < ls_Interfaces.Count; i++)
            {
                Dic_Computer.Add(ls_Interfaces[i].MAC, ls_Interfaces[i]);
            }



            if (Dic_pnInterface.Count > Dic_Computer.Count)     // xóa bớt những pn thừa
            {
                foreach (var k in Dic_pnInterface.Keys.ToArray())
                {
                    if (!Dic_Computer.ContainsKey(k))
                    {
                        Dic_pnInterface[k].Invoke(new Action(() => Dic_pnInterface[k].Hide()));
                        Dic_pnInterface[k].Invoke(new Action(() => Dic_pnInterface[k].Dispose()));
                        pnItems.Controls.Remove(Dic_pnInterface[k]);
                        ls_pnInterface.Remove(Dic_pnInterface[k]);
                        Dic_pnInterface.Remove(k);

                    }
                }
            }
            else if (Dic_pnInterface.Count < Dic_Computer.Count)        // thêm pn cho bằng số lượng computer
            {

                for (int i = 0; i < ls_Interfaces.Count; i++)
                {
                    if (!Dic_pnInterface.ContainsKey(ls_Interfaces[i].MAC))
                    {
                        pnItems.Invoke(new Action(() => pnItems.SuspendLayout()));

                        pnInterfaceItem pnInterfaceItem = new pnInterfaceItem();

                        pnInterfaceItem.Dock = DockStyle.Top;

                        Dic_pnInterface.Add(ls_Interfaces[i].MAC, pnInterfaceItem);

                        ls_pnInterface.Add(pnInterfaceItem);

                        pnItems.Invoke(new Action(() => pnItems.Controls.Add(pnInterfaceItem)));

                        pnItems.Invoke(new Action(() => pnItems.ResumeLayout()));
                    }
                }

            }

            int CountUp = 0;
            int CountDown = 0;
            int CountOffline = 0;


            for (int i = 0; i < ls_pnInterface.Count; i++)
            {

                Invoke((MethodInvoker)delegate
                {
                    if (ls_Interfaces[i].SecondsDiff > 8)
                    {
                        ls_pnInterface[i].lbState.Image = Properties.Resources.offline;
                        ls_pnInterface[i].lbState.Text = Constant.Offline;


                        CountOffline++;

                        if (!isSearch)
                        {
                            if (rbUp.Checked || rbDown.Checked)        // nếu đang lọc các card off, bỗng nhiên có máy trong số đấy down hoặc up thì ẩn đi
                            {
                                ls_pnInterface[i].Hide();
                            }
                            else
                            {
                                ls_pnInterface[i].Show();
                            }
                        }

                    }
                    else if(ls_Interfaces[i].SecondsDiff <= 8 && ls_Interfaces[i].State.ToLower() == Constant.Up.ToLower())
                    {
                        ls_pnInterface[i].lbState.Image = Properties.Resources.online;
                        ls_pnInterface[i].lbState.Text = Constant.Up;
                        //ls_pnInterface[i].lbPing.Text = ls_Interfaces[i].Ping;

                        CountUp++;

                        if (!isSearch)
                        {
                            if (rbDown.Checked || rbOffline.Checked)      // nếu đang lọc các card Up, bỗng nhiên có máy trong số đấy down hoặc offline thì ẩn đi
                            {
                                ls_pnInterface[i].Hide();
                            }
                            else
                            {
                                ls_pnInterface[i].Show();
                            }
                        }

                    }
                    else
                    {
                        ls_pnInterface[i].lbState.Image = Properties.Resources.warning_1;
                        ls_pnInterface[i].lbState.Text = Constant.Down;
                        //ls_pnInterface[i].lbPing.Text = ls_Interfaces[i].Ping;

                        CountDown++;

                        if (!isSearch)
                        {
                            if (rbUp.Checked || rbOffline.Checked)      // nếu đang lọc các card Down, bỗng nhiên có máy trong số đấy up hoặc off thì ẩn đi
                            {
                                ls_pnInterface[i].Hide();
                            }
                            else
                            {
                                ls_pnInterface[i].Show();
                            }
                        }
                    }

                    ls_pnInterface[i].lbSTT.Text = (ls_pnInterface.Count - i).ToString();

                    ls_pnInterface[i].lbLastUpdate.Text = ls_Interfaces[i].LastUpdate.ToString("HH:mm:ss - dd/MM/yyyy");
                    ls_pnInterface[i].lbIP.Text = ls_Interfaces[i].List_IPv4;
                    ls_pnInterface[i].lbComputerName.Text = ls_Interfaces[i].ComputerName;
                    ls_pnInterface[i].lbInterfaceName.Text = ls_Interfaces[i].NetInterfaceName;
                    ls_pnInterface[i].lbMAC.Text = ls_Interfaces[i].MAC;
                    ls_pnInterface[i].lbDesc.Text = ls_Interfaces[i].Description;


                    ls_pnInterface[i].tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                    //ls_pnInterface[i].computer = ls_Interfaces[i];
                    //ls_pnInterface[i].ComputerID = ls_Interfaces[i].ComputerID;

                    ls_pnInterface[i].SetColor(ls_pnInterface.Count - i);
                });
            }

            Invoke((MethodInvoker)delegate
            {
                lball.Text = ls_Interfaces.Count.ToString();
                lbOffline.Text = CountOffline.ToString();
                lbUp.Text = CountUp.ToString();
                lbDown.Text = CountDown.ToString();


                string temp = cbMAC.Text;
                cbMAC.DataSource = ls_Interfaces.OrderBy(x => x.MAC).ToList();
                cbMAC.DisplayMember = Constant.MAC;
                cbMAC.Text = temp;
                cbMAC.SelectionStart = cbMAC.Text.Length;

                string temp1 = cbIP.Text;
                List<string> listIP = new List<string>();

                foreach(var i in ls_Interfaces.Select(t => t.List_IPv4).ToList().OrderBy(x => x).ToList())
                {
                    listIP.AddRange(i.Split(new string[] { Constant.char_Join }, StringSplitOptions.None));
                }

                cbIP.DataSource = listIP;
                cbIP.Text = temp1;
                cbIP.SelectionStart = cbIP.Text.Length;

            });
        }


        void filter(string state)
        {
            pnItems.Hide();
            for (int i = 0; i < ls_pnInterface.Count; i++)
            {
                if (state == Constant.All)
                {
                    ls_pnInterface[i].Show();
                }
                else if (state == Constant.Up)
                {
                    if (ls_pnInterface[i].lbState.Text == Constant.Up)
                    {
                        ls_pnInterface[i].Show();
                    }
                    else
                    {
                        ls_pnInterface[i].Hide();
                    }
                }
                else if (state == Constant.Offline)
                {
                    if (ls_pnInterface[i].lbState.Text == Constant.Offline)
                    {
                        ls_pnInterface[i].Show();
                    }
                    else
                    {
                        ls_pnInterface[i].Hide();
                    }
                }
                else
                {
                    if (ls_pnInterface[i].lbState.Text == Constant.Down)
                    {
                        ls_pnInterface[i].Show();
                    }
                    else
                    {
                        ls_pnInterface[i].Hide();
                    }
                }
            }
            pnItems.Show();
        }

        private void rb_filter_Click(object sender, EventArgs e)
        {
            isSearch = false;
            RadioButton rb = sender as RadioButton;
            if (rb.Name == rbAll.Name)
            {
                filter(Constant.All);
            }
            else if (rb.Name == rbUp.Name)
            {
                filter(Constant.Up);
            }
            else if(rb.Name == rbDown.Name)
            {
                filter(Constant.Down);
            }
            else
            {
                filter(Constant.Offline);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //rbAll.Checked = false;

            isSearch = true;

            if (cbIP.Text == Constant.All_vi && string.IsNullOrEmpty(cbMAC.Text))
            {
                // all room - all computer
                Search();
            }
            else if (cbIP.Text != Constant.All_vi && !string.IsNullOrEmpty(cbMAC.Text))
            {
                // search room - search computer
                Search(cbMAC.Text, cbIP.Text);
            }
            else if (cbIP.Text == Constant.All_vi && !string.IsNullOrEmpty(cbMAC.Text))
            {
                // all room - search computer
                Search(cbMAC.Text);
            }
            else
            {
                // search room - all computer
                Search(cbMAC.Text + cbIP.Text);
            }


        }

        void Search()
        {
            for (int i = 0; i < ls_pnInterface.Count; i++)
            {
                ls_pnInterface[i].Show();
            }
        }

        void Search(string MAC_Or_IP)
        {
            for (int i = 0; i < ls_pnInterface.Count; i++)
            {
                if (ls_pnInterface[i].lbIP.Text.Contains(MAC_Or_IP) || ls_pnInterface[i].lbMAC.Text.Contains(MAC_Or_IP))
                {
                    ls_pnInterface[i].Show();
                }
                else
                {
                    ls_pnInterface[i].Hide();
                }
            }
        }

        void Search(string MAC, string IP)
        {
            for (int i = 0; i < ls_pnInterface.Count; i++)
            {
                if (ls_pnInterface[i].lbIP.Text.Contains(IP) && ls_pnInterface[i].lbMAC.Text.Contains(MAC))
                {
                    ls_pnInterface[i].Show();
                }
                else
                {
                    ls_pnInterface[i].Hide();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isSearch = false;
            rb_filter_Click(rbAll, null);
        }

        private void pnItems_ClientSizeChanged(object sender, EventArgs e)
        {
            if (pnItems.VerticalScroll.Visible && ScrollActived == false)
            {
                ScrollActived = true;
                tableLayoutPanel1.ColumnStyles[7].Width = tableLayoutPanel1.ColumnStyles[7].Width + SystemInformation.VerticalScrollBarWidth;
            }
            else if (pnItems.VerticalScroll.Visible == false && ScrollActived == true)
            {
                ScrollActived = false;
                tableLayoutPanel1.ColumnStyles[7].Width = tableLayoutPanel1.ColumnStyles[7].Width - SystemInformation.VerticalScrollBarWidth;
            }
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

                try
                {
                    //DataTable dt_Rooms = DAL_NetworkInterface.get_InterfaceAsList_Include_ComputerName();

                    //DataRow dr = dt_Rooms.NewRow();
                    //dr[Constant.RoomName] = Constant.All_vi;
                    //dr[Constant.RoomID] = 0;
                    //dt_Rooms.Rows.InsertAt(dr, 0);
                    //Invoke((MethodInvoker)delegate
                    //{
                    //    //cbRooms.DataSource = dt_Rooms;
                    //    cbIP.DisplayMember = Constant.List_IPv4;
                    //    cbIP.ValueMember = Constant.RoomID;

                    //    //DataTable dt_Computers = DAL_Computer.get_Computers_Active();
                    //    //cbComputerName.DataSource = dt_Computers;
                    //    cbMAC.DisplayMember = Constant.ComputerName;
                    //    cbMAC.ValueMember = Constant.ComputerID;

                    //});

                    //DataTable dt_Setting = DAL_Setting.get_Setting();

                    //for (int i = 0; i < dt_Setting.Rows.Count; i++)
                    //{
                    //    string key = dt_Setting.Rows[i][Constant.SettingKey].ToString();
                    //    string value = dt_Setting.Rows[i][Constant.SettingValue].ToString();

                    //    switch (key)
                    //    {
                    //        case Constant.isDisableRemoteDesktop:

                    //            Invoke((MethodInvoker)delegate
                    //            {
                    //                if (Convert.ToBoolean(value) == true)
                    //                {
                    //                    btnBlockRemote.Checked = true;
                    //                }
                    //                else
                    //                {
                    //                    btnBlockRemote.Checked = false;
                    //                }
                    //            });

                    //            break;
                    //        case Constant.isDisableWifi:

                    //            Invoke((MethodInvoker)delegate
                    //            {
                    //                if (Convert.ToBoolean(value) == true)
                    //                {
                    //                    btnBlockWifi.Checked = true;
                    //                }
                    //                else
                    //                {
                    //                    btnBlockWifi.Checked = false;
                    //                }
                    //            });

                    //            break;
                    //    }
                    //}


                    Thread.Sleep(2000);

                    timer_Tick(null, null);

                    timer.Start();

                }
                catch (Exception io)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        frmError frmError = new frmError(io.Message);
                        frmError.TopLevel = false;
                        frmError.Dock = DockStyle.Fill;
                        this.Controls.Add(frmError);
                        frmError.Show();
                        frmError.BringToFront();
                    });
                }
                finally
                {
                    Invoke((MethodInvoker)delegate
                    {
                        circularProgress1.Hide();
                        pnItems.Show();
                    });
                }
            }).Start();

        }
    }
}
