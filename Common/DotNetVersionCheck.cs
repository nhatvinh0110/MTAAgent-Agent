using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DotNET
{
    public class DotNetVersionCheck
    {

        
        private static void processValueNames(RegistryKey Key, ref List<string> ver)
        { //function to process the valueNames for a given key
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
                        ver.Add(obj.ToString());
                    }
                }
            }
        }

        public static void OutputRegKey(RegistryKey Key, ref List<string> ver)
        {
            try
            {
                string[] subkeynames = Key.GetSubKeyNames(); //means deeper folder
                if (subkeynames == null || subkeynames.Length <= 0)
                { //has no more subkey, process
                    processValueNames(Key, ref ver);
                    return;
                }
                foreach (string keyname in subkeynames)
                { //has subkeys, go deeper
                    using (RegistryKey key2 = Key.OpenSubKey(keyname))
                        OutputRegKey(key2, ref ver);
                }
                processValueNames(Key, ref ver);
            }
            catch (Exception e)
            {
                //error, do something
            }
        }


        public static List<string> GetList_DotNetVersion()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\");

            List<string> ver = new List<string>();

            OutputRegKey(key, ref ver);

            return ver.Distinct().OrderByDescending(q => q).ToList();
        }

        public static string GetList_DotNetVersion_Latest()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\");

            List<string> ver = new List<string>();

            OutputRegKey(key, ref ver);

            return ver.Distinct().OrderByDescending(q => q).ToList().First();
        }

    }
}
