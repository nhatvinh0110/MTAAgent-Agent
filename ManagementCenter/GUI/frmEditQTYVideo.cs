using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common.CONFIG;
using System.Diagnostics;
namespace ManagementCenter.GUI
{
    public partial class frmEditQTYVideo : Form
    {
        public frmEditQTYVideo()
        {
            InitializeComponent();
        }

        private void frmEditQTYVideo_Load(object sender, EventArgs e)
        {
            try
            {
            using (SqlConnection cn = GetSqlConnection())
            {
                cn.Open();
                string query_0 = "SELECT TOP 1 QTYVideo FROM dbo.StatusVideoLog ORDER BY ComputerID";
                using (SqlCommand cmd = new SqlCommand(query_0, cn))
                {
                    this.numericUpDown_video.Value = (Int32)cmd.ExecuteScalar();
                }
                cn.Close();
            }
            }
            catch
            {
                this.numericUpDown_video.Value = 0;
            }

            
        }
        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(frmMain.con);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                cn.Open();
                string query_0 = "UPDATE dbo.StatusVideoLog SET QTYVideo = "+this.numericUpDown_video.Value+"";
                using (SqlCommand cmd = new SqlCommand(query_0, cn))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
            this.Close();
        }

        private void button_canel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
