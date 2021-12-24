using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public enum EventType { Wifi, USB }
    public class Event
    {
        public int STT { get; set; }
        public string ComputerID { get; set; }

        public string ComputerName { get; set; }

        private string _RoomName;
        public string RoomName
        {
            get
            {
                return _RoomName;
            }
            set
            {
                if (value == null)
                {
                    this._RoomName = Constant.NotAvailable;
                }
                else
                {
                    this._RoomName = value;
                }
            }
        }
        public EventType EventCategory
        { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
