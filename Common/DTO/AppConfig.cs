using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class AppConfig
    {
        /**/
        public string SQL_SERVER { set; get; }
        public string SQL_DB_NAME { set; get; }
        public string SQL_USER { set; get; }
        public string SQL_PASSWORD { set; get; }
        /**/
        public bool AUTO_UPDATE_COMPUTERSTATE { set; get; }
        public int AUTO_UPDATE_COMPUTERDATA { set; get; }
        /**/
        public bool AUTO_UPDATE_NICSTATE { set; get; }
        public int AUTO_UPDATE_NICDATA { set; get; }
        /**/
        public int AUTO_PING { set; get; }

    }
}
