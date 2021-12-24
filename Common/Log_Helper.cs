using log4net;
using log4net.Appender;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CustomDBAppender : AdoNetAppender
    {
        public CustomDBAppender(string con)
        {
            log4net.Config.XmlConfigurator.Configure();
            log4net.Repository.Hierarchy.Hierarchy hier = log4net.LogManager.GetRepository() as log4net.Repository.Hierarchy.Hierarchy;

            if (hier != null)
            {
                var adoAppender = (AdoNetAppender)hier.GetAppenders()
                                    .Where(appender => appender.Name.Equals("AdoNetAppender", StringComparison.InvariantCultureIgnoreCase))
                                    .FirstOrDefault();

                if (adoAppender != null)
                {
                    adoAppender.ConnectionString = con;
                    adoAppender.ActivateOptions(); //refresh settings of appender
                }
            }

        }
    }

    public static class Log_Helper
    {
        public static CustomDBAppender customDBAppender;

        private static readonly ILog log = log4net.LogManager.GetLogger(System.Environment.MachineName);

        //static ILog _log = LogManager.GetLogger(typeof(AdoNetAppender));

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Error(string message, Exception io)
        {
            log.Error(message, io);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }

        public static void Warn(string message)
        {
            log.Warn(message);
        }

        public static void Warn(string message, Exception io)
        {
            log.Warn(message, io);
        }

        public static void Fatal (string message)
        {
            log.Fatal(message);
        }

        public static void Fatal(string message, Exception io)
        {
            log.Fatal(message, io);
        }
    }
}
