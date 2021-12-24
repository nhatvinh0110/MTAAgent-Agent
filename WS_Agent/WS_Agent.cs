using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.AES;
using Common.REGISTRY;
using Common.FILE;
using Common.DATA;
using Common.DotNET;
using Common.WIFI;
using Common;
using Common.CONFIG;
using SimpleWifi;
using System.IO;
using System.Data.SqlClient;
using Common.DTO;


namespace WS_Agent
{
    public partial class WS_Agent : ServiceBase
    {
        public bool checkvideo = false;
        string StudentID;
        WifiStatus statusWifi = WifiStatus.Disconnected;
        public class ComputerStatusLog
        {
            public int ID { get; set; }
            public string ComputerID { set; get; }
            public DateTime Time { set; get; }

        }

        public class NetworkInterfaceInfo
        {
            public string NetInterfaceName { set; get; }
            public string List_IPv4 { set; get; }
            public string MAC { set; get; }
            public string Description { set; get; }
            public DateTime LastUpdate { set; get; }
            public bool Status { set; get; }
            public string ComputerID { set; get; }
            public string State { set; get; }

        }

        public class ComputerInfo
        {
            public string ComputerID { set; get; }
            public string ComputerName { set; get; }
            public string CPUName { set; get; }
            public string RAM { set; get; }
            public string OS { set; get; }
            public string OSReleaseId { set; get; }
            public bool Status { set; get; }
            public string Ping { set; get; }
            public string CreateAt { set; get; }
            public string LastUpdate { set; get; }
            public int RoomTestID { set; get; }
            public string AgentVersion { set; get; }
            public string DotNetVersion { set; get; }
            public string State { set; get; }



        }

        public class EventInfo
        {
            public string EventCategory { get; set; }
            public string ComputerID { get; set; }
            public string Message { get; set; }

        }

        public enum EventType
        {
            Inserted = 2,
            Removed = 3
        }

        public WS_Agent()
        {
            InitializeComponent();
          

            IsFileChange();
            //timer = new System.Timers.Timer();
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Tick);
            //timer.Interval = 60000;

        }
        public void Start()
        {


            OnStart(new string[0]);
        }

        //System.Timers.Timer timer = null;

        //private void timer_Tick(object sender, EventArgs e)
        //{



        //}

        EventInfo eventInfo = new EventInfo() { ComputerID = "", EventCategory = "", Message = "" };

        DataProvider event_dataProvider = new DataProvider();


        protected override void OnStart(string[] args)
        {
            //try
            //{
            //    Log_Contestant logCT = new Log_Contestant();
            //    logCT.IsFileChangeForLog();
            //}
            //catch(Exception io)
            //{
            //    Log_Helper.Error(io.Message,io);
            //}

            try
            {
                CurrentPath = AppDomain.CurrentDomain.BaseDirectory;//thư mục cơ sở ứng dụng


                ComputerInfo computerInfo = new ComputerInfo();


                ComputerID = Registry_Helper.Read_Value(Constant.REG_Agent_Base, Constant.REG_AgentGUID);

                if (string.IsNullOrEmpty(ComputerID))
                {
                    ComputerID = Guid.NewGuid().ToString();

                    Registry_Helper.Write_Value(Constant.REG_Agent_Base, Constant.REG_AgentGUID, ComputerID);

                }

                eventInfo.ComputerID = ComputerID;

                computerInfo.OS = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
                computerInfo.OSReleaseId = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();
                computerInfo.ComputerName = System.Environment.MachineName;
                computerInfo.RAM = Math.Round(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / Convert.ToSingle(1024 * 1024 * 1024), 0).ToString();
                computerInfo.CPUName = GetProcessorName();
                computerInfo.ComputerID = ComputerID;
                computerInfo.State = "Connected";
                computerInfo.Status = true;
                computerInfo.RoomTestID = Convert.ToInt32(Config_Helper.GetValue("RoomID", "0"));
                computerInfo.DotNetVersion = DotNetVersionCheck.GetList_DotNetVersion_Latest();
                computerInfo.AgentVersion = "1.4.0";

                string con = Config_Helper.GetValue("CON", "");

                event_dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);

                //Log_Helper.customDBAppender = new CustomDBAppender(con); push log client len sql server

               
                string namepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoRecords\";

                
                new Thread(() =>
                {

                    DataProvider dataProvider = new DataProvider(con);

                    Thread.CurrentThread.IsBackground = true;

                    ComputerStatusLog computerStatus = new ComputerStatusLog();
                    computerStatus.ComputerID = ComputerID;
                    computerStatus.ID = 0;


                    for (; ; )
                    {
                        try
                        {

                            computerInfo.Ping = Ping(dataProvider.cnn.DataSource.Split(',')[0]);
                            computerInfo.ComputerName = System.Environment.MachineName;
                            computerInfo.RAM = Math.Round(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / Convert.ToSingle(1024 * 1024 * 1024), 0).ToString();

                            string q = $"exec [Insert_or_Update_Computer] '{computerInfo.ComputerID}' , N'{computerInfo.ComputerName}' , N'{computerInfo.CPUName}' , '{computerInfo.RAM}' , N'{computerInfo.OS}' , '{computerInfo.OSReleaseId}' , {computerInfo.Status} , '{computerInfo.Ping}' , {computerInfo.RoomTestID} , N'{computerInfo.AgentVersion}' , N'{computerInfo.DotNetVersion}' , '{computerInfo.State}' ; ";

                            var ListIP = GetLocalIPAddress();
                            foreach (var nic in ListIP)
                            {
                                q = q + $"exec [Insert_or_Update_NetworkInterfaces] N'{nic.NetInterfaceName}'  , '{nic.List_IPv4}' , '{nic.MAC}'  , N'{nic.Description}'  , {nic.Status} , '{nic.ComputerID}' , '{nic.State}'; ";
                            }

                            dataProvider.ExecuteNonQuery(q);

                            computerStatus.Time = DateTime.Now;

                            if (computerStatus.ID == 0)
                            {
                                computerStatus.ID = dataProvider.ExecuteScalar($"exec Create_ComputersStatusLog '{computerStatus.ComputerID}', '{computerStatus.Time}' ");

                                try
                                {
                                    string qe = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.ini");
                                    if (!string.IsNullOrEmpty(qe))
                                    {
                                        dataProvider.ExecuteNonQuery(qe);
                                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\temp.ini", string.Empty, Encoding.Unicode);
                                    }
                                }
                                catch (Exception op)
                                {
                                    Log_Helper.Error("Push Event failed!", op);
                                }
                            }
                            else
                            {
                                dataProvider.ExecuteNonQuery($"exec Update_ComputersStatusLog '{computerStatus.ID}', '{computerStatus.Time}' ");
                            }

                            if (computerInfo.ComputerName != System.Environment.MachineName)
                            {
                                eventInfo.EventCategory = "Computer";
                                eventInfo.Message = "Computer Name is Changed";
                                Log_Helper.Warn(eventInfo.Message);

                                PushEvent(event_dataProvider, eventInfo);

                            }

                        }
                        catch (Exception io)
                        {
                            computerStatus.ID = 0;
                            Log_Helper.Error(io.Message, io);
                        }

                        Thread.Sleep(5000);
                    }

                }).Start();
                string ComputerName = System.Environment.MachineName;

                //luong video
                Thread videofile =  new Thread(() =>
                 {
                     DataProvider dataProvider1 = new DataProvider(con);
                     while (true)
                     {
                         
                             SqlConnection kn = new SqlConnection(con);
                             SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.StatusVideoLog where ComputerID = '" + ComputerID + "'", kn);
                             try
                             {
                                 //Gui video
                                 if (dataProvider1.getdata(cmd) == "1")
                                 {

                                     // SaveVideos();

                                     byte[] bufer = new byte[15000000];
                                     string[] fileArray1 = Directory.GetFiles(namepath);
                                       
                                     int endIndex = fileArray1[0].IndexOf("_");
                                     StudentID = fileArray1[0].Substring(namepath.Length, endIndex - namepath.Length);
                                    if (fileArray1.Length != 0)
                                     {
                                         using (Stream video = File.OpenRead(fileArray1[0]))
                                         {

                                             string Namevideo = ComputerName + fileArray1[0].Substring(namepath.Length - 1, fileArray1[0].Length - 3 - namepath.Length);

                                             video.Read(bufer, 0, bufer.Length);
                                             try
                                             {
                                                 string q3 = $"exec spsql '{StudentID}','{Namevideo}','{bufer}','{ComputerID}'";
                                             cmd = new SqlCommand();
                                             cmd.CommandType = CommandType.StoredProcedure;
                                             cmd.CommandText = "spsql";
                                             cmd.Connection = kn;
                                             kn.Open();
                                             cmd.Parameters.Add("@sbd", SqlDbType.VarChar).Value = StudentID;
                                             cmd.Parameters.Add("@namepath", SqlDbType.NVarChar).Value = Namevideo;
                                             cmd.Parameters.Add("@content", SqlDbType.VarBinary).Value = bufer;
                                             cmd.Parameters.Add("@id_may", SqlDbType.VarChar).Value = ComputerID;
                                             cmd.ExecuteNonQuery();
                                             kn.Close();


                                         }
                                             catch (Exception e)
                                             {

                                                 Log_Helper.Error(e.Message, e);
                                             }
                                         }
                                         System.IO.File.Delete(fileArray1[0]);
                                     }
                                     else
                                     {
                                         string q1 = $"exec spketthuc '{StudentID}', '{ComputerID}'";
                                         dataProvider1.ExecuteNonQuery(q1);
                                     }
                                 }

                             }

                             catch (Exception e)
                             {

                                 Log_Helper.Error(e.Message, e);
                             }

                         
                         Thread.Sleep(5000);
                     }
                });
                videofile.IsBackground = true;
                videofile.Start();

                //thread gui log USB

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    Wifi wifi = new Wifi();

                    DataTable dt_Setting = new DataTable();


                    try
                    {
                        // lấy danh sách usb được cắm trước khi agent khởi động (VD như cắm lúc máy đang tắt)
                        foreach (DriveInfo drive in DriveInfo.GetDrives())
                        {
                            if (drive.DriveType == DriveType.Removable)
                            {
                                eventInfo.EventCategory = "USB";
                                eventInfo.Message = string.Format("USB is Connected ({0}) {1}", drive.Name.Replace("\\", ""), drive.VolumeLabel);
                                Log_Helper.Warn(eventInfo.Message);

                                PushEvent(event_dataProvider, eventInfo);

                            }
                        }

                        // theo dõi quá trình hoạt động có usb được cắm vào hay không
                        ManagementEventWatcher watcher = new ManagementEventWatcher();
                        WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2 or EventType = 3");

                        watcher.EventArrived += (s, e) =>
                        {
                            string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
                            EventType eventType = (EventType)(Convert.ToInt16(e.NewEvent.Properties["EventType"].Value));

                            string eventName = Enum.GetName(typeof(EventType), eventType);

                            eventInfo.EventCategory = "USB";
                            eventInfo.Message = string.Format("USB is {0} ({1})", eventName, driveName);
                            Log_Helper.Warn(eventInfo.Message);

                            PushEvent(event_dataProvider, eventInfo);
                        };

                        watcher.Query = query;
                        watcher.Start();


                      /*  wifi.ConnectionStatusChanged += (s, e) =>
                        {

                            eventInfo.EventCategory = "Wifi";
                            eventInfo.Message = string.Format("Wifi is {0}", e.NewStatus.ToString());
                            Log_Helper.Warn(eventInfo.Message);

                            PushEvent(event_dataProvider, eventInfo);
                        };*/
                    }
                    catch (Exception io)
                    {
                        Log_Helper.Error(io.Message, io);
                    }


                }).Start();

                //Luong Wifi
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    Wifi wifi = new Wifi();

                    DataTable dt_Setting = new DataTable();

                    while (true)
                    {
                        try
                        {
                            if (wifi.ConnectionStatus == WifiStatus.Connected)
                            {
                                if (wifi.ConnectionStatus != statusWifi)
                                {
                                    eventInfo.EventCategory = "Wifi";
                                    eventInfo.Message = "Wifi is Connected";
                                    Log_Helper.Warn(eventInfo.Message);

                                    PushEvent(event_dataProvider, eventInfo);
                                }
                                statusWifi = WifiStatus.Connected;
                            }
                            if (wifi.ConnectionStatus == WifiStatus.Disconnected)
                            {
                                if (wifi.ConnectionStatus != statusWifi)
                                {
                                    eventInfo.EventCategory = "Wifi";
                                    eventInfo.Message = "Wifi is Disconnected";
                                    Log_Helper.Warn(eventInfo.Message);

                                    PushEvent(event_dataProvider, eventInfo);
                                }
                                statusWifi = WifiStatus.Disconnected;
                            }
                        }
                        catch (Exception e)
                        {
                            Log_Helper.Error(e.Message, e);
                        }
                        Thread.Sleep(5000);
                    }


                }).Start();
                Log_Helper.Info("Service is running!");

                


            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }


        }

        public async Task<bool> PushEventAsync(DataProvider dataProvider, EventInfo eventInfo)
        {
            try
            {
                await dataProvider.ExecuteNonQueryAsync($"exec [PushEvent] '{eventInfo.ComputerID}', N'{eventInfo.Message}', N'{eventInfo.EventCategory}';");
                return true;
            }
            catch (Exception io)
            {
                File_Helper.write(AppDomain.CurrentDomain.BaseDirectory + @"\temp.ini", $"exec [PushEvent_Time] '{eventInfo.ComputerID}', '{DateTime.Now.ToString()}', N'{eventInfo.Message}', N'{eventInfo.EventCategory}'; ", true);
                Log_Helper.Error(io.Message, io);
                return false;
            }
        }

        public bool PushEvent(DataProvider dataProvider, EventInfo eventInfo)
        {
            try
            {
                dataProvider.ExecuteNonQuery($"exec [PushEvent] '{eventInfo.ComputerID}', N'{eventInfo.Message}', N'{eventInfo.EventCategory}';");
                return true;
            }
            catch (Exception io)
            {
                File_Helper.write(AppDomain.CurrentDomain.BaseDirectory + @"\temp.ini", $"exec [PushEvent_Time] '{eventInfo.ComputerID}', '{DateTime.Now.ToString()}', N'{eventInfo.Message}', N'{eventInfo.EventCategory}'; ", true);
                Log_Helper.Error(io.Message, io);
                return false;
            }
        }


        string CurrentPath = "";
        Dictionary<string, List<string>> Dic_IP = new Dictionary<string, List<string>>();
        string ComputerID = "";

        public string GetServiceTag_Hash()
        {

            string serialNumber = string.Empty;

            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString();
            }

            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.Default.GetBytes(serialNumber));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public string GetServiceTag_GUID()
        {
            string serialNumber = string.Empty;

            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString();
            }

            string output = "";
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(serialNumber));
                output = new Guid(hash).ToString();
            }
            return output;
        }

        public string GetWindowsGUID()
        {
            try
            {
                string x64Result = string.Empty;
                string x86Result = string.Empty;
                RegistryKey keyBaseX64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                RegistryKey keyBaseX86 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                RegistryKey keyX64 = keyBaseX64.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", RegistryKeyPermissionCheck.ReadSubTree);
                RegistryKey keyX86 = keyBaseX86.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", RegistryKeyPermissionCheck.ReadSubTree);
                object resultObjX64 = keyX64.GetValue("MachineGuid", (object)"");
                object resultObjX86 = keyX86.GetValue("MachineGuid", (object)"");

                if (resultObjX64 != null && resultObjX64.ToString() != "")
                {
                    return (resultObjX64.ToString());
                }
                if (resultObjX86 != null && resultObjX86.ToString() != "")
                {
                    return (resultObjX86.ToString());
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public List<NetworkInterfaceInfo> GetLocalIPAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            var query = nics.Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                        .Select(_ => new NetworkInterfaceInfo
                        {
                            NetInterfaceName = _.Name,
                            MAC = string.Join(Constant.char_Join, _.GetPhysicalAddress().GetAddressBytes().Select(b => b.ToString("X2"))),
                            List_IPv4 = string.Join("-", _.GetIPProperties().UnicastAddresses.Where(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork).Select(ip => ip.Address.ToString()).ToList()),
                            Description = _.Description,
                            ComputerID = ComputerID,
                            State = _.OperationalStatus.ToString(),
                            Status = true
                        }).Where(x => !x.Description.ToLower().Contains("vmware") && !x.Description.ToLower().Contains("virtual") && !x.Description.ToLower().Contains("loopback")).ToList();


            //foreach (var mac in query)
            //{
            //    //List<string> listIP = mac.IPProperties.UnicastAddresses.Select(ip => ip.Address.ToString()).ToList();
            //    Dic_IP.Add(string.Join("-", mac.PhysicalAddress.GetAddressBytes().Select(b => b.ToString("X2"))), mac.IPProperties.UnicastAddresses.Where(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork).Select(ip => ip.Address.ToString()).ToList());
            //}

            return query;
        }

        public string GetProcessorName()
        {
            var cpu = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();

            string CPU_Name = (string)cpu["Name"];

            CPU_Name =
               CPU_Name
               .Replace("(TM)", "™")
               .Replace("(tm)", "™")
               .Replace("(R)", "®")
               .Replace("(r)", "®")
               .Replace("(C)", "©")
               .Replace("(c)", "©")
               .Replace("    ", " ")
               .Replace("  ", " ");

            return CPU_Name;
        }

        public string Ping(string ip)
        {
            string lblResult = "";

            try
            {
                Ping p = new Ping();
                PingReply r;
                r = p.Send(ip);

                if (r.Status == IPStatus.Success)
                {
                    //lblResult = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                    //   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    lblResult = r.RoundtripTime.ToString() + " ms";
                }
                else
                {
                    lblResult = Constant.NotAvailable;
                }

            }
            catch
            {
                lblResult = Constant.NotAvailable;
            }

            return lblResult;
        }

        void Block_RemoteDesktop(bool isBlock)
        {
            try
            {
                if (isBlock == true)
                {
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", 1);
                }
                else if (isBlock == false)
                {
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", 0);
                }
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }

        void Block_Wifi()
        {
            try
            {
                Wifi_Helper.Disconnect();
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }


        protected override void OnStop()
        {
        }

        public void IsFileChange()
        {

            FileSystemWatcher myWatcher = new FileSystemWatcher();
            myWatcher.Path = "C:/ProgramData/EXON/"; //Đường dẫn cần theo dõi
            myWatcher.Filter = "*.txt"; //Bộ lọc loại tập tin
            myWatcher.EnableRaisingEvents = true; // Cho phép sử dụng các sự kiện khi có thay đổi
            myWatcher.IncludeSubdirectories = true; //Bao gồm thư mục con
            //Bộ lọc đối với sự kiện Changed
            myWatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            //Xử lý các sự kiện                                                            
            myWatcher.Created += new FileSystemEventHandler(myWatcher_Created);
            myWatcher.Changed += new FileSystemEventHandler(myWatcher_Changed);



        }
        public void myWatcher_Created(object sender, FileSystemEventArgs e)
        {
            int startIndex = e.FullPath.IndexOf(@"\");
            int endIndex = e.FullPath.IndexOf("_");
            StudentID = e.FullPath.Substring(startIndex + 1, endIndex - startIndex - 1);
            string cnn = Config_Helper.GetValue("CON", "");
            DataProvider dataProvider = new DataProvider(cnn);
            string q1 = $"exec spthietlap '{StudentID}', '{ComputerID}'";
            dataProvider.ExecuteNonQuery(q1);
            
       
        }
        public void myWatcher_Changed(object sender, FileSystemEventArgs e)
        {
                int startIndexLog = e.FullPath.IndexOf(@"\");
                int lastIndexLog = e.FullPath.IndexOf(".txt");

                string nameLog = e.FullPath.Substring(startIndexLog);
                string namepathLog = e.FullPath.Substring(0, startIndexLog - 1) + e.FullPath.Substring(startIndexLog, lastIndexLog - startIndexLog) + ".txt";
                    FileAttributes attributes = File.GetAttributes(namepathLog);
                    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        
                        string[] Content = ReadTextFile.Read_AllFile(nameLog).Split('\n');
                        string LastString = Content[Content.Length - 2];
                        if (LastString.Contains("mbtnSubmit_Click") && LastString.Contains("START FUNCTION"))
                        {
                            Log_Contestant logCT = new Log_Contestant();
                            string[] File_Log = e.FullPath.Split(@"/".ToCharArray());
                            logCT.PushLog(File_Log[File_Log.Length - 1].Substring(1));
                            //break;
                        }
                    }
                   
        }
    }
}
