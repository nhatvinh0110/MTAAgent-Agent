using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DATA;
using Common;
using Common.DTO;

namespace ManagementCenter
{
    class DAL_Computer
    {
        public static List<Computer> get_ComputersAsList()
        {
            return frmMain.dataProvider.getList<Computer>("Select * from Computers");
        }

        public static int del_Computer(string computerID)
        {
            return frmMain.dataProvider.ExecuteNonQuery("exec Delete_Computer '" + computerID + "'");
        }

        public static List<Computer> get_ComputersAsList_Include_RoomName(DataProvider dataProvider)
        {
            return dataProvider.getList<Computer>("SELECT [ComputerID] ,[ComputerName] ,[CPUName] ,[RAM] ,[OS] ,[OSReleaseId] , (SELECT DATEDIFF(SECOND, [LastUpdate] , GETDATE())) AS " + Constant.SecondsDiff + " ,Computers.[Status],[Ping] ,[CreateAt] ,[LastUpdate] ,Computers.[RoomID] ,[AgentVersion] ,[DotNetVersion], [RoomName]  FROM [Computers] left join [Rooms] on Computers.RoomID = Rooms.RoomID where Rooms.Status = 1 or RoomName is null");
        }

        public static List<Event> get_Computer_Event(string ComputerID)
        {
            return frmMain.dataProvider.getList<Event>($"select * from Events where ComputerID = '{ComputerID}' order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(string ComputerID, DateTime Date)
        {
            return frmMain.dataProvider.getList<Event>($"select * from Events where ComputerID = '{ComputerID}' and convert(varchar, TimeStamp, 23) = '{Date.ToString("yyyy-MM-dd")}' order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(string ComputerID, string EventType)
        {
            return frmMain.dataProvider.getList<Event>($"select * from Events where ComputerID = '{ComputerID}' and EventCategory = '{EventType}' order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(string ComputerID, string EventType, DateTime Date)
        {
            return frmMain.dataProvider.getList<Event>($"select * from Events where ComputerID = '{ComputerID}' and EventCategory = '{EventType}' and convert(varchar, TimeStamp, 23) = '{Date.ToString("yyyy-MM-dd")}' order by TimeStamp desc");
        }


        public static List<ComputerStatusLog> get_Computer_StatusLog(string ComputerID)
        {
            return frmMain.dataProvider.getList<ComputerStatusLog>($"select * from ComputersStatusLogs where ComputerID = '{ComputerID}' and Time < dateadd(SECOND,-15,getdate()) order by Time desc");
        }

        public static List<ComputerStatusLog> get_Computer_StatusLog(string ComputerID, DateTime Date)
        {
            return frmMain.dataProvider.getList<ComputerStatusLog>($"select * from ComputersStatusLogs where ComputerID = '{ComputerID}' and convert(varchar, Time, 23) = '{Date.ToString("yyyy-MM-dd")}' order by Time desc");
        }

        public static List<ComputerStatusLog> get_Computer_StatusLog(string ComputerID, int Status)
        {
            return frmMain.dataProvider.getList<ComputerStatusLog>($"select * from ComputersStatusLogs where ComputerID = '{ComputerID}' and IsDisconnected = {Status} order by Time desc");
        }

        public static List<ComputerStatusLog> get_Computer_StatusLog(string ComputerID, int Status, DateTime Date)
        {
            return frmMain.dataProvider.getList<ComputerStatusLog>($"select * from ComputersStatusLogs where ComputerID = '{ComputerID}' and IsDisconnected = {Status} and convert(varchar, Time, 23) = '{Date.ToString("yyyy-MM-dd")}' order by Time desc");
        }

        public static int Update_ComputerRoom(int RoomID, string ComputerID)
        {
            return frmMain.dataProvider.ExecuteNonQuery($"exec Update_Computer_RoomID '{ComputerID}', {RoomID}");
        }


        public static string get_ComputerAsXML()
        {
            StringWriter sw = new StringWriter();

            DataTable dt = new DataTable();

            dt = frmMain.dataProvider.getDatatable("Select * from Computers");
            dt.TableName = "Computers";

            dt.WriteXml(sw);
            return sw.ToString();
        }
    }
}
