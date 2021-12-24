namespace ManagementCenter
{
    partial class pnComputerItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnComputerItem));
            this.lbSTT = new DevComponents.DotNetBar.LabelX();
            this.lbRoom = new DevComponents.DotNetBar.LabelX();
            this.lbComputerName = new DevComponents.DotNetBar.LabelX();
            this.lbPing = new DevComponents.DotNetBar.LabelX();
            this.lbAgentVersion = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbState = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeName = new DevComponents.DotNetBar.ButtonX();
            this.btnDetail = new DevComponents.DotNetBar.ButtonX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.lbLastUpdate = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSTT
            // 
            // 
            // 
            // 
            this.lbSTT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSTT.Location = new System.Drawing.Point(5, 5);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(43, 37);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "Loading...";
            this.lbSTT.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbRoom
            // 
            // 
            // 
            // 
            this.lbRoom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoom.Location = new System.Drawing.Point(56, 5);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(116, 37);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Loading...";
            // 
            // lbComputerName
            // 
            // 
            // 
            // 
            this.lbComputerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbComputerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComputerName.Location = new System.Drawing.Point(180, 5);
            this.lbComputerName.Name = "lbComputerName";
            this.lbComputerName.Size = new System.Drawing.Size(166, 37);
            this.lbComputerName.TabIndex = 0;
            this.lbComputerName.Text = "Loading...";
            // 
            // lbPing
            // 
            // 
            // 
            // 
            this.lbPing.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPing.Location = new System.Drawing.Point(579, 5);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(57, 37);
            this.lbPing.TabIndex = 0;
            this.lbPing.Text = "Loading...";
            // 
            // lbAgentVersion
            // 
            // 
            // 
            // 
            this.lbAgentVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbAgentVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAgentVersion.Location = new System.Drawing.Point(354, 5);
            this.lbAgentVersion.Name = "lbAgentVersion";
            this.lbAgentVersion.Size = new System.Drawing.Size(80, 37);
            this.lbAgentVersion.TabIndex = 0;
            this.lbAgentVersion.Text = "Loading...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.530775F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.96892F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.426024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.lbSTT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbRoom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbState, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbComputerName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPing, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAgentVersion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLastUpdate, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 47);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbState
            // 
            // 
            // 
            // 
            this.lbState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbState.Image = global::ManagementCenter.Properties.Resources.offline;
            this.lbState.ImageTextSpacing = 10;
            this.lbState.Location = new System.Drawing.Point(644, 5);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(116, 37);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "Online";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeName);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(768, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnChangeName
            // 
            this.btnChangeName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeName.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeName.Image")));
            this.btnChangeName.Location = new System.Drawing.Point(145, 3);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(104, 31);
            this.btnChangeName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeName.TabIndex = 0;
            this.btnChangeName.Text = "Đổi tên";
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDetail.Image = global::ManagementCenter.Properties.Resources.detail;
            this.btnDetail.Location = new System.Drawing.Point(259, 3);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(106, 31);
            this.btnDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Image = global::ManagementCenter.Properties.Resources.delete_20px;
            this.btnDel.Location = new System.Drawing.Point(33, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 31);
            this.btnDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbLastUpdate
            // 
            // 
            // 
            // 
            this.lbLastUpdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLastUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLastUpdate.Location = new System.Drawing.Point(442, 5);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(129, 37);
            this.lbLastUpdate.TabIndex = 2;
            this.lbLastUpdate.Text = "Loading...";
            // 
            // pnComputerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pnComputerItem";
            this.Size = new System.Drawing.Size(1171, 47);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.LabelX lbSTT;
        public DevComponents.DotNetBar.LabelX lbRoom;
        public DevComponents.DotNetBar.LabelX lbComputerName;
        public DevComponents.DotNetBar.LabelX lbPing;
        public DevComponents.DotNetBar.LabelX lbAgentVersion;
        public DevComponents.DotNetBar.LabelX lbState;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnDetail;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.ButtonX btnChangeName;
        public DevComponents.DotNetBar.LabelX lbLastUpdate;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
