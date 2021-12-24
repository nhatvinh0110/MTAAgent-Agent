namespace ManagementCenter
{
    partial class frmNetwork
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
            timer.Dispose();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cbMAC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbIP = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbOffline = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.lbOffline = new DevComponents.DotNetBar.LabelX();
            this.lbDown = new DevComponents.DotNetBar.LabelX();
            this.lball = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.lbUp = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.pnItems = new System.Windows.Forms.Panel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbSTT = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.groupPanel2.Controls.Add(this.cbMAC);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.cbIP);
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
            this.btnClear.Location = new System.Drawing.Point(588, 10);
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
            this.btnSearch.Location = new System.Drawing.Point(483, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 27);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.Symbol = "";
            this.btnSearch.SymbolSize = 10F;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbMAC
            // 
            this.cbMAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMAC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMAC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMAC.DisplayMember = "Text";
            this.cbMAC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMAC.DropDownColumnsHeaders = "Chọn tên máy";
            this.cbMAC.FormattingEnabled = true;
            this.cbMAC.ItemHeight = 15;
            this.cbMAC.Location = new System.Drawing.Point(299, 12);
            this.cbMAC.Name = "cbMAC";
            this.cbMAC.Size = new System.Drawing.Size(164, 21);
            this.cbMAC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMAC.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(232, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 32);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Địa chỉ MAC";
            // 
            // cbIP
            // 
            this.cbIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIP.DisplayMember = "Text";
            this.cbIP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIP.DropDownColumnsHeaders = "Chọn tên phòng";
            this.cbIP.FormattingEnabled = true;
            this.cbIP.ItemHeight = 15;
            this.cbIP.Location = new System.Drawing.Point(72, 12);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(136, 21);
            this.cbIP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIP.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(0, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 32);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Địa chỉ mạng";
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.rbOffline);
            this.groupPanel1.Controls.Add(this.rbDown);
            this.groupPanel1.Controls.Add(this.rbUp);
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
            this.rbOffline.Location = new System.Drawing.Point(309, 18);
            this.rbOffline.Name = "rbOffline";
            this.rbOffline.Size = new System.Drawing.Size(55, 17);
            this.rbOffline.TabIndex = 0;
            this.rbOffline.Text = "Offline";
            this.rbOffline.UseVisualStyleBackColor = false;
            this.rbOffline.Click += new System.EventHandler(this.rb_filter_Click);
            // 
            // rbDown
            // 
            this.rbDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbDown.AutoSize = true;
            this.rbDown.BackColor = System.Drawing.Color.Transparent;
            this.rbDown.Location = new System.Drawing.Point(216, 18);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(53, 17);
            this.rbDown.TabIndex = 0;
            this.rbDown.Text = "Down";
            this.rbDown.UseVisualStyleBackColor = false;
            this.rbDown.Click += new System.EventHandler(this.rb_filter_Click);
            // 
            // rbUp
            // 
            this.rbUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbUp.AutoSize = true;
            this.rbUp.BackColor = System.Drawing.Color.Transparent;
            this.rbUp.Location = new System.Drawing.Point(142, 18);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(39, 17);
            this.rbUp.TabIndex = 0;
            this.rbUp.Text = "Up";
            this.rbUp.UseVisualStyleBackColor = false;
            this.rbUp.Click += new System.EventHandler(this.rb_filter_Click);
            // 
            // rbAll
            // 
            this.rbAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbAll.AutoSize = true;
            this.rbAll.BackColor = System.Drawing.Color.Transparent;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(52, 18);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.Click += new System.EventHandler(this.rb_filter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.line3);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.line1);
            this.panel2.Controls.Add(this.line4);
            this.panel2.Controls.Add(this.lbOffline);
            this.panel2.Controls.Add(this.lbDown);
            this.panel2.Controls.Add(this.lball);
            this.panel2.Controls.Add(this.labelX16);
            this.panel2.Controls.Add(this.lbUp);
            this.panel2.Controls.Add(this.labelX14);
            this.panel2.Controls.Add(this.labelX15);
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
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(126, 9);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(18, 68);
            this.line3.TabIndex = 4;
            this.line3.Text = "line1";
            this.line3.VerticalLine = true;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(544, 9);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(18, 68);
            this.line2.TabIndex = 4;
            this.line2.Text = "line1";
            this.line2.VerticalLine = true;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(407, 9);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(18, 68);
            this.line1.TabIndex = 4;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(267, 9);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(18, 68);
            this.line4.TabIndex = 4;
            this.line4.Text = "line1";
            this.line4.VerticalLine = true;
            // 
            // lbOffline
            // 
            // 
            // 
            // 
            this.lbOffline.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffline.Location = new System.Drawing.Point(463, 29);
            this.lbOffline.Name = "lbOffline";
            this.lbOffline.Size = new System.Drawing.Size(85, 55);
            this.lbOffline.TabIndex = 3;
            this.lbOffline.Text = "0";
            // 
            // lbDown
            // 
            // 
            // 
            // 
            this.lbDown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDown.Location = new System.Drawing.Point(323, 29);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(85, 55);
            this.lbDown.TabIndex = 3;
            this.lbDown.Text = "0";
            // 
            // lball
            // 
            // 
            // 
            // 
            this.lball.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lball.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lball.Location = new System.Drawing.Point(16, 29);
            this.lball.Name = "lball";
            this.lball.Size = new System.Drawing.Size(96, 55);
            this.lball.TabIndex = 3;
            this.lball.Text = "0";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Image = global::ManagementCenter.Properties.Resources.offline;
            this.labelX16.Location = new System.Drawing.Point(431, 41);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(26, 32);
            this.labelX16.TabIndex = 2;
            // 
            // lbUp
            // 
            // 
            // 
            // 
            this.lbUp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUp.Location = new System.Drawing.Point(182, 29);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(86, 55);
            this.lbUp.TabIndex = 3;
            this.lbUp.Text = "0";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Image = global::ManagementCenter.Properties.Resources.warning_1;
            this.labelX14.Location = new System.Drawing.Point(291, 41);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(26, 32);
            this.labelX14.TabIndex = 2;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(431, 7);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 1;
            this.labelX15.Text = "Offline";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Image = global::ManagementCenter.Properties.Resources.online;
            this.labelX13.Location = new System.Drawing.Point(150, 41);
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
            this.labelX12.Location = new System.Drawing.Point(291, 7);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 1;
            this.labelX12.Text = "Down";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(150, 7);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "Up";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(11, 7);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(119, 23);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Số giao diện mạng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pnItems);
            this.panel3.Controls.Add(this.circularProgress1);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 404);
            this.panel3.TabIndex = 0;
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
            // pnItems
            // 
            this.pnItems.AutoScroll = true;
            this.pnItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnItems.Location = new System.Drawing.Point(0, 47);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(1171, 357);
            this.pnItems.TabIndex = 4;
            this.pnItems.ClientSizeChanged += new System.EventHandler(this.pnItems_ClientSizeChanged);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(530, 5);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(111, 37);
            this.labelX9.TabIndex = 2;
            this.labelX9.Text = "Địa chỉ MAC";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(1069, 5);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(97, 37);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Trạng thái";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(332, 5);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(190, 37);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Địa chỉ mạng";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(649, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(270, 37);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Mô tả";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(183, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(141, 37);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tên giao diện mạng";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ImageTextSpacing = 10;
            this.labelX5.Location = new System.Drawing.Point(927, 5);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(134, 37);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Lần cập nhật gần nhất";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(71, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tên máy";
            // 
            // lbSTT
            // 
            this.lbSTT.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbSTT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTT.Location = new System.Drawing.Point(5, 5);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(58, 37);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "STT";
            this.lbSTT.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.083281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.97215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.62953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.17772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.34377F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbSTT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX5, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelX9, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 47);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNetwork";
            this.Text = "frmComputer";
            this.Load += new System.EventHandler(this.frmNetwork_Load);
            this.Shown += new System.EventHandler(this.frmNetwork_Shown);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMAC;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbIP;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.RadioButton rbAll;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.LabelX lbDown;
        private DevComponents.DotNetBar.LabelX lball;
        private DevComponents.DotNetBar.LabelX lbUp;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.RadioButton rbOffline;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX lbOffline;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Panel pnItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.LabelX lbSTT;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
    }
}