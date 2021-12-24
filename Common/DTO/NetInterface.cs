using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Common.DTO
{
    public class NetInterface
    {
        public int NetInterfaceID { get; set; }
        public string NetInterfaceName { get; set; }
        public string List_IPv4 { get; set; }
        public string MAC { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Status { get; set; }
        public string ComputerID { get; set; }
        public string State { get; set; }
        public Bitmap State_icon { get; set; }
        public string ComputerName { get; set; }
        public int SecondsDiff { set; get; }

    }
}
