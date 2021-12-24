using SimpleWifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.WIFI
{
    public class Wifi_Helper
    {
        public static Wifi wifi = new Wifi();

        public Wifi_Helper()
        {
            
        }
        
        public static void Disconnect()
        {
            if (wifi.ConnectionStatus == WifiStatus.Connected)
            {
                wifi.Disconnect();
            }
        }

        public static bool IsConnected()
        {
            wifi.ConnectionStatusChanged += wifi_ConnectionStatusChanged;

            if (wifi.ConnectionStatus == WifiStatus.Connected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void wifi_ConnectionStatusChanged(object sender, WifiStatusEventArgs e)
        {

        }
    }
}
