using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Constant
    {
        /*data field COMPUTER*/

        public const string RoomID = "RoomID";
        public const string RoomName = "RoomName";
        public const string IP = "IP";
        public const string Username = "Username";
        public const string Password = "Password";
        public const string ComputerName = "ComputerName";
        public const string ComputerID = "ComputerID";
        public const string List_IPv4 = "List_IPv4";
        public const string MAC = "MAC";
        public const string SettingKey = "SettingName";
        public const string SettingValue = "SettingValue";
        public const string isDisableRemoteDesktop = "isDisableRemoteDesktop";
        public const string isDisableWifi = "isDisableWifi";
        public const string Description = "Description";
        public const string NetInterfaceName = "NetInterfaceName";
        public const string NetInterfaceID = "NetInterfaceID";
        public const string SecondsDiff = "SecondsDiff";


        /*Registry path*/
        public const string REG_Agent_Base = @"SOFTWARE\MTAAgent";
        public const string REG_AgentGUID = "AgentGUID";
        public const string REG_ConnectionString = "CON";



        /*datetime format*/
        public const string DateFormat = "yyyy-MM-dd";
        public const string DateFormat2 = "dd-MM-yyyy";
        public const string DateTimeFormat = "HH:mm - dd/MM/yyyy";
        public const string DateTimeFormat2 = "HH:mm:ss - dd/MM/yyyy";
        public const string TimeFormat = "HH:mm:ss";

        /*AUTO properties*/
        public const string AUTO_PING = "AUTO_PING";
        public const string AUTO_UPDATE_COMPUTERDATA = "AUTO_UPDATE_COMPUTERDATA";
        public const string AUTO_UPDATE_COMPUTERSTATE = "AUTO_UPDATE_COMPUTERSTATE";

        public const string AUTO_UPDATE_NICDATA = "AUTO_UPDATE_NICDATA";
        public const string AUTO_UPDATE_NICSTATE = "AUTO_UPDATE_NICSTATE";

        
        /*FTP properties*/
        public const string FTP_SERVER_URI = "FTP_SERVER_URI";
        public const string FTP_USER = "FTP_USER";
        public const string FTP_PASSWORD = "FTP_PASSWORD";

        /*SQL properties*/
        public const string SQL_SERVER = "SQL_SERVER";
        public const string SQL_DB_NAME = "SQL_DB_NAME";
        public const string SQL_USER = "SQL_USER";
        public const string SQL_PASSWORD = "SQL_PASSWORD";

        /*Ansible properties*/
        public const string ANSIBLE_SERVER = "ANSIBLE_SERVER";
        public const string ANSIBLE_PORT = "ANSIBLE_PORT";
        public const string ANSIBLE_USER = "ANSIBLE_USER";
        public const string ANSIBLE_PASSWORD = "ANSIBLE_PASSWORD";

        /*Filename format*/
        public const string FileName_DateTimeFormat = "yyyy-MM-dd_HH-mm-ss";
        public const string FileName_Template_installService = "_installService_AIO.bat";
        public const string FileName_Template_Ansible_hosts = "_hosts.yml";
        public const string FileName_Template_Ansible_playbook = "_Playbook.yml";
        public const string FileName_Template_Ansible_Win_Hostname = "_Playbook_win_hostname.yml";
        public const string FileName_Template_Ansible_DeployApp = "_Playbook_DeployApp.yml";
        public const string FileName_Template_SQLRestore = "_RestoreDB.sql";


        /*Folder format*/
        public const string FolderName_Ansible_playbook = "Ansible_Playbook";
        public const string FolderName_Ansible_hosts = "Ansible_Hosts";
        public const string FolderName_DatabaseBackup = "Database_Backup";
        public const string FolderName_VideoRecords = "VideoRecords";

        /*Picture filetype*/
        public const string PNG = ".png";
        public const string SVG = ".svg";

        /*Display*/
        public const string Online = "Online";
        public const string Offline = "Offline";
        public const string Down = "Down";
        public const string Up = "Up";
        public const string All = "All";
        public const string All_vi = "Tất cả";
        public const string Connected_vi = "Đã kết nối";
        public const string Connected = "Connected";
        public const string Disconnected = "Disconnected";
        public const string Disconnected_vi = "Đã ngắt kết nối";
        public const string Wifi = "Wifi";
        public const string USB = "USB";


        public const string NotAvailable = "N/A";

        public const string BlockWifi = "Chặn Wifi";
        public const string UnBlockWifi = "Hủy chặn Wifi";
        public const string BlockRemote = "Chặn Remote Desktop";
        public const string UnBlockRemote = "Hủy chặn Remote Desktop";
        public const string Del_vi = "Xóa";
        public const string Del = "Delete";
        public const string Edit_vi = "Sửa";
        public const string Rename_Room_vi = "Đổi phòng";
        public const string Rename_Room = "Rename";
        public const string Event_vi = "Sự kiện";
        public const string Event = "Event";
        public const string Detail_vi = "Chi tiết";
        public const string Detail = "Detail";
        public const string NetworkConnection_vi = "Kết nối internet";
        public const string NetworkConnection = "Network Connection";
        public const string Action_vi = "Hành động";


        public const string ComputerName_vi = "Tên máy";
        public const string Status_vi = "Trạng thái";
        public const string RoomID_vi = "ID Phòng";
        public const string RoomName_vi = "Tên phòng";
        public const string ComputerCount = "Số lượng máy tính";
        public const string ComputerID_vi = "ID Máy tính";
        public const string CPUName_vi = "Tên bộ vi xử lý";
        public const string AgentVersion_vi = "Phiên bản Agent";
        public const string Ping_vi = "Ping";
        public const string RAM_vi = "Ram";
        public const string OS_vi = "Hệ điều hành";
        public const string OSReleaseId_vi = "Phiên bản HĐH";
        public const string LastUpdate_vi = "Cập nhật lúc";
        public const string CreateAt_vi = "Ngày tạo";
        public const string DotNetVersion_vi = "Phiên bản .NET";
        public const string STT = "STT";

        public const string Description_vi = "Mô tả";
        public const string NetInterfaceName_vi = "Tên kết nối mạng";


        public const string AutoUpdate_ON = "Tự động cập nhật: Bật";
        public const string AutoUpdate_ON_Icon = "58919";

        public const string AutoUpdate_Error = "Tự động cập nhật: Lỗi";
        public const string AutoUpdate_Error_Icon = "58921";

        public const string AutoUpdate_OFF = "Tự động cập nhật: Tắt";
        public const string AutoUpdate_OFF_Icon = "58920";


        public const string Slider_AutoUpdate_Text = "Chu kỳ cập nhật dữ liệu: %s";





        /*string join*/

        public const string char_Join = "-";


        /*state*/
        public const string Error = "Error";
        public const string Warning = "Warning";
        public const string Success = "Success";


    }
}
