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
    public partial class frmError : Form
    {
        public frmError(string Message)
        {
            InitializeComponent();

            labelX1.Text = "Error: " + Message;
        }
    }
}
