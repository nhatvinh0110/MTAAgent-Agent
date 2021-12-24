using Common.CONFIG;
using Common.DATA;
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
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            //this.DETAIL_LOGTableAdapter.Fill(this.Log_Dataset.DETAIL_LOG);
            Del_Data();
            this.reportViewer1.RefreshReport();
        }
        public static void Del_Data()
        {
            string con = Config_Helper.GetValue("CON", "");
            DataProvider dataProvider = new DataProvider();
            dataProvider.cnn = new System.Data.SqlClient.SqlConnection(con);
            try
            {
                string query = "Delete from detail_log";
                dataProvider.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
