namespace ManagementCenter
{
    partial class frmRoom
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
			this.btnAddRoom = new DevComponents.DotNetBar.ButtonX();
			superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
			this.gridColumn_STT = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn_RoomName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn_ComputerCount = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn_LastUpdate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn_State = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn_Action = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.btnReload = new DevComponents.DotNetBar.ButtonX();
			this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
			this.SuspendLayout();
			// 
			// btnAddRoom
			// 
			this.btnAddRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnAddRoom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnAddRoom.Location = new System.Drawing.Point(12, 12);
			this.btnAddRoom.Name = "btnAddRoom";
			this.btnAddRoom.Size = new System.Drawing.Size(71, 29);
			this.btnAddRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnAddRoom.Symbol = "57669";
			this.btnAddRoom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btnAddRoom.TabIndex = 1;
			this.btnAddRoom.Text = "Thêm";
			this.btnAddRoom.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
			// 
			// superGridControl1
			// 
			superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
			superGridControl1.Location = new System.Drawing.Point(0, 58);
			superGridControl1.Name = "superGridControl1";
			// 
			// 
			// 
			// 
			// 
			// 
			superGridControl1.PrimaryGrid.ColumnHeader.RowHeaderText = "";
			superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 47;
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_STT);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_RoomName);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_ComputerCount);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn2);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_LastUpdate);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_State);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn_Action);
			superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn1);
			superGridControl1.PrimaryGrid.DefaultRowHeight = 47;
			// 
			// 
			// 
			superGridControl1.PrimaryGrid.Header.AllowSelection = false;
			superGridControl1.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
			superGridControl1.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
			superGridControl1.PrimaryGrid.MinRowHeight = 15;
			superGridControl1.PrimaryGrid.MultiSelect = false;
			superGridControl1.PrimaryGrid.ShowRowHeaders = false;
			superGridControl1.Size = new System.Drawing.Size(1155, 486);
			superGridControl1.TabIndex = 2;
			superGridControl1.TabSelection = DevComponents.DotNetBar.SuperGrid.TabSelection.CellSameRow;
			superGridControl1.Text = "superGridControl1";
			superGridControl1.GetCellValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellValueEventArgs>(superGridControl1_GetCellValue);
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
			// gridColumn_ComputerCount
			// 
			this.gridColumn_ComputerCount.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
			this.gridColumn_ComputerCount.CellStyles.ReadOnly.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
			this.gridColumn_ComputerCount.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
			this.gridColumn_ComputerCount.Name = "Số lượng máy tính";
			this.gridColumn_ComputerCount.ReadOnly = true;
			this.gridColumn_ComputerCount.Width = 200;
			// 
			// gridColumn_LastUpdate
			// 
			this.gridColumn_LastUpdate.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
			this.gridColumn_LastUpdate.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
			this.gridColumn_LastUpdate.Name = "Cập nhật gần nhất";
			this.gridColumn_LastUpdate.ReadOnly = true;
			this.gridColumn_LastUpdate.Width = 160;
			// 
			// gridColumn_State
			// 
			this.gridColumn_State.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.ColumnHeader;
			this.gridColumn_State.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
			this.gridColumn_State.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
			this.gridColumn_State.CellStyles.ReadOnly.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
			this.gridColumn_State.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
			this.gridColumn_State.DataPropertyName = "State";
			this.gridColumn_State.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
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
			// gridColumn1
			// 
			this.gridColumn1.Name = "ID";
			this.gridColumn1.Visible = false;
			// 
			// btnReload
			// 
			this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnReload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnReload.Location = new System.Drawing.Point(99, 12);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(93, 29);
			this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnReload.Symbol = "57384";
			this.btnReload.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btnReload.TabIndex = 1;
			this.btnReload.Text = "Làm mới";
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// gridColumn2
			// 
			this.gridColumn2.Name = "Mẫu đặt tên máy";
			// 
			// frmRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 544);
			this.Controls.Add(superGridControl1);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnAddRoom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmRoom";
			this.Text = "frmRoom";
			this.Load += new System.EventHandler(this.frmRoom_Load);
			this.Shown += new System.EventHandler(this.frmRoom_Shown);
			this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnAddRoom;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_STT;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_RoomName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_ComputerCount;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_LastUpdate;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_State;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn_Action;
        private DevComponents.DotNetBar.ButtonX btnReload;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
		private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
		private static DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
	}
}