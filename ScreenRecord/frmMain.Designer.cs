namespace ScreenRecord
{
    partial class frmMain
    {
        /// <summary>
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing">.</param>
        protected override void Dispose(bool disposing)
        {
            //if (_writer.IsOpen)
            //{
            //    _streamVideo.SignalToStop();
            //    _writer.Close();
            //    _writer.Dispose();
            //}
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bt_Save = new System.Windows.Forms.Button();
            this.cb_VideoCodec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_BitRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_FPS = new System.Windows.Forms.NumericUpDown();
            this.tb_SaveFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_stopWatch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_screenSelector = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(248, 126);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(56, 34);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // cb_VideoCodec
            // 
            this.cb_VideoCodec.Enabled = false;
            this.cb_VideoCodec.FormattingEnabled = true;
            this.cb_VideoCodec.Location = new System.Drawing.Point(76, 10);
            this.cb_VideoCodec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VideoCodec.Name = "cb_VideoCodec";
            this.cb_VideoCodec.Size = new System.Drawing.Size(102, 21);
            this.cb_VideoCodec.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VideoCodec:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BitRate:";
            // 
            // cb_BitRate
            // 
            this.cb_BitRate.Enabled = false;
            this.cb_BitRate.FormattingEnabled = true;
            this.cb_BitRate.Location = new System.Drawing.Point(227, 10);
            this.cb_BitRate.Margin = new System.Windows.Forms.Padding(2);
            this.cb_BitRate.Name = "cb_BitRate";
            this.cb_BitRate.Size = new System.Drawing.Size(76, 21);
            this.cb_BitRate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FPS:";
            // 
            // nud_FPS
            // 
            this.nud_FPS.Enabled = false;
            this.nud_FPS.Location = new System.Drawing.Point(227, 34);
            this.nud_FPS.Margin = new System.Windows.Forms.Padding(2);
            this.nud_FPS.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_FPS.Name = "nud_FPS";
            this.nud_FPS.Size = new System.Drawing.Size(75, 20);
            this.nud_FPS.TabIndex = 9;
            this.nud_FPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_SaveFolder
            // 
            this.tb_SaveFolder.Enabled = false;
            this.tb_SaveFolder.Location = new System.Drawing.Point(9, 102);
            this.tb_SaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SaveFolder.Name = "tb_SaveFolder";
            this.tb_SaveFolder.Size = new System.Drawing.Size(295, 20);
            this.tb_SaveFolder.TabIndex = 10;
            this.tb_SaveFolder.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Save in folder:";
            this.label4.Visible = false;
            // 
            // lb_stopWatch
            // 
            this.lb_stopWatch.AutoSize = true;
            this.lb_stopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_stopWatch.Location = new System.Drawing.Point(60, 54);
            this.lb_stopWatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stopWatch.Name = "lb_stopWatch";
            this.lb_stopWatch.Size = new System.Drawing.Size(202, 26);
            this.lb_stopWatch.TabIndex = 13;
            this.lb_stopWatch.Text = "00:00:00.0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Screens:";
            // 
            // cb_screenSelector
            // 
            this.cb_screenSelector.Enabled = false;
            this.cb_screenSelector.FormattingEnabled = true;
            this.cb_screenSelector.Location = new System.Drawing.Point(76, 35);
            this.cb_screenSelector.Margin = new System.Windows.Forms.Padding(2);
            this.cb_screenSelector.Name = "cb_screenSelector";
            this.cb_screenSelector.Size = new System.Drawing.Size(102, 21);
            this.cb_screenSelector.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
           // this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Screen Recorder";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 165);
            this.Controls.Add(this.cb_screenSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_stopWatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SaveFolder);
            this.Controls.Add(this.nud_FPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_BitRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_VideoCodec);
            this.Controls.Add(this.bt_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.ComboBox cb_VideoCodec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_BitRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_FPS;
        private System.Windows.Forms.TextBox tb_SaveFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_stopWatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_screenSelector;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

