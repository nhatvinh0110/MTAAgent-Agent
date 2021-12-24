using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;  
using System.IO;
using System.Globalization;
using Common.DATA;

namespace Common.DTO
{    
    public class Report_Contestant
    {
        public static DataTable GetConTestant(DataProvider dataprovider,string ID_Log)
        {
            
            return dataprovider.getDatatable("select * from Constestant_Log where ID_ContestantLog = " + ID_Log);
        }
        // bang lu du lieu log may tam thoi
        public string time { get; set; }
        public string eventType { get; set; }
        public string description { get; set; }
    } 

}
