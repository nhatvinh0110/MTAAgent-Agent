using Common;
using Common.DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;

namespace ManagementCenter
{
    class DAL_NetworkInterface
    {
        public static DataTable get_Interface_by_ComputerID(string ComputerID)
        {
            return frmMain.dataProvider.getDatatable("select  [NetInterfaceName] ,[List_IPv4] ,[MAC] ,[Description] ,[LastUpdate] ,[Status] ,[State] from NetworkInterfaces where ComputerID = '" + ComputerID + "'");
        }

        public static List<NetInterface> get_InterfaceAsList_Include_ComputerName(DataProvider dataProvider)
        {
            return dataProvider.getList<NetInterface>("SELECT [NetInterfaceID] ,[NetInterfaceName] ,[List_IPv4] ,[MAC] ,[Description] ,[NetworkInterfaces].[LastUpdate] ,[NetworkInterfaces].[Status] ,[NetworkInterfaces].[ComputerID] ,[NetworkInterfaces].[State],(SELECT DATEDIFF(SECOND, [NetworkInterfaces].[LastUpdate] , GETDATE())) AS " + Constant.SecondsDiff + " , [Computers].ComputerName " +
                "  FROM[NetworkInterfaces] join [Computers] on [Computers].ComputerID = NetworkInterfaces.ComputerID left join [Rooms] on Rooms.RoomID = Computers.RoomID where Rooms.Status = 1 or RoomName is null");
        }
    }
}
