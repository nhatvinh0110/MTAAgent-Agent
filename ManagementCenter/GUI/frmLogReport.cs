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
    public partial class frmLogReport : Form
    {
        public frmLogReport()
        {
            InitializeComponent();
        }

        private void frmLogReport_Load(object sender, EventArgs e)
        {
            int ID_ContestantLog = Convert.ToInt32(fm_LogInfo.ID_InfoContestant);
            // TODO: This line of code loads data into the 'infoContestant.Info_Contestant' table. You can move, or remove it, as needed.
            this.info_ContestantTableAdapter.Fill(this.infoContestant.Info_Contestant,ID_ContestantLog);
            // TODO: This line of code loads data into the 'detailLog.DETAIL_LOG' table. You can move, or remove it, as needed.
            this.dETAIL_LOGTableAdapter.Fill(this.detailLog.DETAIL_LOG);

            this.reportViewer1.RefreshReport();
        }
    }
}
