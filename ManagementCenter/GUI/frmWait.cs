using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCenter.GUI
{
    public partial class frmWait : UserControl
    {
        public frmWait()
        {
            InitializeComponent();
        }

        private void frmWait_Load(object sender, EventArgs e)
        {
            circularProgress1.Show();
            circularProgress1.Value += 2;
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            circularProgress1.Refresh();
        }
    }
}
