namespace ManagementCenter.GUI
{
    partial class frmEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeviceEventFilter = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.datePickerDeviceEvent = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbTypeDeviceEvent = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePickerDeviceEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeviceEventFilter);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.datePickerDeviceEvent);
            this.panel1.Controls.Add(this.cbTypeDeviceEvent);
            this.panel1.Controls.Add(this.dataGridViewX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 583);
            this.panel1.TabIndex = 8;
            // 
            // btnDeviceEventFilter
            // 
            this.btnDeviceEventFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeviceEventFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeviceEventFilter.ImageTextSpacing = 5;
            this.btnDeviceEventFilter.Location = new System.Drawing.Point(470, 25);
            this.btnDeviceEventFilter.Name = "btnDeviceEventFilter";
            this.btnDeviceEventFilter.Size = new System.Drawing.Size(76, 28);
            this.btnDeviceEventFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeviceEventFilter.Symbol = "";
            this.btnDeviceEventFilter.SymbolSize = 13F;
            this.btnDeviceEventFilter.TabIndex = 15;
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
            this.labelX2.Location = new System.Drawing.Point(234, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Thời gian";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 23);
            this.labelX1.TabIndex = 14;
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
            this.datePickerDeviceEvent.Location = new System.Drawing.Point(301, 30);
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
            this.datePickerDeviceEvent.TabIndex = 12;
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
            this.cbTypeDeviceEvent.Location = new System.Drawing.Point(56, 30);
            this.cbTypeDeviceEvent.Name = "cbTypeDeviceEvent";
            this.cbTypeDeviceEvent.Size = new System.Drawing.Size(140, 21);
            this.cbTypeDeviceEvent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTypeDeviceEvent.TabIndex = 11;
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
            this.ComputerName,
            this.RoomName,
            this.EventCategory,
            this.TimeStamp,
            this.Message,
            this.ID});
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
            this.dataGridViewX1.Location = new System.Drawing.Point(-1, 79);
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
            this.dataGridViewX1.Size = new System.Drawing.Size(1171, 503);
            this.dataGridViewX1.TabIndex = 10;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "Tên máy";
            this.ComputerName.Name = "ComputerName";
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Tên phòng";
            this.RoomName.Name = "RoomName";
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
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePickerDeviceEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnDeviceEventFilter;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datePickerDeviceEvent;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTypeDeviceEvent;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}