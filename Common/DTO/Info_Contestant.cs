using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class Info_Contestant
    {
        public int ID_InFor { get; set; }
        public string ContestantCode { get; set; }
        public string FullName { get; set; }
        public string TestDate   { get; set; }
        public string Shifttime { get; set; }
        public string TestSubject { get; set; }
        public string RoomTest { get; set; }
        public string ID_Computer { get; set; }
        public int ID_ContestantLog { get; set; }

    }
}
