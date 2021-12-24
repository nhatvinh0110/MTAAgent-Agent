using Common;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCenter
{
    class DAL_Event
    {
        public static List<Event> get_Computer_Event()
        {
            return frmMain.dataProvider.getList<Event>($"  select ComputerName, RoomName, EventCategory, Events.TimeStamp, Message from Events join Computers on Events.ComputerID = Computers.ComputerID left join Rooms on Computers.RoomID = Rooms.RoomID order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(DateTime Date)
        {
            return frmMain.dataProvider.getList<Event>($"  select ComputerName, RoomName, EventCategory, Events.TimeStamp, Message from Events join Computers on Events.ComputerID = Computers.ComputerID left join Rooms on Computers.RoomID = Rooms.RoomID where convert(varchar, TimeStamp, 23) = '{Date.ToString("yyyy-MM-dd")}' order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(string EventType)
        {
            return frmMain.dataProvider.getList<Event>($"  select ComputerName, RoomName, EventCategory, Events.TimeStamp, Message from Events join Computers on Events.ComputerID = Computers.ComputerID left join Rooms on Computers.RoomID = Rooms.RoomID where EventCategory = '{EventType}' order by TimeStamp desc");
        }

        public static List<Event> get_Computer_Event(string EventType, DateTime Date)
        {
            return frmMain.dataProvider.getList<Event>($"  select ComputerName, RoomName, EventCategory, Events.TimeStamp, Message from Events join Computers on Events.ComputerID = Computers.ComputerID left join Rooms on Computers.RoomID = Rooms.RoomID where EventCategory = '{EventType}' and convert(varchar, TimeStamp, 23) = '{Date.ToString("yyyy-MM-dd")}' order by TimeStamp desc");
        }

    }
}
