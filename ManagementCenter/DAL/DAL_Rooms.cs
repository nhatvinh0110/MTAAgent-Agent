using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Common.DTO;

namespace ManagementCenter
{
    class DAL_Rooms
    {
        public static DataTable get_Rooms()
        {
            return frmMain.dataProvider.getDatatable("Select * from Rooms");
        }

        public static DataTable get_Rooms_Active()
        {
            return frmMain.dataProvider.getDatatable("Select * from Rooms where status = 1");
        }

		public static List<Room> get_Rooms_Include_ComputerCount()
        {
            return frmMain.dataProvider.getList<Room>("SELECT [RoomID] ,[RoomName] ,[UpdatedDate] ,[Status], ComputerNameTemplate, (select count(Computers.ComputerID) from Computers where Computers.RoomID = Rooms.RoomID) as 'ComputerCount' FROM [Rooms]");
        }

		public static int InsertRoom(Room room)
        {
            return frmMain.dataProvider.ExecuteNonQuery($"exec Create_Room N'{room.RoomName}', {room.Status}, '{room.ComputerNameTemplate}' ");
        }


        public static int UpdateRoom(Room room)
        {
            return frmMain.dataProvider.ExecuteNonQuery($"exec Update_Room {room.RoomID}, N'{room.RoomName}', {room.Status}, '{room.ComputerNameTemplate}' ");
        }

        public static int DeleteRoom(int RoomID)
        {
            return frmMain.dataProvider.ExecuteNonQuery($"exec Delete_Room {RoomID}");
        }

    }
}
