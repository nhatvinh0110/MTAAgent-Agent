using Common;
using DevComponents.DotNetBar.SuperGrid;

namespace ManagementCenter
{
    partial class frmComputer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cbComputerName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbRooms = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbOffline = new System.Windows.Forms.RadioButton();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.switchAutoUpdate = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.sliderAutoUpdate = new DevComponents.DotNetBar.Controls.Slider();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lbAuto = new DevComponents.DotNetBar.LabelX();
            this.lbLastUpdate = new DevComponents.DotNetBar.LabelX();
            this.lbPing = new DevComponents.DotNetBar.LabelX();
            this.btnBlockWifi = new DevComponents.DotNetBar.ButtonX();
            this.btnBlockRemote = new DevComponents.DotNetBar.ButtonX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.lbOffline = new DevComponents.DotNetBar.LabelX();
            this.lball = new DevComponents.DotNetBar.LabelX();
            this.lbOnline = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnItems = new System.Windows.Forms.Panel();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn_STT = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_RoomName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_ComputerName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_AgentVer = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_LastUpdate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_Ping = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_State = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_Action = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_CPUName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_Ram = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_OS = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_OSReleaseId = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_Status = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_CreateAt = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_RoomID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_DotNetVersion = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_ComputerID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_SecondsDiff = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn_S_State = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.flyout1 = new DevComponents.DotNetBar.Controls.Flyout(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 91);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 91);
            this.splitContainer1.SplitterDistance = 719;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel2.Controls.Add(this.btnClear);
            this.groupPanel2.Controls.Add(this.btnSearch);
            this.groupPanel2.Controls.Add(this.cbComputerName);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.cbRooms);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 6);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(704, 75);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Tìm kiếm";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(590, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 27);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(485, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 27);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.Symbol = "";
            this.btnSearch.SymbolSize = 10F;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbComputerName
            // 
            this.cbComputerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbComputerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbComputerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbComputerName.DisplayMember = "Text";
            this.cbComputerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbComputerName.DropDownColumnsHeaders = "Chọn tên máy";
            this.cbComputerName.FormattingEnabled = true;
            this.cbComputerName.ItemHeight = 15;
            this.cbComputerName.Location = new System.Drawing.Point(293, 14);
            this.cbComputerName.Name = "cbComputerName";
            this.cbComputerName.Size = new System.Drawing.Size(164, 21);
            this.cbComputerName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbComputerName.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(234, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 32);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên máy";
            // 
            // cbRooms
            // 
            this.cbRooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRooms.DisplayMember = "Text";
            this.cbRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRooms.DropDownColumnsHeaders = "Chọn tên phòng";
            this.cbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRooms.FormattingEnabled = true;
            this.cbRooms.ItemHeight = 15;
            this.cbRooms.Location = new System.Drawing.Point(69, 14);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(136, 21);
            this.cbRooms.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRooms.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 32);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Phòng thi";
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.rbOffline);
            this.groupPanel1.Controls.Add(this.rbOnline);
            this.groupPanel1.Controls.Add(this.rbAll);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(5, 6);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(431, 75);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "Lọc kết quả";
            // 
            // rbOffline
            // 
            this.rbOffline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbOffline.AutoSize = true;
            this.rbOffline.BackColor = System.Drawing.Color.Transparent;
            this.rbOffline.Location = new System.Drawing.Point(298, 18);
            this.rbOffline.Name = "rbOffline";
            this.rbOffline.Size = new System.Drawing.Size(55, 17);
            this.rbOffline.TabIndex = 0;
            this.rbOffline.Text = "Offline";
            this.rbOffline.UseVisualStyleBackColor = false;
            this.rbOffline.CheckedChanged += new System.EventHandler(this.rb_filter_CheckedChanged);
            // 
            // rbOnline
            // 
            this.rbOnline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbOnline.AutoSize = true;
            this.rbOnline.BackColor = System.Drawing.Color.Transparent;
            this.rbOnline.Location = new System.Drawing.Point(189, 18);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(55, 17);
            this.rbOnline.TabIndex = 0;
            this.rbOnline.Text = "Online";
            this.rbOnline.UseVisualStyleBackColor = false;
            this.rbOnline.CheckedChanged += new System.EventHandler(this.rb_filter_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbAll.AutoSize = true;
            this.rbAll.BackColor = System.Drawing.Color.Transparent;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(80, 18);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rb_filter_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelEx1);
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.lbAuto);
            this.panel2.Controls.Add(this.lbLastUpdate);
            this.panel2.Controls.Add(this.lbPing);
            this.panel2.Controls.Add(this.btnBlockWifi);
            this.panel2.Controls.Add(this.btnBlockRemote);
            this.panel2.Controls.Add(this.line3);
            this.panel2.Controls.Add(this.line4);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.line1);
            this.panel2.Controls.Add(this.lbOffline);
            this.panel2.Controls.Add(this.lball);
            this.panel2.Controls.Add(this.lbOnline);
            this.panel2.Controls.Add(this.labelX14);
            this.panel2.Controls.Add(this.labelX13);
            this.panel2.Controls.Add(this.labelX12);
            this.panel2.Controls.Add(this.labelX11);
            this.panel2.Controls.Add(this.labelX10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 88);
            this.panel2.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.switchAutoUpdate);
            this.panelEx1.Controls.Add(this.line5);
            this.panelEx1.Controls.Add(this.sliderAutoUpdate);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(841, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(204, 78);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 11;
            this.panelEx1.Visible = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(126, 20);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tự động cập nhật dữ liệu:";
            // 
            // switchAutoUpdate
            // 
            // 
            // 
            // 
            this.switchAutoUpdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchAutoUpdate.Location = new System.Drawing.Point(137, 8);
            this.switchAutoUpdate.Name = "switchAutoUpdate";
            this.switchAutoUpdate.Size = new System.Drawing.Size(58, 18);
            this.switchAutoUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchAutoUpdate.TabIndex = 2;
            this.switchAutoUpdate.ValueChanged += new System.EventHandler(this.switchAutoUpdate_ValueChanged);
            // 
            // line5
            // 
            this.line5.Location = new System.Drawing.Point(11, 31);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(181, 8);
            this.line5.TabIndex = 1;
            this.line5.Text = "line5";
            // 
            // sliderAutoUpdate
            // 
            // 
            // 
            // 
            this.sliderAutoUpdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sliderAutoUpdate.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Top;
            this.sliderAutoUpdate.Location = new System.Drawing.Point(3, 42);
            this.sliderAutoUpdate.Minimum = 8;
            this.sliderAutoUpdate.Name = "sliderAutoUpdate";
            this.sliderAutoUpdate.Size = new System.Drawing.Size(198, 31);
            this.sliderAutoUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sliderAutoUpdate.TabIndex = 0;
            this.sliderAutoUpdate.Text = "slider1";
            this.sliderAutoUpdate.Value = 0;
            this.sliderAutoUpdate.ValueChanged += new System.EventHandler(this.sliderAutoUpdate_ValueChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1065, 33);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(84, 25);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SubItemsExpandWidth = 25;
            this.buttonX1.Symbol = "59497";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.SymbolSize = 13F;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Cài đặt";
            // 
            // lbAuto
            // 
            // 
            // 
            // 
            this.lbAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuto.Location = new System.Drawing.Point(428, 6);
            this.lbAuto.Name = "lbAuto";
            this.lbAuto.Size = new System.Drawing.Size(171, 26);
            this.lbAuto.Symbol = "58919";
            this.lbAuto.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbAuto.TabIndex = 9;
            this.lbAuto.Text = "Tự động cập nhật: Bật";
            // 
            // lbLastUpdate
            // 
            // 
            // 
            // 
            this.lbLastUpdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLastUpdate.Location = new System.Drawing.Point(431, 57);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(240, 25);
            this.lbLastUpdate.Symbol = "57746";
            this.lbLastUpdate.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbLastUpdate.SymbolSize = 12F;
            this.lbLastUpdate.TabIndex = 8;
            this.lbLastUpdate.Text = "Cập nhật lúc: N/A";
            // 
            // lbPing
            // 
            // 
            // 
            // 
            this.lbPing.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPing.Location = new System.Drawing.Point(428, 33);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(171, 25);
            this.lbPing.Symbol = "59605";
            this.lbPing.SymbolColor = System.Drawing.Color.Red;
            this.lbPing.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbPing.SymbolSize = 20F;
            this.lbPing.TabIndex = 7;
            this.lbPing.Text = "N/A";
            // 
            // btnBlockWifi
            // 
            this.btnBlockWifi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBlockWifi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBlockWifi.Location = new System.Drawing.Point(722, 26);
            this.btnBlockWifi.Name = "btnBlockWifi";
            this.btnBlockWifi.Size = new System.Drawing.Size(44, 52);
            this.btnBlockWifi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBlockWifi.TabIndex = 6;
            this.btnBlockWifi.Text = "Chặn Wifi";
            this.btnBlockWifi.Visible = false;
            this.btnBlockWifi.CheckedChanged += new System.EventHandler(this.btnBlockWifi_CheckedChanged);
            this.btnBlockWifi.Click += new System.EventHandler(this.btnBlockWifi_Click);
            // 
            // btnBlockRemote
            // 
            this.btnBlockRemote.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBlockRemote.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBlockRemote.Location = new System.Drawing.Point(616, 26);
            this.btnBlockRemote.Name = "btnBlockRemote";
            this.btnBlockRemote.Size = new System.Drawing.Size(100, 52);
            this.btnBlockRemote.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBlockRemote.TabIndex = 6;
            this.btnBlockRemote.Text = "Chặn Remote Desktop";
            this.btnBlockRemote.Visible = false;
            this.btnBlockRemote.CheckedChanged += new System.EventHandler(this.btnBlockRemote_CheckedChanged);
            this.btnBlockRemote.Click += new System.EventHandler(this.btnBlockRemote_Click);
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(126, 10);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(18, 68);
            this.line3.TabIndex = 4;
            this.line3.Text = "line1";
            this.line3.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(267, 10);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(18, 68);
            this.line4.TabIndex = 4;
            this.line4.Text = "line1";
            this.line4.VerticalLine = true;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(788, 16);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 68);
            this.line2.TabIndex = 4;
            this.line2.Text = "line1";
            this.line2.VerticalLine = true;
            this.line2.Visible = false;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(404, 10);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(18, 68);
            this.line1.TabIndex = 4;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // lbOffline
            // 
            // 
            // 
            // 
            this.lbOffline.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffline.Location = new System.Drawing.Point(323, 30);
            this.lbOffline.Name = "lbOffline";
            this.lbOffline.Size = new System.Drawing.Size(85, 55);
            this.lbOffline.TabIndex = 3;
            this.lbOffline.Text = "0";
            // 
            // lball
            // 
            // 
            // 
            // 
            this.lball.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lball.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lball.Location = new System.Drawing.Point(21, 30);
            this.lball.Name = "lball";
            this.lball.Size = new System.Drawing.Size(96, 55);
            this.lball.TabIndex = 3;
            this.lball.Text = "0";
            // 
            // lbOnline
            // 
            // 
            // 
            // 
            this.lbOnline.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnline.Location = new System.Drawing.Point(182, 30);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(86, 55);
            this.lbOnline.TabIndex = 3;
            this.lbOnline.Text = "0";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Image = global::ManagementCenter.Properties.Resources.offline;
            this.labelX14.Location = new System.Drawing.Point(291, 42);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(26, 32);
            this.labelX14.TabIndex = 2;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Image = global::ManagementCenter.Properties.Resources.online;
            this.labelX13.Location = new System.Drawing.Point(150, 42);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(26, 32);
            this.labelX13.TabIndex = 2;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(291, 8);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 1;
            this.labelX12.Text = "Offline";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(150, 8);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "Online";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(21, 8);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Tổng máy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pnItems);
            this.panel3.Controls.Add(this.circularProgress1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 404);
            this.panel3.TabIndex = 0;
            // 
            // pnItems
            // 
            this.pnItems.AutoScroll = true;
            this.pnItems.Controls.Add(this.superGridControl1);
            this.pnItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnItems.Location = new System.Drawing.Point(0, 0);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(1171, 404);
            this.pnItems.TabIndex = 4;
            // 
            // superGridControl1
            // 
            this.superGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 0);
            this.superGridControl1.Name = "superGridControl1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeaderText = "";
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 47;
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_STT);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_RoomName);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_ComputerName);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_AgentVer);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_LastUpdate);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_Ping);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_State);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_Action);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_CPUName);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_Ram);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_OS);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_OSReleaseId);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_Status);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_CreateAt);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_RoomID);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_DotNetVersion);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_ComputerID);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_SecondsDiff);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_S_State);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 47;
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Header.AllowSelection = false;
            this.superGridControl1.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.superGridControl1.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.superGridControl1.PrimaryGrid.MinRowHeight = 15;
            this.superGridControl1.PrimaryGrid.MultiSelect = false;
            this.superGridControl1.PrimaryGrid.ShowRowHeaders = false;
            this.superGridControl1.Size = new System.Drawing.Size(1171, 404);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.TabSelection = DevComponents.DotNetBar.SuperGrid.TabSelection.CellSameRow;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.ColumnHeaderClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridColumnHeaderClickEventArgs>(this.superGridControl1_ColumnHeaderClick);
            this.superGridControl1.GetCellValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellValueEventArgs>(this.superGridControl1_GetCellValue);
            this.superGridControl1.GetColumnHeaderStyle += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetColumnHeaderStyleEventArgs>(this.superGridControl1_GetColumnHeaderStyle);
            this.superGridControl1.GetRowCellStyle += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetRowCellStyleEventArgs>(this.superGridControl1_GetRowCellStyle);
            // 
            // gridColumn_STT
            // 
            this.gridColumn_STT.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn_STT.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_STT.CellStyles.ReadOnly.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_STT.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_STT.Name = "STT";
            this.gridColumn_STT.ReadOnly = true;
            this.gridColumn_STT.Width = 60;
            // 
            // gridColumn_RoomName
            // 
            this.gridColumn_RoomName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn_RoomName.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_RoomName.Name = "Tên phòng";
            this.gridColumn_RoomName.ReadOnly = true;
            // 
            // gridColumn_ComputerName
            // 
            this.gridColumn_ComputerName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn_ComputerName.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_ComputerName.Name = "Tên máy";
            this.gridColumn_ComputerName.ReadOnly = true;
            // 
            // gridColumn_AgentVer
            // 
            this.gridColumn_AgentVer.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.ColumnHeader;
            this.gridColumn_AgentVer.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_AgentVer.Name = "Phiên bản Agent";
            this.gridColumn_AgentVer.ReadOnly = true;
            // 
            // gridColumn_LastUpdate
            // 
            this.gridColumn_LastUpdate.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn_LastUpdate.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_LastUpdate.Name = "Cập nhật gần nhất";
            this.gridColumn_LastUpdate.ReadOnly = true;
            this.gridColumn_LastUpdate.Width = 160;
            // 
            // gridColumn_Ping
            // 
            this.gridColumn_Ping.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn_Ping.CellStyles.ReadOnly.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_Ping.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_Ping.Name = "Ping";
            this.gridColumn_Ping.ReadOnly = true;
            this.gridColumn_Ping.Width = 80;
            // 
            // gridColumn_State
            // 
            this.gridColumn_State.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.ColumnHeader;
            this.gridColumn_State.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_State.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_State.CellStyles.ReadOnly.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_State.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_State.DataPropertyName = "State";
            this.gridColumn_State.EditorType = null;
            this.gridColumn_State.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_State.Name = "Trạng thái";
            this.gridColumn_State.ReadOnly = true;
            // 
            // gridColumn_Action
            // 
            this.gridColumn_Action.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn_Action.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn_Action.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            this.gridColumn_Action.Name = "Hành động";
            this.gridColumn_Action.Width = 250;
            // 
            // gridColumn_CPUName
            // 
            this.gridColumn_CPUName.Name = "Tên CPU";
            this.gridColumn_CPUName.Visible = false;
            // 
            // gridColumn_Ram
            // 
            this.gridColumn_Ram.Name = "RAM";
            this.gridColumn_Ram.Visible = false;
            // 
            // gridColumn_OS
            // 
            this.gridColumn_OS.Name = "Hệ điều hành";
            this.gridColumn_OS.Visible = false;
            // 
            // gridColumn_OSReleaseId
            // 
            this.gridColumn_OSReleaseId.Name = "Phiên bản HĐH";
            this.gridColumn_OSReleaseId.Visible = false;
            // 
            // gridColumn_Status
            // 
            this.gridColumn_Status.Name = "Trạng thái";
            this.gridColumn_Status.Visible = false;
            // 
            // gridColumn_CreateAt
            // 
            this.gridColumn_CreateAt.Name = "Ngày tạo";
            this.gridColumn_CreateAt.Visible = false;
            // 
            // gridColumn_RoomID
            // 
            this.gridColumn_RoomID.Name = "ID Phòng thi";
            this.gridColumn_RoomID.Visible = false;
            // 
            // gridColumn_DotNetVersion
            // 
            this.gridColumn_DotNetVersion.Name = "Phiên bản .NET";
            this.gridColumn_DotNetVersion.Visible = false;
            // 
            // gridColumn_ComputerID
            // 
            this.gridColumn_ComputerID.Name = "ID Máy tính";
            this.gridColumn_ComputerID.Visible = false;
            // 
            // gridColumn_SecondsDiff
            // 
            this.gridColumn_SecondsDiff.Name = "SecondsDiff";
            this.gridColumn_SecondsDiff.Visible = false;
            // 
            // gridColumn_S_State
            // 
            this.gridColumn_S_State.Name = "S_State";
            this.gridColumn_S_State.Visible = false;
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Enabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(564, 98);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.Size = new System.Drawing.Size(75, 68);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 5;
            // 
            // flyout1
            // 
            this.flyout1.Content = this.panelEx1;
            this.flyout1.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.MouseClick;
            this.flyout1.DropShadow = false;
            this.flyout1.Parent = this;
            this.flyout1.TargetControl = this.buttonX1;
            // 
            // frmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComputer";
            this.Text = "frmComputer";
            this.Shown += new System.EventHandler(this.frmComputer_Shown);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbComputerName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRooms;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.RadioButton rbOffline;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Panel pnItems;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.LabelX lbOffline;
        private DevComponents.DotNetBar.LabelX lball;
        private DevComponents.DotNetBar.LabelX lbOnline;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.ButtonX btnBlockRemote;
        private DevComponents.DotNetBar.ButtonX btnBlockWifi;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_STT;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_RoomName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_ComputerName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_AgentVer;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_LastUpdate;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_Ping;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_State;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_Action;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_CPUName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_Ram;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_OS;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_OSReleaseId;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_Status;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_CreateAt;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_RoomID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_DotNetVersion;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_ComputerID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_SecondsDiff;
        private GridColumn gridColumn_S_State;
        private DevComponents.DotNetBar.LabelX lbAuto;
        private DevComponents.DotNetBar.LabelX lbLastUpdate;
        private DevComponents.DotNetBar.LabelX lbPing;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.Flyout flyout1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.SwitchButton switchAutoUpdate;
        private DevComponents.DotNetBar.Controls.Line line5;
        private DevComponents.DotNetBar.Controls.Slider sliderAutoUpdate;
    }
}