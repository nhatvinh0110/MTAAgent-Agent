using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{

    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int ComputerCount { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Status { get; set; }
		public string ComputerNameTemplate { get; set; }
    }

}
