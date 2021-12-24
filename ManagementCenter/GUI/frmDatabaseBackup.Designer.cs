namespace ManagementCenter.GUI
{
    partial class frmDatabaseBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.btnBackupNow = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.pnItems = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circularProgress1);
            this.panel1.Controls.Add(this.btnBackupNow);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.pnItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 544);
            this.panel1.TabIndex = 0;
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Enabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(649, 14);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.Size = new System.Drawing.Size(30, 22);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 4;
            // 
            // btnBackupNow
            // 
            this.btnBackupNow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackupNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackupNow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackupNow.Location = new System.Drawing.Point(682, 12);
            this.btnBackupNow.Name = "btnBackupNow";
            this.btnBackupNow.Size = new System.Drawing.Size(114, 26);
            this.btnBackupNow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackupNow.Symbol = "";
            this.btnBackupNow.SymbolSize = 15F;
            this.btnBackupNow.TabIndex = 2;
            this.btnBackupNow.Text = "Sao lưu ngay";
            this.btnBackupNow.Click += new System.EventHandler(this.btnBackupNow_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(365, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Lịch sử sao lưu";
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.line1.Location = new System.Drawing.Point(365, 44);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(431, 10);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // pnItems
            // 
            this.pnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnItems.AutoScroll = true;
            this.pnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnItems.Location = new System.Drawing.Point(365, 54);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(431, 459);
            this.pnItems.TabIndex = 0;
            // 
            // frmDatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 544);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabaseBackup";
            this.Text = "frmDatabaseBackup";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnItems;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.ButtonX btnBackupNow;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}