
namespace ManagementCenter.GUI
{
    partial class fr_getvideos
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
            this.textBox_contents = new System.Windows.Forms.TextBox();
            this.button_getVideos = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.filePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.button_stop = new System.Windows.Forms.Button();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.button_setting = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBox_contents
            // 
            this.textBox_contents.Location = new System.Drawing.Point(31, 77);
            this.textBox_contents.Multiline = true;
            this.textBox_contents.Name = "textBox_contents";
            this.textBox_contents.ReadOnly = true;
            this.textBox_contents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_contents.Size = new System.Drawing.Size(1099, 438);
            this.textBox_contents.TabIndex = 25;
            // 
            // button_getVideos
            // 
            this.button_getVideos.Location = new System.Drawing.Point(832, 30);
            this.button_getVideos.Margin = new System.Windows.Forms.Padding(2);
            this.button_getVideos.Name = "button_getVideos";
            this.button_getVideos.Size = new System.Drawing.Size(89, 21);
            this.button_getVideos.TabIndex = 24;
            this.button_getVideos.Text = "Nhận video";
            this.button_getVideos.UseVisualStyleBackColor = true;
            this.button_getVideos.Click += new System.EventHandler(this.button_getVideos_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(934, 30);
            this.buttonMerge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(79, 21);
            this.buttonMerge.TabIndex = 23;
            this.buttonMerge.Text = "Ghép video";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // filePath
            // 
            // 
            // 
            // 
            this.filePath.Border.Class = "TextBoxBorder";
            this.filePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filePath.Location = new System.Drawing.Point(185, 30);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.PreventEnterBeep = true;
            this.filePath.Size = new System.Drawing.Size(540, 21);
            this.filePath.TabIndex = 22;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.ImageTextSpacing = 5;
            this.buttonX2.Location = new System.Drawing.Point(731, 30);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(79, 21);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 13F;
            this.buttonX2.TabIndex = 21;
            this.buttonX2.Text = "Chọn";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(1061, 541);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 26;
            this.button_stop.Text = "Dừng lại";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(66, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(113, 20);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Thư mục lưu video: ";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // button_setting
            // 
            this.button_setting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_setting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_setting.ImageTextSpacing = 5;
            this.button_setting.Location = new System.Drawing.Point(1102, 28);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(33, 25);
            this.button_setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_setting.Symbol = "";
            this.button_setting.SymbolSize = 13F;
            this.button_setting.TabIndex = 28;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // fr_getvideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 583);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.textBox_contents);
            this.Controls.Add(this.button_getVideos);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fr_getvideos";
            this.Text = "fr_getvideos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_contents;
        private System.Windows.Forms.Button button_getVideos;
        private System.Windows.Forms.Button buttonMerge;
        private DevComponents.DotNetBar.Controls.TextBoxX filePath;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Button button_stop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX button_setting;
    }
}