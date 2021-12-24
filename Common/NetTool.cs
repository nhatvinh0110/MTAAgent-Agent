using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Common.Network
{
    public class NetTool
    {
        public static string Ping(string ip)
        {
            string lblResult = "";

            try
            {
                Ping p = new Ping();
                PingReply r;
                r = p.Send(ip);

                if (r.Status == IPStatus.Success)
                {
                    lblResult = r.RoundtripTime.ToString() + " ms";
                }
                else
                {
                    lblResult = Constant.NotAvailable;
                }

            }
            catch
            {
                lblResult = Constant.NotAvailable;
            }

            return lblResult;
        }


        public static string Ping(string Add, ref string status)
        {
            string lblResult = "";

            try
            {
                if(Add.Contains(@"\"))
                {
                    Add = Add.Split('\\')[0];
                }
                else if(Add.Contains(","))
                {
                    Add = Add.Split(',')[0];
                }

                Ping p = new Ping();
                PingReply r;
                r = p.Send(Add, 500);

                if (r.Status == IPStatus.Success)
                {
                    lblResult = r.RoundtripTime.ToString() + " ms";

                    if (r.RoundtripTime > 5)
                    {
                        status = Constant.Warning;
                    }
                    else
                    {
                        status = Constant.Success;
                    }
                }
                else
                {
                    lblResult = Constant.NotAvailable;
                    status = Constant.Error;
                }

            }
            catch
            {
                lblResult = Constant.NotAvailable;
                status = Constant.Error;
            }

            return lblResult;
        }
    }
}
