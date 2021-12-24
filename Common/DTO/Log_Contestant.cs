using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using static System.Resources.ResXFileRef;
using System.Globalization;
using Common;
using Common.REGISTRY;
using Common.DATA;
using Common.CONFIG;

namespace Common.DTO
{
    public class Log_Contestant
    {
        public string ID_Log { get; set; }
        public string Log_Content { set; get; }
        public string contestant { set; get; }
        public string ComputerID { set; get; }

        /*public static string Log_Path;*/
        public bool Set_ComputerID()
        {
            ComputerID = Registry_Helper.Read_Value(Constant.REG_Agent_Base, Constant.REG_AgentGUID);
            if (string.IsNullOrEmpty(ComputerID))
            {
                ComputerID = Guid.NewGuid().ToString();
                Registry_Helper.Write_Value(Constant.REG_Agent_Base, Constant.REG_AgentGUID, ComputerID);
                return false;
            }
            return true;
        }
        
        public bool set_Log_content(string FolderName)
        {
            Log_Content = ReadTextFile.Read_AllFile(FolderName);
            if (Log_Content != null)
            {
                return true;
            }
            else return false;
        }
       
        public bool set_All(string FolderName)
        {
            if (Set_ComputerID())
            {
                if (set_Log_content(FolderName))
                {
                    contestant = Contestant.GetJson(FolderName);
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public void PushLogContestant(DataProvider dataProvider, Log_Contestant LogInfo)
        {
            try
            {
                dataProvider.ExecuteNonQuery($"exec [PushLogContestant] N'{LogInfo.contestant}', N'{LogInfo.Log_Content}', N'{LogInfo.ComputerID}';");
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }
        public void UpdateLogContestant(DataProvider dataProvider, Log_Contestant LogInfo, string contestant)
        {
            string[] cs = contestant.Split("_".ToCharArray());
            cs[5] = cs[5].Remove(cs[5].Length - 4, 4);
            Contestant cs2 = new Contestant();
            cs2.ContestantCode = "$.ContestantCode"; cs2.ContestantName = "$.ContestantName"; cs2.ContestSubject = "$.ContestSubject"; cs2.Date = "$.Date"; cs2.TimeShift = "$.TimeShift"; cs2.RoomTest = "$.RoomTest";
            try
            {
                dataProvider.ExecuteNonQuery("update Constestant_Log set ContenLog = N'" + LogInfo.Log_Content + "' where JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantCode + "') = '" + cs[0] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantName + "') = N'" + cs[1] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.Date + "') = '" + cs[2] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.TimeShift + "') = '" + cs[3] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestSubject + "') = N'" + cs[4] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.RoomTest + "') = '" + cs[5] + "' and ComputerID = '" + LogInfo.ComputerID + "'");
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }
        }
        public void PushInfo_Contestant(DataProvider dataProvider, Contestant cs, string ID_Log,string ID_Computer)
        {
            try
            {
                dataProvider.ExecuteNonQuery($"exec [PushInfo_Contestant] N'{cs.ContestantCode}', N'{cs.ContestantName}', '{cs.Date}','{cs.TimeShift}',N'{cs.ContestSubject}','{cs.RoomTest}','{ID_Computer}','{ID_Log}';");
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);

            }
        }
        public static bool CheckConTestant(DataProvider dataprovider, string contestant, string computerID)
        {
            string[] cs = contestant.Split("_".ToCharArray());
            /*MessageBox.Show(contestant);*/
            cs[5] = cs[5].Remove(cs[5].Length - 4, 4);
            Contestant cs2 = new Contestant();
            cs2.ContestantCode = "$.ContestantCode"; cs2.ContestantName = "$.ContestantName"; cs2.ContestSubject = "$.ContestSubject"; cs2.Date = "$.Date"; cs2.TimeShift = "$.TimeShift"; cs2.RoomTest = "$.RoomTest";
            string query = "Select * from Constestant_Log WHERE JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantCode + "') = '" + cs[0] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantName + "') = N'" + cs[1] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.Date + "') = '" + cs[2] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.TimeShift + "') = '" + cs[3] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestSubject + "') = N'" + cs[4] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.RoomTest + "') = '" + cs[5] + "' and ComputerID = '" + computerID + "'";
            return dataprovider.getDatatable(query).Rows.Count == 0;
        }
        public static string GetID_Log(DataProvider dataprovider, string contestant, string computerID)
        {
            string[] cs = contestant.Split("_".ToCharArray());
            cs[5] = cs[5].Remove(cs[5].Length - 4, 4);
            Contestant cs2 = new Contestant();
            cs2.ContestantCode = "$.ContestantCode"; cs2.ContestantName = "$.ContestantName"; cs2.ContestSubject = "$.ContestSubject"; cs2.Date = "$.Date"; cs2.TimeShift = "$.TimeShift"; cs2.RoomTest = "$.RoomTest";
            string query = "Select * from Constestant_Log WHERE JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantCode + "') = '" + cs[0] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestantName + "') = N'" + cs[1] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.Date + "')= '" + cs[2] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.TimeShift + "') = '" + cs[3] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.ContestSubject + "') = N'" + cs[4] + "' and JSON_VALUE(CAST(Constestant_Log.Contestant AS nvarchar(MAX)), '" + cs2.RoomTest + "') = '" + cs[5] + "' and ComputerID = '" + computerID + "'";
            return dataprovider.getDatatable(query).Rows[0][0].ToString();
        }
        public static DataTable GetConTestant(DataProvider dataprovider)
        {
            return dataprovider.getDatatable("select * from Constestant_Log ");
        }
        //public void IsFileChangeForLog()
        //{

        //    FileSystemWatcher myWatcher = new FileSystemWatcher();
        //    myWatcher.Path = "C:/ProgramData/EXON/"; //Đường dẫn cần theo dõi
        //    myWatcher.Filter = "*.txt"; //Bộ lọc loại tập tin
        //    myWatcher.EnableRaisingEvents = true; // Cho phép sử dụng các sự kiện khi có thay đổi
        //    myWatcher.IncludeSubdirectories = true; //Bao gồm thư mục con
        //    //Bộ lọc đối với sự kiện Changed
        //    myWatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName;
        //    //Xử lý các sự kiện                                                            
        //    myWatcher.Created += new FileSystemEventHandler(myWatcher_CreatedForLog);
        //    myWatcher.Changed += new FileSystemEventHandler(myWatcher_ChangedForLog);

        //}

        //public void myWatcher_CreatedForLog(object sender, FileSystemEventArgs e)
        //{
        //    int startIndex = e.FullPath.IndexOf(@"/");
        //    int lastIndex = e.FullPath.IndexOf(".txt");

        //    FileAttributes attributes = File.GetAttributes(e.FullPath);
        //    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        //    {
        //        string[] File_Log = e.FullPath.Split(@"/".ToCharArray());
        //        PushLog(File_Log[File_Log.Length - 1].Substring(1));
        //    }

        //}

        //public void myWatcher_ChangedForLog(object sender, FileSystemEventArgs e)
        //{
        //    int startIndex = e.FullPath.IndexOf(@"/");
        //    int lastIndex = e.FullPath.IndexOf(".txt");

        //    FileAttributes attributes = File.GetAttributes(e.FullPath);
        //    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        //    {
        //        string[] File_Log = e.FullPath.Split(@"/".ToCharArray());
        //        PushLog(File_Log[File_Log.Length - 1].Substring(1));
        //    }

        //}
        public void PushLog(string FileName)
        {
            string con = Config_Helper.GetValue("CON", "");
            DataProvider dataProvider = new DataProvider();
            dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);
            Log_Contestant log_Contestant = new Log_Contestant();
            try
            {
                log_Contestant.set_All(FileName);
            }
            catch (Exception io)
            {
                Log_Helper.Error(io.Message, io);
            }

            if (Log_Contestant.CheckConTestant(dataProvider, FileName, log_Contestant.ComputerID))
            {
                try
                {
                    log_Contestant.PushLogContestant(dataProvider, log_Contestant);
                    Contestant cs = new Contestant(FileName);
                    log_Contestant.PushInfo_Contestant(dataProvider, cs, Log_Contestant.GetID_Log(dataProvider, FileName, log_Contestant.ComputerID), log_Contestant.ComputerID);
                }
                catch (Exception io)
                {
                    Log_Helper.Error(io.Message, io);
                }
            }
            else
            {
                try
                {
                    log_Contestant.UpdateLogContestant(dataProvider, log_Contestant, FileName);
                }
                catch (Exception io)
                {
                    Log_Helper.Error(io.Message, io);
                }
            }

        }
        //public void PushLog(string FileName)
        //{
        //    string con = Config_Helper.GetValue("CON", "");
        //    DataProvider dataProvider = new DataProvider();
        //    dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);
        //    Log_Contestant log_Contestant = new Log_Contestant();
        //    try
        //    {
        //        log_Contestant.set_All(FileName);
        //    }
        //    catch (Exception io)
        //    {
        //        Log_Helper.Error(io.Message, io);
        //    }

        //    log_Contestant.PushLogContestant(dataProvider, log_Contestant);
        //    Contestant cs = new Contestant(FileName);
        //    log_Contestant.PushInfo_Contestant(dataProvider, cs, Log_Contestant.GetID_Log(dataProvider, FileName, log_Contestant.ComputerID), log_Contestant.ComputerID);

        //}

    }
    public class Contestant
    {
        public string ContestantCode { get; set; }

        public string ContestantName { get; set; }

        public string Date { get; set; }

        public string TimeShift { get; set; }
        public string ContestSubject { get; set; }

        public string RoomTest { get; set; }
        public Contestant() { }
        public Contestant(string Contestant)
        {
            string[] js = Contestant.Split("_".ToCharArray());
            js[5] = js[5].Remove(js[5].Length - 4, 4);
            ContestantCode = js[0].ToString();
            ContestantName = @js[1].ToString();
            Date = @js[2].ToString();
            TimeShift = @js[3].ToString();
            ContestSubject = @js[4].ToString();
            RoomTest = @js[5].ToString();
        }
        public static string GetJson(string Contestant)
        {
            string[] js = Contestant.Split("_".ToCharArray());
            js[5] = js[5].Remove(js[5].Length - 4, 4);
            var cs = new Contestant
            {
                ContestantCode = @js[0].ToString(),
                ContestantName = @js[1].ToString(),
                Date = @js[2].ToString(),
                TimeShift = @js[3].ToString(),
                ContestSubject = @js[4].ToString(),
                RoomTest = @js[5].ToString()
            };
            return JsonConvert.SerializeObject(cs);
        }


    }

}
