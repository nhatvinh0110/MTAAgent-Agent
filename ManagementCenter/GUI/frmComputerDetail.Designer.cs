namespace ManagementCenter
{
    partial class frmComputerDetail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtComputerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCPU = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRAM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOSVer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNetVer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCreatedDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.InterfaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.swActive = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên máy tính: ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 119);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 17);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Bộ vi xử lý:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(21, 171);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 17);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Bộ nhớ RAM:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(21, 67);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(140, 17);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Hệ điều hành: ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(286, 67);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(140, 17);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Phiên bản hệ điều hành:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(286, 119);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(140, 17);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Phiên bản Net Framework:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(286, 15);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(140, 17);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Ngày tạo:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(21, 230);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(140, 17);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Giao diện mạng:";
            // 
            // txtComputerName
            // 
            // 
            // 
            // 
            this.txtComputerName.Border.Class = "TextBoxBorder";
            this.txtComputerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComputerName.Enabled = false;
            this.txtComputerName.Location = new System.Drawing.Point(21, 33);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.PreventEnterBeep = true;
            this.txtComputerName.Size = new System.Drawing.Size(230, 20);
            this.txtComputerName.TabIndex = 2;
            // 
            // txtCPU
            // 
            // 
            // 
            // 
            this.txtCPU.Border.Class = "TextBoxBorder";
            this.txtCPU.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCPU.Enabled = false;
            this.txtCPU.Location = new System.Drawing.Point(21, 137);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.PreventEnterBeep = true;
            this.txtCPU.Size = new System.Drawing.Size(230, 20);
            this.txtCPU.TabIndex = 2;
            // 
            // txtRAM
            // 
            // 
            // 
            // 
            this.txtRAM.Border.Class = "TextBoxBorder";
            this.txtRAM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRAM.Enabled = false;
            this.txtRAM.Location = new System.Drawing.Point(21, 189);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.PreventEnterBeep = true;
            this.txtRAM.Size = new System.Drawing.Size(230, 20);
            this.txtRAM.TabIndex = 2;
            // 
            // txtOS
            // 
            // 
            // 
            // 
            this.txtOS.Border.Class = "TextBoxBorder";
            this.txtOS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOS.Enabled = false;
            this.txtOS.Location = new System.Drawing.Point(21, 85);
            this.txtOS.Name = "txtOS";
            this.txtOS.PreventEnterBeep = true;
            this.txtOS.Size = new System.Drawing.Size(230, 20);
            this.txtOS.TabIndex = 2;
            // 
            // txtOSVer
            // 
            // 
            // 
            // 
            this.txtOSVer.Border.Class = "TextBoxBorder";
            this.txtOSVer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOSVer.Enabled = false;
            this.txtOSVer.Location = new System.Drawing.Point(286, 85);
            this.txtOSVer.Name = "txtOSVer";
            this.txtOSVer.PreventEnterBeep = true;
            this.txtOSVer.Size = new System.Drawing.Size(230, 20);
            this.txtOSVer.TabIndex = 2;
            // 
            // txtNetVer
            // 
            // 
            // 
            // 
            this.txtNetVer.Border.Class = "TextBoxBorder";
            this.txtNetVer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNetVer.Enabled = false;
            this.txtNetVer.Location = new System.Drawing.Point(286, 137);
            this.txtNetVer.Name = "txtNetVer";
            this.txtNetVer.PreventEnterBeep = true;
            this.txtNetVer.Size = new System.Drawing.Size(230, 20);
            this.txtNetVer.TabIndex = 2;
            // 
            // txtCreatedDate
            // 
            // 
            // 
            // 
            this.txtCreatedDate.Border.Class = "TextBoxBorder";
            this.txtCreatedDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedDate.Enabled = false;
            this.txtCreatedDate.Location = new System.Drawing.Point(286, 33);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.PreventEnterBeep = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(230, 20);
            this.txtCreatedDate.TabIndex = 2;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterfaceName,
            this.MAC,
            this.IP,
            this.Description,
            this.LastUpdate,
            this.State,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(21, 253);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.Size = new System.Drawing.Size(495, 149);
            this.dataGridViewX1.TabIndex = 1;
            // 
            // InterfaceName
            // 
            this.InterfaceName.DataPropertyName = "NetInterfaceName";
            this.InterfaceName.HeaderText = "Tên";
            this.InterfaceName.Name = "InterfaceName";
            this.InterfaceName.Width = 117;
            // 
            // MAC
            // 
            this.MAC.DataPropertyName = "MAC";
            this.MAC.HeaderText = "Địa chỉ MAC";
            this.MAC.Name = "MAC";
            this.MAC.Width = 118;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "List_IPv4";
            this.IP.HeaderText = "Địa chỉ IP";
            this.IP.Name = "IP";
            this.IP.Width = 117;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Miêu tả";
            this.Description.Name = "Description";
            this.Description.Width = 62;
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "Thời gian cập nhật";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Width = 92;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Trạng thái";
            this.State.Name = "State";
            this.State.Width = 74;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Kích hoạt";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 54;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(286, 171);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(58, 17);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Kích hoạt:";
            // 
            // swActive
            // 
            // 
            // 
            // 
            this.swActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swActive.Location = new System.Drawing.Point(286, 191);
            this.swActive.Name = "swActive";
            this.swActive.Size = new System.Drawing.Size(54, 17);
            this.swActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swActive.TabIndex = 4;
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(542, 30);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 5;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.swActive);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txtCreatedDate);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.txtNetVer);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.txtOSVer);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.txtOS);
            this.panelEx1.Controls.Add(this.labelX7);
            this.panelEx1.Controls.Add(this.txtRAM);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.txtCPU);
            this.panelEx1.Controls.Add(this.labelX9);
            this.panelEx1.Controls.Add(this.txtComputerName);
            this.panelEx1.Controls.Add(this.dataGridViewX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 30);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(542, 470);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(205, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmComputerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 500);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 500);
            this.Name = "frmComputerDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmComputerDetail";
            this.Load += new System.EventHandler(this.frmComputerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComputerName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCPU;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRAM;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOS;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOSVer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNetVer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCreatedDate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterfaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.SwitchButton swActive;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}