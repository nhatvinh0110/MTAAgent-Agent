using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SMO
{
    public class SMOClient
    {
        private static Server srv;
        public static void GetTransferScript(string FileName, string ServerName, string User, string Password, string dbName)
        {

            srv = new Server(new Microsoft.SqlServer.Management.Common.ServerConnection(ServerName, User, Password));
            Database dbs = srv.Databases[dbName];

            var transfer = new Transfer(dbs);

            transfer.CopyAllObjects = true;
            transfer.CopyAllSynonyms = true;
            transfer.CopyData = false;

            // additional options
            //transfer.Options.ScriptDrops = true;
            transfer.Options.WithDependencies = true;
            transfer.Options.DriAll = true;
            transfer.Options.Triggers = true;
            transfer.Options.Indexes = true;
            transfer.Options.SchemaQualifyForeignKeysReferences = true;
            transfer.Options.ExtendedProperties = true;
            transfer.Options.IncludeDatabaseRoleMemberships = true;
            transfer.Options.Permissions = true;
            transfer.PreserveDbo = true;
            transfer.Options.ScriptData = true;
            transfer.Options.AppendToFile = true;
            transfer.Options.FileName = FileName;

            // generates script
            var t = transfer.EnumScriptTransfer();

            srv.ConnectionContext.Disconnect();
        }

        public static Exception ExcuteScript(string FileName, string ServerName, string User, string Password, string dbName)
        {
            srv = new Server(new Microsoft.SqlServer.Management.Common.ServerConnection(ServerName, User, Password));

            try
            {
                srv.ConnectionContext.ExecuteNonQuery(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + Constant.FileName_Template_SQLRestore).Replace("%_DBNAME_%", dbName) + File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + FileName));

                srv.ConnectionContext.Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

            return null;
        }
    }
}
