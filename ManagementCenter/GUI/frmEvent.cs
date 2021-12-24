using Common;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCenter.GUI
{
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
        }

        private void btnDeviceEventFilter_Click(object sender, EventArgs e)
        {
            if (cbTypeDeviceEvent.Text != Constant.Wifi && cbTypeDeviceEvent.Text != Constant.USB)
            {
                this.cbTypeDeviceEvent.Text = "";
            }


            List<Event> events = new List<Event>();
            if (!string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && !string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Event.get_Computer_Event(cbTypeDeviceEvent.Text, datePickerDeviceEvent.Value);
            }
            else if (!string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Event.get_Computer_Event(cbTypeDeviceEvent.Text);
            }
            else if (string.IsNullOrEmpty(cbTypeDeviceEvent.Text) && !string.IsNullOrEmpty(datePickerDeviceEvent.Text))
            {
                events = DAL_Event.get_Computer_Event(datePickerDeviceEvent.Value);
            }
            else
            {
                events = DAL_Event.get_Computer_Event();
            }

            DataBinding(events);
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

        private void frmEvent_Load(object sender, EventArgs e)
        {
            List<Event> events = DAL_Event.get_Computer_Event();
            DataBinding(events);
        }
    }
}
