using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ANSIBLE
{
    public class AnsibleClient
    {


        public string SSHConnect(string command)
        {
            PasswordAuthenticationMethod PasswordConnection = new PasswordAuthenticationMethod(ConfigurationManager.AppSettings[Constant.ANSIBLE_USER].ToString(), ConfigurationManager.AppSettings[Constant.ANSIBLE_PASSWORD].ToString());

            KeyboardInteractiveAuthenticationMethod KeyboardInteractive = new KeyboardInteractiveAuthenticationMethod(ConfigurationManager.AppSettings[Constant.ANSIBLE_USER].ToString());

            ConnectionInfo connectionInfo = new ConnectionInfo(ConfigurationManager.AppSettings[Constant.ANSIBLE_SERVER].ToString(), Convert.ToInt32(ConfigurationManager.AppSettings[Constant.ANSIBLE_PORT].ToString()), ConfigurationManager.AppSettings[Constant.ANSIBLE_USER].ToString(), PasswordConnection, KeyboardInteractive);

            SshClient ssh = new SshClient(connectionInfo);

            string myData = null;
            if (!ssh.IsConnected)
            {
                ssh.Connect();
            }
            var client = ssh.RunCommand(command);
            myData = client.Result.Replace("\n", Environment.NewLine);
            ssh.Disconnect();

            return myData;
        }

        //"cd /opt/mta_agent; echo '" + playbook_Content + "'> " + roomsName + "-playbook.yml; echo '" + hosts + "'> " + roomsName + "-hosts; echo '" + batchScript_Content + "'> " + roomsName + "_installService_AIO.bat ansible-playbook -i " + roomsName + "-hosts " + roomsName + "-playbook.yml "

    }
}
