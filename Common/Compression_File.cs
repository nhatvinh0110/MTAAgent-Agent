using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using Common.FILE;

namespace Common.Compression
{
    public class Compression_File
    {
        public Exception Run_DongNen_DB(string inputDictionary, string output_filename)
        {
            try
            {
                Ionic.Zip.ZipFile file = new ZipFile();
                file.AddDirectory(inputDictionary);

                //System.IO.DirectoryInfo File_Info = new System.IO.DirectoryInfo(Registry_Read_Write.Read_Value(@"SOFTWARE\MaiA Sync\" + Server_Name + @"\SaveBackupTo", DB_Name));
                File_Helper.createFolder(AppDomain.CurrentDomain.BaseDirectory + @"Release");
                // file.SaveProgress += Save_Process;
                file.Save(AppDomain.CurrentDomain.BaseDirectory + @"Release\" + output_filename + ".zip");

            }
            catch (Exception er)
            {
                
                return er;
            }
            return null;
        }
    }
}
