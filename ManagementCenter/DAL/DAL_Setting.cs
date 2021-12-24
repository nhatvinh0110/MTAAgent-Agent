using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ManagementCenter
{
    class DAL_Setting
    {
        public static int update_SettingValue(string settingKey, string settingValue)
        {
            return frmMain.dataProvider.ExecuteNonQuery("update Setting set SettingValue = N'" + settingValue + "' where SettingName = '" + settingKey + "'");
        }

        public static DataTable get_Setting()
        {
            return frmMain.dataProvider.getDatatable("Select * from Setting");
        }

    }
}
