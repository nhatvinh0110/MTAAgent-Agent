using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.FILE
{
    public class File_Helper
    {
        public static void checkFile(string Path)
        {
            string temp = "";
            List<string> List_Folder = new List<string>();
            List_Folder.AddRange(Path.Split('\\').ToList());
            temp = List_Folder[0];
            for (int i = 0; i<List_Folder.Count - 1;i++)
            {
                
                if (!System.IO.Directory.Exists(temp)) // kiểm tra xem có tồn tại hay không
                {
                    System.IO.Directory.CreateDirectory(temp);
                }
                temp = temp + "\\" + List_Folder[i+1] ;
            }
            
            string CreateFileTxt = Path;
            if (!System.IO.File.Exists(CreateFileTxt))
            {
                System.IO.FileStream cr = new System.IO.FileStream(CreateFileTxt, System.IO.FileMode.Create);
                cr.Close();
                cr.Dispose();
            }
        }



        public static void write(string path, string content, bool append)
        {
            checkFile(path);
            try
            {
                System.IO.StreamWriter GhiFile = new System.IO.StreamWriter(path, append, System.Text.Encoding.Unicode);
                GhiFile.WriteLine(content);
                GhiFile.Close();
                GhiFile.Dispose();
            }
            catch { }

        }

        public static void createFolder(string Path)
        {
            string temp = "";
            List<string> List_Folder = new List<string>();
            List_Folder.AddRange(Path.Split('\\').ToList());
            temp = List_Folder[0];
            for (int i = 0; i < List_Folder.Count; i++)
            {

                if (!System.IO.Directory.Exists(temp)) 
                {
                    System.IO.Directory.CreateDirectory(temp);
                }
                if (i != List_Folder.Count - 1)
                    temp = temp + "\\" + List_Folder[i + 1];
            }
        }

        public static List<string> Get_ListFile(string path)
        {
            createFolder(path);

            DirectoryInfo di = new DirectoryInfo(path);

            return di.GetFiles().Select(x => x.Name).ToList();
        }
    }
}
