using System;
using System.Collections.Generic;
using System.Configuration;
using Common.DTO;

namespace Common.CONFIG
{
    public class Config_Helper
    {
        static Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static bool SetValue(string key, string value)
        {
            try
            {

                //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //config.AppSettings.Settings["test"].Value = "blah";
                //config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                //log.Info("Save setting done! Key: \"" + key + "\" Value: \"" + value + "\"");

                return true;
            }
            catch (ConfigurationErrorsException)
            {
                //log.Error("Save setting failed! Key: \"" + key + "\" Value: \"" + value + "\"");
                return false;
            }
        }

        public static string GetValue(string key, string defaulValue)
        {
            try
            {
                ConfigurationManager.RefreshSection("appSettings");
                string temp = configFile.AppSettings.Settings[key].Value;
                return temp;
            }
            catch (Exception io)
            {
                if(defaulValue == null)
                {
                    throw new Exception("Tệp tin: " + configFile.FilePath + Environment.NewLine + "Key: " + key);
                }
                else
                {
                    if (configFile.AppSettings.Settings[key] == null)
                    {
                        configFile.AppSettings.Settings.Add(key, defaulValue);
                    }
                    else
                    {
                        configFile.AppSettings.Settings[key].Value = defaulValue;
                    }

                    configFile.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                    return defaulValue;
                }
            }
        }
    }
}
