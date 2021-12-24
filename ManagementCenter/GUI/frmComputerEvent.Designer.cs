namespace ManagementCenter.GUI
{
    partial class frmComputerEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnConnecttionEventFilter = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.datePickerConnectionEvent = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbTypeConnectionEvent = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.btnDeviceEventFilter = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.datePickerDeviceEvent = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbTypeDeviceEvent = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePickerConnectionEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePickerDeviceEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.superTabControl1);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 28);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(798, 420);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 7;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.Text = "superTabControl1";
            this.superTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.superTabControl1_SelectedTabChanged);
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.btnConnecttionEventFilter);
            this.superTabControlPanel2.Controls.Add(this.labelX3);
            this.superTabControlPanel2.Controls.Add(this.labelX4);
            this.superTabControlPanel2.Controls.Add(this.datePickerConnectionEvent);
            this.superTabControlPanel2.Controls.Add(this.cbTypeConnectionEvent);
            this.superTabControlPanel2.Controls.Add(this.dataGridViewX2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(798, 395);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // btnConnecttionEventFilter
            // 
            this.btnConnecttionEventFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnecttionEventFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnecttionEventFilter.ImageTextSpacing = 5;
            this.btnConnecttionEventFilter.Location = new System.Drawing.Point(469, 16);
            this.btnConnecttionEventFilter.Name = "btnConnecttionEventFilter";
            this.btnConnecttionEventFilter.Size = new System.Drawing.Size(76, 28);
            this.btnConnecttionEventFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnecttionEventFilter.Symbol = "";
            this.btnConnecttionEventFilter.SymbolSize = 13F;
            this.btnConnecttionEventFilter.TabIndex = 8;
            this.btnConnecttionEventFilter.Text = "Lọc";
            this.btnConnecttionEventFilter.Click += new System.EventHandler(this.btnConnecttionEventFilter_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(235, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(61, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Thời gian";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 18);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(39, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Type";
            // 
            // datePickerConnectionEvent
            // 
            // 
            // 
            // 
            this.datePickerConnectionEvent.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datePickerConnectionEvent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerConnectionEvent.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datePickerConnectionEvent.ButtonDropDown.Visible = true;
            this.datePickerConnectionEvent.IsPopupCalendarOpen = false;
            this.datePickerConnectionEvent.Location = new System.Drawing.Point(302, 21);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datePickerConnectionEvent.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerConnectionEvent.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datePickerConnectionEvent.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datePickerConnectionEvent.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerConnectionEvent.MonthCalendar.DisplayMonth = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datePickerConnectionEvent.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datePickerConnectionEvent.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datePickerConnectionEvent.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datePickerConnectionEvent.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerConnectionEvent.MonthCalendar.TodayButtonVisible = true;
            this.datePickerConnectionEvent.Name = "datePickerConnectionEvent";
            this.datePickerConnectionEvent.Size = new System.Drawing.Size(148, 20);
            this.datePickerConnectionEvent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datePickerConnectionEvent.TabIndex = 5;
            // 
            // cbTypeConnectionEvent
            // 
            this.cbTypeConnectionEvent.DisplayMember = "Text";
            this.cbTypeConnectionEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeConnectionEvent.FormattingEnabled = true;
            this.cbTypeConnectionEvent.ItemHeight = 14;
            this.cbTypeConnectionEvent.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1,
            this.comboItem2});
            this.cbTypeConnectionEvent.Location = new System.Drawing.Point(57, 21);
            this.cbTypeConnectionEvent.Name = "cbTypeConnectionEvent";
            this.cbTypeConnectionEvent.Size = new System.Drawing.Size(140, 20);
            this.cbTypeConnectionEvent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTypeConnectionEvent.TabIndex = 4;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Tất cả";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Connected";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Disconnected";
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX2.ColumnHeadersHeight = 30;
            this.dataGridViewX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.Type,
            this.Time,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX2.EnableHeadersVisualStyles = false;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewX2.Name = "dataGridViewX2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX2.RowTemplate.Height = 30;
            this.dataGridViewX2.Size = new System.Drawing.Size(798, 334);
            this.dataGridViewX2.TabIndex = 1;
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.Width = 50;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "IsDisconnected";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Thời gian";
            this.Time.Name = "Time";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ComputerID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ComputerID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Connection Event";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.btnDeviceEventFilter);
            this.superTabControlPanel1.Controls.Add(this.labelX2);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Controls.Add(this.datePickerDeviceEvent);
            this.superTabControlPanel1.Controls.Add(this.cbTypeDeviceEvent);
            this.superTabControlPanel1.Controls.Add(this.dataGridViewX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(798, 395);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // btnDeviceEventFilter
            // 
            this.btnDeviceEventFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeviceEventFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeviceEventFilter.ImageTextSpacing = 5;
            this.btnDeviceEventFilter.Location = new System.Drawing.Point(470, 16);
            this.btnDeviceEventFilter.Name = "btnDeviceEventFilter";
            this.btnDeviceEventFilter.Size = new System.Drawing.Size(76, 28);
            this.btnDeviceEventFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeviceEventFilter.Symbol = "";
            this.btnDeviceEventFilter.SymbolSize = 13F;
            this.btnDeviceEventFilter.TabIndex = 9;
            this.btnDeviceEventFilter.Text = "Lọc";
            this.btnDeviceEventFilter.Click += new System.EventHandler(this.btnDeviceEventFilter_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(234, 18);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Thời gian";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Type";
            // 
            // datePickerDeviceEvent
            // 
            // 
            // 
            // 
            this.datePickerDeviceEvent.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datePickerDeviceEvent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerDeviceEvent.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.datePickerDeviceEvent.ButtonDropDown.Visible = true;
            this.datePickerDeviceEvent.IsPopupCalendarOpen = false;
            this.datePickerDeviceEvent.Location = new System.Drawing.Point(301, 21);
            // 
            // 
            // 
            // 
            // 
            // 
            this.datePickerDeviceEvent.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerDeviceEvent.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.datePickerDeviceEvent.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datePickerDeviceEvent.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerDeviceEvent.MonthCalendar.DisplayMonth = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.datePickerDeviceEvent.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datePickerDeviceEvent.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datePickerDeviceEvent.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datePickerDeviceEvent.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datePickerDeviceEvent.MonthCalendar.TodayButtonVisible = true;
            this.datePickerDeviceEvent.Name = "datePickerDeviceEvent";
            this.datePickerDeviceEvent.Size = new System.Drawing.Size(148, 20);
            this.datePickerDeviceEvent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.datePickerDeviceEvent.TabIndex = 2;
            // 
            // cbTypeDeviceEvent
            // 
            this.cbTypeDeviceEvent.DisplayMember = "Text";
            this.cbTypeDeviceEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeDeviceEvent.FormattingEnabled = true;
            this.cbTypeDeviceEvent.ItemHeight = 15;
            this.cbTypeDeviceEvent.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cbTypeDeviceEvent.Location = new System.Drawing.Point(56, 21);
            this.cbTypeDeviceEvent.Name = "cbTypeDeviceEvent";
            this.cbTypeDeviceEvent.Size = new System.Drawing.Size(140, 21);
            this.cbTypeDeviceEvent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTypeDeviceEvent.TabIndex = 1;
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Tất cả";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Wifi";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "USB";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeight = 30;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.EventCategory,
            this.TimeStamp,
            this.Message,
            this.ID,
            this.RoomName,
            this.ComputerName});
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
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 61);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.RowTemplate.Height = 30;
            this.dataGridViewX1.Size = new System.Drawing.Size(798, 334);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewX1_RowsAdded);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Device Event";
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
            this.ribbonControl1.Size = new System.Drawing.Size(798, 28);
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
            this.ribbonControl1.TabIndex = 6;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // EventCategory
            // 
            this.EventCategory.DataPropertyName = "EventCategory";
            this.EventCategory.HeaderText = "Type";
            this.EventCategory.Name = "EventCategory";
            // 
            // TimeStamp
            // 
            this.TimeStamp.DataPropertyName = "TimeStamp";
            this.TimeStamp.HeaderText = "Thời gian";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Width = 130;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 300;
            this.Message.Name = "Message";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ComputerID";
            this.ID.HeaderText = "ComputerID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "RoomName";
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = false;
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "ComputerName";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Visible = false;
            // 
            // frmComputerEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComputerEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sự kiện";
            this.Load += new System.EventHandler(this.frmComputerEvent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePickerConnectionEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePickerDeviceEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datePickerDeviceEvent;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTypeDeviceEvent;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datePickerConnectionEvent;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTypeConnectionEvent;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.ButtonX btnDeviceEventFilter;
        private DevComponents.DotNetBar.ButtonX btnConnecttionEventFilter;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
    }
}