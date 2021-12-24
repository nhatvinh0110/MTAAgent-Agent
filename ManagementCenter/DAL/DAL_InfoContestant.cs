using Common.DATA;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCenter.DAL
{
    class DAL_InfoContestant
    {
        public static List<Info_Contestant> get_Info_Contestant()
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant order by ContestantCode ");
        }
        public static DataTable GetName()
        {
            return frmMain.dataProvider.getDatatable($"   select FullName from Info_Contestant order by FullName ");
        }
        public static DataTable GetSubject()
        {
            return frmMain.dataProvider.getDatatable($"   select TestSubject from Info_Contestant order by TestSubject ");
        }
        public static DataTable GetMaTS()
        {
            return frmMain.dataProvider.getDatatable($"   select ContestantCode from Info_Contestant order by ContestantCode ");
        }
        public static List<Info_Contestant> get_Info_Contestant_SubjectAndName(string subject,string name)
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant where FullName = N'{name}' and TestSubject = N'{subject}' order by ContestantCode ");
        }
        public static List<Info_Contestant> get_Info_Contestant_SubjectAndContesttanCode(string subject, string ContestantCode)
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant where ContestantCode = N'{ContestantCode}' and TestSubject = N'{subject}' order by ContestantCode ");
        }
        public static List<Info_Contestant> get_Info_Contestant_ContestantCodeAndName(string ContestantCode, string name)
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant where FullName = N'{name}' and ContestantCode = N'{ContestantCode}' order by ContestantCode ");
        }
        public static List<Info_Contestant> get_Info_Contestant_All(string ContestantCode, string name, string subject)
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant where FullName = N'{name}' and ContestantCode = N'{ContestantCode}' and TestSubject = N'{subject}' order by ContestantCode ");
        }
        public static List<Info_Contestant> get_Info_Contestant(string NameOrSubJectOrContestant)
        {
            return frmMain.dataProvider.getList<Info_Contestant>($"  select * from Info_Contestant where FullName = N'{NameOrSubJectOrContestant}' or TestSubject = N'{NameOrSubJectOrContestant}' or ContestantCode = N'{NameOrSubJectOrContestant}' order by ContestantCode ");
        }
    }
}
