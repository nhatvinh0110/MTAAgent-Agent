using Common;
using Common.CONFIG;
using System;
using System.Windows.Forms;
using Common.DATA;
using DevComponents.DotNetBar;

namespace ManagementCenter.GUI
{
    public partial class frmConnectMSSQL : Form
    {
        public frmConnectMSSQL()
        {
            InitializeComponent();
        }

        DataProvider dataProvider = new DataProvider();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Config_Helper.SetValue(Constant.SQL_DB_NAME, txtDatabasename.Text) && Config_Helper.SetValue(Constant.SQL_PASSWORD, txtPassword.Text) && Config_Helper.SetValue(Constant.SQL_SERVER, txtServername.Text) && Config_Helper.SetValue(Constant.SQL_USER, txtUsername.Text))
            {
                MessageBoxEx.Show("Lưu cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain.LoadConfig();
            }
            else
            {
                DialogResult result = MessageBoxEx.Show("Xảy ra lỗi khi lưu cấu hình. Nhấp Retry để thử lại, nhấp Cancel để hủy bỏ.", "Xác nhận", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void frmConnectMSSQL_Shown(object sender, EventArgs e)
        {

            txtPassword.Text = frmMain.config.SQL_PASSWORD;
            txtDatabasename.Text = frmMain.config.SQL_DB_NAME;
            txtServername.Text = frmMain.config.SQL_SERVER;
            txtUsername.Text = frmMain.config.SQL_USER;

        }

    }
}
