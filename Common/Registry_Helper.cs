using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.REGISTRY
{
    public class Registry_Helper
    {
        public static void Check_Exits(string Path)
        {
            RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(Path);
            registryKey.Close();
        }
        public static string Read_Value(string path, string Name)
        {
            string temp = "";
            RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(path);
            try
            {
                temp = registryKey.GetValue(Name).ToString();

            }
            catch
            {
                registryKey.Close();
                //File_Read_Write.Write_File(@"LogFile.txt", DateTime.Now + @" Error: Read registry 'HKEY_LOCAL_MACHINE\" + path + "' fail! " + io.Message, true);
                return null;
            }
            registryKey.Close();
            return temp;
        }
        public static void Write_Value(string path, string Name, string Value)
        {
            RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(path);
            try
            {
                registryKey.SetValue(Name, Value);
                registryKey.Close();
            }
            catch
            {
                //File_Read_Write.Write_File(@"LogFile.txt", DateTime.Now + @" Error: Write registry 'HKEY_LOCAL_MACHINE\" + path + "' fail! " + io.Message, true);
            }

        }
        public static void Del_Value(string path, string Name)
        {
            try
            {
                RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(path);
                registryKey.DeleteValue(Name);
                registryKey.Close();
            }
            catch
            {
                //File_Read_Write.Write_File(@"LogFile.txt", DateTime.Now + @" Error: Delete registry 'HKEY_LOCAL_MACHINE\" + path + "' fail! " + io.Message, true);
            }

        }

        public static List<string> Read_List_Value(string path)
        {
            List<string> Lis = new List<string>();
            try
            {
                RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(path);
                Lis = registryKey.GetValueNames().ToList();
                registryKey.Close();
            }
            catch
            {
                //File_Read_Write.Write_File(@"LogFile.txt", DateTime.Now + @" Error: Read registry 'HKEY_LOCAL_MACHINE\" + path + "' fail! " + io.Message, true);
                return null;
            }
            return Lis;
        }

        
        private static void processValueNames(RegistryKey Key)
        { //function to process the valueNames for a given key
            List<string> ver = new List<string>();
            string[] valuenames = Key.GetValueNames();
            if (valuenames == null || valuenames.Length <= 0) //has no values
                return;
            foreach (string valuename in valuenames)
            {
                object obj = Key.GetValue(valuename);
                if (obj != null)
                {
                    if (valuename == "Version")
                    {
                        ver.Add("Path: " +  obj.ToString());
                    }
                }
            }
        }

        public static void OutputRegKey(RegistryKey Key)
        {
            try
            {
                string[] subkeynames = Key.GetSubKeyNames(); //means deeper folder
                if (subkeynames == null || subkeynames.Length <= 0)
                { //has no more subkey, process
                    processValueNames(Key);
                    return;
                }
                foreach (string keyname in subkeynames)
                { //has subkeys, go deeper
                    using (RegistryKey key2 = Key.OpenSubKey(keyname))
                        OutputRegKey(key2);
                }
                processValueNames(Key);
            }
            catch (Exception e)
            {
                //error, do something
                throw new Exception(e.Message, e.InnerException);
            }
        }

    }
}
