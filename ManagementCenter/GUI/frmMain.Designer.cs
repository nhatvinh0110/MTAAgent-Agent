namespace ManagementCenter
{
    partial class frmMain
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControlMain = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.button_get_videos = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarKetnoi = new DevComponents.DotNetBar.RibbonBar();
            this.btnKetnoiSQL = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCSDL = new DevComponents.DotNetBar.RibbonBar();
            this.btnSaoluuCSDL = new DevComponents.DotNetBar.ButtonItem();
            this.btnKhoiphucCSDL = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnComputerName = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarGiamsat = new DevComponents.DotNetBar.RibbonBar();
            this.btnTrangthai = new DevComponents.DotNetBar.ButtonItem();
            this.btnInternet = new DevComponents.DotNetBar.ButtonItem();
            this.btnEventLog = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarRooms = new DevComponents.DotNetBar.RibbonBar();
            this.btnDanhsachPhong = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem6 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.pnCenter = new DevComponents.DotNetBar.PanelEx();
            this.ribbonControlMain.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControlMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlMain.CanCustomize = false;
            this.ribbonControlMain.CaptionVisible = true;
            this.ribbonControlMain.Controls.Add(this.ribbonPanel3);
            this.ribbonControlMain.Controls.Add(this.ribbonPanel2);
            this.ribbonControlMain.Controls.Add(this.ribbonPanel5);
            this.ribbonControlMain.Controls.Add(this.ribbonPanel1);
            this.ribbonControlMain.Controls.Add(this.ribbonPanel4);
            this.ribbonControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControlMain.ForeColor = System.Drawing.Color.Black;
            this.ribbonControlMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem4,
            this.ribbonTabItem2,
            this.ribbonTabItem3,
            this.ribbonTabItem6});
            this.ribbonControlMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControlMain.Size = new System.Drawing.Size(1171, 168);
            this.ribbonControlMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControlMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControlMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControlMain.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControlMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControlMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControlMain.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControlMain.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControlMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControlMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControlMain.SystemText.QatDialogOkButton = "OK";
            this.ribbonControlMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControlMain.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControlMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControlMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControlMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControlMain.TabGroupHeight = 14;
            this.ribbonControlMain.TabIndex = 0;
            this.ribbonControlMain.Text = "ribbonControlMain";
            this.ribbonControlMain.Resize += new System.EventHandler(this.ribbonControlMain_Resize);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar2);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1171, 112);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 5;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.button_get_videos});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(221, 109);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 3;
            this.ribbonBar2.Text = "Quá trình thi";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::ManagementCenter.Properties.Resources.log_file_1424391_1205037;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.buttonItem1.ImagePaddingHorizontal = 40;
            this.buttonItem1.ImagePaddingVertical = 10;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "Nhật ký log";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // button_get_videos
            // 
            this.button_get_videos.Image = global::ManagementCenter.Properties.Resources.screenshot1;
            this.button_get_videos.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.button_get_videos.ImagePaddingHorizontal = 40;
            this.button_get_videos.ImagePaddingVertical = 10;
            this.button_get_videos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.button_get_videos.Name = "button_get_videos";
            this.button_get_videos.SubItemsExpandWidth = 14;
            this.button_get_videos.Text = "Video giám sát";
            this.button_get_videos.Click += new System.EventHandler(this.button_get_videos_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBarKetnoi);
            this.ribbonPanel2.Controls.Add(this.ribbonBarCSDL);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1171, 112);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBarKetnoi
            // 
            this.ribbonBarKetnoi.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarKetnoi.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarKetnoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarKetnoi.ContainerControlProcessDialogKey = true;
            this.ribbonBarKetnoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarKetnoi.DragDropSupport = true;
            this.ribbonBarKetnoi.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKetnoiSQL});
            this.ribbonBarKetnoi.Location = new System.Drawing.Point(261, 0);
            this.ribbonBarKetnoi.Name = "ribbonBarKetnoi";
            this.ribbonBarKetnoi.Size = new System.Drawing.Size(105, 109);
            this.ribbonBarKetnoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarKetnoi.TabIndex = 1;
            this.ribbonBarKetnoi.Text = "Kết nối";
            // 
            // 
            // 
            this.ribbonBarKetnoi.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarKetnoi.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnKetnoiSQL
            // 
            this.btnKetnoiSQL.Image = global::ManagementCenter.Properties.Resources.network_database_512;
            this.btnKetnoiSQL.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnKetnoiSQL.ImagePaddingHorizontal = 0;
            this.btnKetnoiSQL.ImagePaddingVertical = 10;
            this.btnKetnoiSQL.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKetnoiSQL.Name = "btnKetnoiSQL";
            this.btnKetnoiSQL.SubItemsExpandWidth = 14;
            this.btnKetnoiSQL.Text = "Kết nối máy chủ MS SQL";
            this.btnKetnoiSQL.Click += new System.EventHandler(this.btnKetnoiSQL_Click);
            // 
            // ribbonBarCSDL
            // 
            this.ribbonBarCSDL.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCSDL.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarCSDL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarCSDL.ContainerControlProcessDialogKey = true;
            this.ribbonBarCSDL.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCSDL.DragDropSupport = true;
            this.ribbonBarCSDL.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaoluuCSDL,
            this.btnKhoiphucCSDL});
            this.ribbonBarCSDL.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarCSDL.Name = "ribbonBarCSDL";
            this.ribbonBarCSDL.Size = new System.Drawing.Size(258, 109);
            this.ribbonBarCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCSDL.TabIndex = 0;
            this.ribbonBarCSDL.Text = "Cơ sở dữ liệu";
            // 
            // 
            // 
            this.ribbonBarCSDL.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarCSDL.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSaoluuCSDL
            // 
            this.btnSaoluuCSDL.Image = global::ManagementCenter.Properties.Resources.server_database_data_store_backup_2_512;
            this.btnSaoluuCSDL.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnSaoluuCSDL.ImagePaddingHorizontal = 70;
            this.btnSaoluuCSDL.ImagePaddingVertical = 10;
            this.btnSaoluuCSDL.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaoluuCSDL.Name = "btnSaoluuCSDL";
            this.btnSaoluuCSDL.SubItemsExpandWidth = 14;
            this.btnSaoluuCSDL.Text = "Sao lưu CSDL";
            this.btnSaoluuCSDL.Click += new System.EventHandler(this.btnSaoluuCSDL_Click);
            // 
            // btnKhoiphucCSDL
            // 
            this.btnKhoiphucCSDL.Image = global::ManagementCenter.Properties.Resources.baru_81_512;
            this.btnKhoiphucCSDL.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnKhoiphucCSDL.ImagePaddingHorizontal = 70;
            this.btnKhoiphucCSDL.ImagePaddingVertical = 10;
            this.btnKhoiphucCSDL.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKhoiphucCSDL.Name = "btnKhoiphucCSDL";
            this.btnKhoiphucCSDL.SubItemsExpandWidth = 14;
            this.btnKhoiphucCSDL.Text = "Khôi phục CSDL";
            this.btnKhoiphucCSDL.Click += new System.EventHandler(this.btnKhoiphucCSDL_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(1171, 112);
            // 
            // 
            // 
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 6;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Controls.Add(this.ribbonBarGiamsat);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1171, 112);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnComputerName});
            this.ribbonBar1.Location = new System.Drawing.Point(366, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(132, 109);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Chính sách";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnComputerName
            // 
            this.btnComputerName.Image = global::ManagementCenter.Properties.Resources.policy_icon;
            this.btnComputerName.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnComputerName.ImagePaddingHorizontal = 70;
            this.btnComputerName.ImagePaddingVertical = 10;
            this.btnComputerName.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnComputerName.Name = "btnComputerName";
            this.btnComputerName.SubItemsExpandWidth = 14;
            this.btnComputerName.Text = "Kiểm tra đặt tên máy";
            this.btnComputerName.Click += new System.EventHandler(this.btnComputerName_Click);
            // 
            // ribbonBarGiamsat
            // 
            this.ribbonBarGiamsat.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarGiamsat.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarGiamsat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarGiamsat.ContainerControlProcessDialogKey = true;
            this.ribbonBarGiamsat.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarGiamsat.DragDropSupport = true;
            this.ribbonBarGiamsat.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTrangthai,
            this.btnInternet,
            this.btnEventLog});
            this.ribbonBarGiamsat.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarGiamsat.Name = "ribbonBarGiamsat";
            this.ribbonBarGiamsat.Size = new System.Drawing.Size(363, 109);
            this.ribbonBarGiamsat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarGiamsat.TabIndex = 0;
            this.ribbonBarGiamsat.Text = "Giám sát";
            // 
            // 
            // 
            this.ribbonBarGiamsat.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarGiamsat.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnTrangthai
            // 
            this.btnTrangthai.Image = global::ManagementCenter.Properties.Resources.iStar_Design_Medicine_LineIcons_Live_100_512;
            this.btnTrangthai.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnTrangthai.ImagePaddingHorizontal = 70;
            this.btnTrangthai.ImagePaddingVertical = 10;
            this.btnTrangthai.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTrangthai.Name = "btnTrangthai";
            this.btnTrangthai.SubItemsExpandWidth = 14;
            this.btnTrangthai.Text = "Giám sát trạng thái";
            this.btnTrangthai.Click += new System.EventHandler(this.btnTrangthai_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Image = global::ManagementCenter.Properties.Resources.network_connection_1446136_1222725;
            this.btnInternet.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnInternet.ImagePaddingHorizontal = 70;
            this.btnInternet.ImagePaddingVertical = 10;
            this.btnInternet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.SubItemsExpandWidth = 14;
            this.btnInternet.Text = "Giám sát Internet";
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnEventLog
            // 
            this.btnEventLog.Image = global::ManagementCenter.Properties.Resources.log_file_1424391_1205037;
            this.btnEventLog.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnEventLog.ImagePaddingHorizontal = 40;
            this.btnEventLog.ImagePaddingVertical = 10;
            this.btnEventLog.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEventLog.Name = "btnEventLog";
            this.btnEventLog.SubItemsExpandWidth = 14;
            this.btnEventLog.Text = "Nhật ký sự kiện";
            this.btnEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBarRooms);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1171, 112);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBarRooms
            // 
            this.ribbonBarRooms.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarRooms.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarRooms.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarRooms.ContainerControlProcessDialogKey = true;
            this.ribbonBarRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarRooms.DragDropSupport = true;
            this.ribbonBarRooms.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDanhsachPhong});
            this.ribbonBarRooms.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarRooms.Name = "ribbonBarRooms";
            this.ribbonBarRooms.Size = new System.Drawing.Size(124, 109);
            this.ribbonBarRooms.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarRooms.TabIndex = 0;
            this.ribbonBarRooms.Text = "Phòng thi";
            // 
            // 
            // 
            this.ribbonBarRooms.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarRooms.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDanhsachPhong
            // 
            this.btnDanhsachPhong.Image = global::ManagementCenter.Properties.Resources.classroom_60_646766;
            this.btnDanhsachPhong.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnDanhsachPhong.ImagePaddingHorizontal = 50;
            this.btnDanhsachPhong.ImagePaddingVertical = 10;
            this.btnDanhsachPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhsachPhong.Name = "btnDanhsachPhong";
            this.btnDanhsachPhong.SubItemsExpandWidth = 14;
            this.btnDanhsachPhong.Text = "Danh sách phòng thi";
            this.btnDanhsachPhong.Click += new System.EventHandler(this.btnDanhsachPhong_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Quản trị máy trạm";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "Quản trị phòng thi";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Quản trị hệ thống";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Checked = true;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "Thông tin thi";
            // 
            // ribbonTabItem6
            // 
            this.ribbonTabItem6.Name = "ribbonTabItem6";
            this.ribbonTabItem6.Panel = this.ribbonPanel5;
            this.ribbonTabItem6.Text = "Trợ giúp";
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Text = "Trợ giúp";
            // 
            // pnCenter
            // 
            this.pnCenter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnCenter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnCenter.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 168);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1171, 583);
            this.pnCenter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnCenter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnCenter.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnCenter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnCenter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnCenter.Style.GradientAngle = 90;
            this.pnCenter.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 751);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.ribbonControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình giám sát phòng máy";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ribbonControlMain.ResumeLayout(false);
            this.ribbonControlMain.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonControl ribbonControlMain;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBarGiamsat;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonItem btnTrangthai;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCSDL;
        private DevComponents.DotNetBar.ButtonItem btnInternet;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.ButtonItem btnSaoluuCSDL;
        private DevComponents.DotNetBar.ButtonItem btnKhoiphucCSDL;
        private DevComponents.DotNetBar.RibbonBar ribbonBarKetnoi;
        private DevComponents.DotNetBar.ButtonItem btnKetnoiSQL;
        private DevComponents.DotNetBar.PanelEx pnCenter;
        private DevComponents.DotNetBar.RibbonBar ribbonBarRooms;
        private DevComponents.DotNetBar.ButtonItem btnDanhsachPhong;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnComputerName;
        private DevComponents.DotNetBar.ButtonItem btnEventLog;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem6;
        private DevComponents.DotNetBar.ButtonItem button_get_videos;
    }
}

