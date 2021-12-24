using Common.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Windows.Forms;

namespace ManagementCenter.GUI
{
    public partial class frmComputerEvent : Form
    {
        public frmComputerEvent(string ComputerID)
        {
            InitializeComponent();


            computerId = ComputerID;
        }

        private string computerId;



        private void superTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            if(superTabControl1.SelectedTab == superTabItem1)
            {
                List<Event> events = DAL_Computer.get_Computer_Event(computerId);
               DataBinding(events);
            }
            else if(superTabControl1.SelectedTab == superTabItem2)
            {
                List<ComputerStatusLog> statuss = DAL_Computer.get_Computer_StatusLog(computerId);
                DataBinding(statuss);
            }
        }

        private void DataBinding(List<Event> data)
        {

            //cbTypeDeviceEvent.DataSource = data.Select(i => i.EventCategory.ToString()).Distinct().ToList();

            for (int i = 0; i < data.Count; i++)
            {
                data[i].STT = i + 1;
            }

            dataGridViewX1.DataSource = data;

            dataGridViewX1.Columns["TimeStamp"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

        }
        private void DataBinding(List<ComputerStatusLog> data)
        {

            dataGridViewX2.DataSource = data;

            for (int i = 0; i < dataGridViewX2.RowCount; i++)
            {
                if (dataGridViewX2.Rows[i].Cells["Type"].Value.ToString() == "true")
                {
                    dataGridViewX2.Rows[i].Cells["Type"].Value = Constant.Disconnected;
                }
                else
                {
                    dataGridViewX2.Rows[i].Cells["Type"].Value = Constant.Connected;
                }
                dataGridViewX2.Rows[i].Cells["STT2"].Value = i + 1;
            }

            dataGridViewX2.Columns["Time"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

        }



        private void frmComputerEvent_Load(object sender, EventArgs e)
        {

            superTabControl1_SelectedTabChanged(null, null);

        }

        private void dataGridViewX1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void btnDeviceEventFilter_Click(object sender, EventArgs e)
        {
            if (cbTypeDeviceEvent.Text != Constant.Wifi && cbTypeDeviceEvent.Text != Constant.USB)
            {
                cbTypeDeviceEvent.Text = "";
            }


            List<Event> events = new List<Event>();
            if(!string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && !string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Computer.get_Computer_Event(computerId, cbTypeDeviceEvent.Text, datePickerDeviceEvent.Value);
            }
            else if (!string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Computer.get_Computer_Event(computerId, cbTypeDeviceEvent.Text);
            }
            else if (string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && !string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Computer.get_Computer_Event(computerId, datePickerDeviceEvent.Value);
            }
            else
            {
                events = DAL_Computer.get_Computer_Event(computerId);
            }

            DataBinding(events);
        }

        private void btnConnecttionEventFilter_Click(object sender, EventArgs e)
        {
            int status = -1;
            if(cbTypeConnectionEvent.Text == "Connected")
            {
                status = 0;
            }
            else if(cbTypeConnectionEvent.Text == "Disconnected")
            {
                status = 1;
            }
            else
            {
                cbTypeConnectionEvent.Text = "";
            }

            List<ComputerStatusLog> events = new List<ComputerStatusLog>();
            if (!string.IsNullOrEmpty(cbTypeConnectionEvent.Text) && !string.IsNullOrEmpty(datePickerConnectionEvent.Text))
            {
                events = DAL_Computer.get_Computer_StatusLog(computerId, status, datePickerConnectionEvent.Value);
            }
            else if (!string.IsNullOrEmpty(cbTypeConnectionEvent.Text) && string.IsNullOrEmpty(datePickerConnectionEvent.Text))
            {
                events = DAL_Computer.get_Computer_StatusLog(computerId, status);
            }
            else if (string.IsNullOrEmpty(cbTypeConnectionEvent.Text) && !string.IsNullOrEmpty(datePickerConnectionEvent.Text))
            {
                events = DAL_Computer.get_Computer_StatusLog(computerId, datePickerConnectionEvent.Value);
            }
            else
            {
                events = DAL_Computer.get_Computer_StatusLog(computerId);
            }

            DataBinding(events);
        }
    }
}
