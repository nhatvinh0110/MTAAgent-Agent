
namespace ManagementCenter.GUI
{
    partial class frmLogReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dETAILLOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoContestantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoContestantDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.logDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailLog = new ManagementCenter.DetailLog();
            this.dETAILLOGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dETAIL_LOGTableAdapter = new ManagementCenter.DetailLogTableAdapters.DETAIL_LOGTableAdapter();
            this.infoContestant = new ManagementCenter.InfoContestant();
            this.infoContestantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.info_ContestantTableAdapter = new ManagementCenter.InfoContestantTableAdapters.Info_ContestantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILLOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILLOGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoContestantBindingSource
            // 
            this.infoContestantBindingSource.DataSource = this.infoContestantDatasetBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDetailLog";
            reportDataSource1.Value = this.dETAILLOGBindingSource1;
            reportDataSource2.Name = "InfoContestant";
            reportDataSource2.Value = this.infoContestantBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ManagementCenter.GUI.LogReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1135, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // detailLog
            // 
            this.detailLog.DataSetName = "DetailLog";
            this.detailLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dETAILLOGBindingSource1
            // 
            this.dETAILLOGBindingSource1.DataMember = "DETAIL_LOG";
            this.dETAILLOGBindingSource1.DataSource = this.detailLog;
            // 
            // dETAIL_LOGTableAdapter
            // 
            this.dETAIL_LOGTableAdapter.ClearBeforeFill = true;
            // 
            // infoContestant
            // 
            this.infoContestant.DataSetName = "InfoContestant";
            this.infoContestant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoContestantBindingSource1
            // 
            this.infoContestantBindingSource1.DataMember = "Info_Contestant";
            this.infoContestantBindingSource1.DataSource = this.infoContestant;
            // 
            // info_ContestantTableAdapter
            // 
            this.info_ContestantTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLogReport";
            this.Text = "frmLogReport";
            this.Load += new System.EventHandler(this.frmLogReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dETAILLOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETAILLOGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoContestantBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource logDatasetBindingSource;
        private System.Windows.Forms.BindingSource dETAILLOGBindingSource;
        private System.Windows.Forms.BindingSource infoContestantDatasetBindingSource;
        private System.Windows.Forms.BindingSource infoContestantBindingSource;
        private DetailLog detailLog;
        private System.Windows.Forms.BindingSource dETAILLOGBindingSource1;
        private DetailLogTableAdapters.DETAIL_LOGTableAdapter dETAIL_LOGTableAdapter;
        private InfoContestant infoContestant;
        private System.Windows.Forms.BindingSource infoContestantBindingSource1;
        private InfoContestantTableAdapters.Info_ContestantTableAdapter info_ContestantTableAdapter;
    }
}