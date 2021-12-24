using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class ComputerStatusLog
    {
        public string ComputerID { get; set; }
        public DateTime Time { get; set; }
        public string IsDisconnected { get; set; }
    }
}
