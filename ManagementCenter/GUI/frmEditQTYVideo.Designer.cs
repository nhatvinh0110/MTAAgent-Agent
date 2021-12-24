
namespace ManagementCenter.GUI
{
    partial class frmEditQTYVideo
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
            this.button_canel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_video = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_video)).BeginInit();
            this.SuspendLayout();
            // 
            // button_canel
            // 
            this.button_canel.Location = new System.Drawing.Point(30, 122);
            this.button_canel.Name = "button_canel";
            this.button_canel.Size = new System.Drawing.Size(75, 23);
            this.button_canel.TabIndex = 0;
            this.button_canel.Text = "Hủy";
            this.button_canel.UseVisualStyleBackColor = true;
            this.button_canel.Click += new System.EventHandler(this.button_canel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(163, 122);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng video tối đa";
            // 
            // numericUpDown_video
            // 
            this.numericUpDown_video.Location = new System.Drawing.Point(163, 40);
            this.numericUpDown_video.Name = "numericUpDown_video";
            this.numericUpDown_video.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_video.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 168);
            this.panel1.TabIndex = 4;
            // 
            // frmEditQTYVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 168);
            this.Controls.Add(this.numericUpDown_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_canel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditQTYVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.Load += new System.EventHandler(this.frmEditQTYVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_canel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_video;
        private System.Windows.Forms.Panel panel1;
    }
}