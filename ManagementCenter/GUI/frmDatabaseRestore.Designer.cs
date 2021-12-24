namespace ManagementCenter.GUI
{
    partial class frmDatabaseRestore
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
            this.btnRestoreNow = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.pnItems = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRestoreNow
            // 
            this.btnRestoreNow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestoreNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestoreNow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestoreNow.Location = new System.Drawing.Point(644, 8);
            this.btnRestoreNow.Name = "btnRestoreNow";
            this.btnRestoreNow.Size = new System.Drawing.Size(149, 40);
            this.btnRestoreNow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRestoreNow.TabIndex = 6;
            this.btnRestoreNow.Text = "Khôi phục phiên bản";
            this.btnRestoreNow.Click += new System.EventHandler(this.btnRestoreNow_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(361, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(144, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Các bản sao lưu khả dụng";
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.line1.Location = new System.Drawing.Point(362, 54);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(431, 10);
            this.line1.TabIndex = 3;
            this.line1.Text = "line1";
            // 
            // pnItems
            // 
            this.pnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnItems.AutoScroll = true;
            this.pnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnItems.Location = new System.Drawing.Point(362, 70);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(431, 445);
            this.pnItems.TabIndex = 4;
            // 
            // frmDatabaseRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 544);
            this.Controls.Add(this.btnRestoreNow);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pnItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabaseRestore";
            this.Text = "frmDatabaseRestore";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnRestoreNow;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel pnItems;
    }
}