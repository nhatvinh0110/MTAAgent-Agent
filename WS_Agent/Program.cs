using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WS_Agent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new WS_Agent()
            //};
            //ServiceBase.Run(ServicesToRun);


            var myService = new WS_Agent();

            if (Environment.UserInteractive)//kiem tra xem có đg chạy trong chế độ tương tác vơi người dùng hay ko
            {
                Console.WriteLine("Starting service...");
                //myService.Start();

                myService.Start();
                Console.WriteLine("Service is running.");
                System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);//neu luồng rơi vào trạng thai ngủ thì đánh thức ngay 
                //Console.WriteLine("Press any key to stop...");
                //Console.ReadKey(true);
                //Console.WriteLine("Stopping service...");
                //myService.Stop();
                //Console.WriteLine("Service stopped.");
            }
            else
            {
                var servicesToRun = new ServiceBase[] { myService };
                ServiceBase.Run(servicesToRun);
            }
        }
    }
}
