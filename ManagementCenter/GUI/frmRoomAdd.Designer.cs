namespace ManagementCenter
{
    partial class frmRoomAdd
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
			this.cbActive = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.labelX1 = new DevComponents.DotNetBar.LabelX();
			this.btnOK = new DevComponents.DotNetBar.ButtonX();
			this.txtRoomName = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
			this.labelX2 = new DevComponents.DotNetBar.LabelX();
			this.txtComputerNameTemplate = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.labelX2);
			this.panel1.Controls.Add(this.txtComputerNameTemplate);
			this.panel1.Controls.Add(this.cbActive);
			this.panel1.Controls.Add(this.labelX1);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.txtRoomName);
			this.panel1.Controls.Add(this.ribbonControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(389, 210);
			this.panel1.TabIndex = 2;
			// 
			// cbActive
			// 
			// 
			// 
			// 
			this.cbActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.cbActive.Location = new System.Drawing.Point(22, 141);
			this.cbActive.Name = "cbActive";
			this.cbActive.Size = new System.Drawing.Size(100, 23);
			this.cbActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbActive.TabIndex = 6;
			this.cbActive.Text = "Kích hoạt";
			// 
			// labelX1
			// 
			// 
			// 
			// 
			this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX1.Location = new System.Drawing.Point(22, 36);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new System.Drawing.Size(104, 23);
			this.labelX1.TabIndex = 5;
			this.labelX1.Text = "Nhập tên phòng thi:";
			// 
			// btnOK
			// 
			this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnOK.Location = new System.Drawing.Point(162, 164);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(65, 27);
			this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtRoomName
			// 
			// 
			// 
			// 
			this.txtRoomName.Border.Class = "TextBoxBorder";
			this.txtRoomName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtRoomName.Location = new System.Drawing.Point(22, 61);
			this.txtRoomName.Name = "txtRoomName";
			this.txtRoomName.PreventEnterBeep = true;
			this.txtRoomName.Size = new System.Drawing.Size(335, 20);
			this.txtRoomName.TabIndex = 3;
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
			this.ribbonControl1.Size = new System.Drawing.Size(387, 26);
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
			this.ribbonControl1.TabIndex = 2;
			this.ribbonControl1.Text = "ribbonControl1";
			// 
			// labelX2
			// 
			// 
			// 
			// 
			this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labelX2.Location = new System.Drawing.Point(22, 87);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new System.Drawing.Size(140, 23);
			this.labelX2.TabIndex = 8;
			this.labelX2.Text = "Nhập quy tắc đặt tên máy:";
			// 
			// txtComputerNameTemplate
			// 
			// 
			// 
			// 
			this.txtComputerNameTemplate.Border.Class = "TextBoxBorder";
			this.txtComputerNameTemplate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtComputerNameTemplate.Location = new System.Drawing.Point(22, 112);
			this.txtComputerNameTemplate.Name = "txtComputerNameTemplate";
			this.txtComputerNameTemplate.PreventEnterBeep = true;
			this.txtComputerNameTemplate.Size = new System.Drawing.Size(335, 20);
			this.txtComputerNameTemplate.TabIndex = 7;
			// 
			// frmRoomAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 210);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmRoomAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm mới phòng thi";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRoomName;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbActive;
		private DevComponents.DotNetBar.LabelX labelX2;
		private DevComponents.DotNetBar.Controls.TextBoxX txtComputerNameTemplate;
	}
}