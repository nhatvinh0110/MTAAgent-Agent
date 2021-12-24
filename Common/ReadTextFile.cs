using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Common.REGISTRY
{
    public class ReadTextFile
    {
        static readonly string textFile = "C://ProgramData//EXON//";
        static readonly string Path = @"C:\ProgramData\EXON";
        
        public static string Read_AllFile(string FolderName)
        {
            FolderName = textFile + FolderName;
            if (File.Exists(FolderName))
            {
                // Read entire text file content in one string    
                return File.ReadAllText(FolderName);
            }
            return null;
        }
        public static string[] GetFileName()
        {

            DirectoryInfo di = new DirectoryInfo(Path);
            FileInfo[] files = di.GetFiles("*.txt");
            int i = 0;
            string[] FolderName=new string[files.Length];
            foreach (FileInfo file in files)
            {
                FolderName[i] = file.Name.ToString();
                i++;
            }
            return FolderName;

        }
    }
}
