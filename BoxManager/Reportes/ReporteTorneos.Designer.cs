namespace BoxManager.Reportes
{
    partial class ReporteTorneos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.boxManagerDBDataSetReportePeleasID = new BoxManager.BoxManagerDBDataSetReportePeleasID();
            this.reportePeleasPorTorneoIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportePeleasPorTorneoIDTableAdapter = new BoxManager.BoxManagerDBDataSetReportePeleasIDTableAdapters.reportePeleasPorTorneoIDTableAdapter();
            this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxManagerDBDataSetPeleasPorTorneoID = new BoxManager.BoxManagerDBDataSetPeleasPorTorneoID();
            this.reportePeleasPorTorneoIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportePeleasPorTorneoIDBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportePeleasPorTorneoIDTableAdapter1 = new BoxManager.BoxManagerDBDataSetPeleasPorTorneoIDTableAdapters.reportePeleasPorTorneoIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetReportePeleasID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetPeleasPorTorneoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPRO";
            reportDataSource1.Value = this.reportePeleasPorTorneoIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BoxManager.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(706, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // boxManagerDBDataSetReportePeleasID
            // 
            this.boxManagerDBDataSetReportePeleasID.DataSetName = "BoxManagerDBDataSetReportePeleasID";
            this.boxManagerDBDataSetReportePeleasID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportePeleasPorTorneoIDBindingSource1
            // 
            this.reportePeleasPorTorneoIDBindingSource1.DataMember = "reportePeleasPorTorneoID";
            this.reportePeleasPorTorneoIDBindingSource1.DataSource = this.boxManagerDBDataSetReportePeleasID;
            // 
            // reportePeleasPorTorneoIDTableAdapter
            // 
            this.reportePeleasPorTorneoIDTableAdapter.ClearBeforeFill = true;
            // 
            // boxManagerDBDataSetPeleasPorTorneoIDBindingSource
            // 
            this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource.DataSource = this.boxManagerDBDataSetPeleasPorTorneoID;
            this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource.Position = 0;
            // 
            // boxManagerDBDataSetPeleasPorTorneoID
            // 
            this.boxManagerDBDataSetPeleasPorTorneoID.DataSetName = "BoxManagerDBDataSetPeleasPorTorneoID";
            this.boxManagerDBDataSetPeleasPorTorneoID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportePeleasPorTorneoIDBindingSource
            // 
            this.reportePeleasPorTorneoIDBindingSource.DataMember = "reportePeleasPorTorneoID";
            this.reportePeleasPorTorneoIDBindingSource.DataSource = this.boxManagerDBDataSetPeleasPorTorneoID;
            // 
            // reportePeleasPorTorneoIDBindingSource2
            // 
            this.reportePeleasPorTorneoIDBindingSource2.DataMember = "reportePeleasPorTorneoID";
            this.reportePeleasPorTorneoIDBindingSource2.DataSource = this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource;
            // 
            // reportePeleasPorTorneoIDTableAdapter1
            // 
            this.reportePeleasPorTorneoIDTableAdapter1.ClearBeforeFill = true;
            // 
            // ReporteTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 503);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteTorneos";
            this.Text = "ReporteTorneos";
            this.Load += new System.EventHandler(this.ReporteTorneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetReportePeleasID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetPeleasPorTorneoIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxManagerDBDataSetPeleasPorTorneoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportePeleasPorTorneoIDBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource boxManagerDBDataSetPeleasPorTorneoIDBindingSource;
        private BoxManagerDBDataSetPeleasPorTorneoID boxManagerDBDataSetPeleasPorTorneoID;
        private System.Windows.Forms.BindingSource reportePeleasPorTorneoIDBindingSource;
        private BoxManagerDBDataSetReportePeleasID boxManagerDBDataSetReportePeleasID;
        private System.Windows.Forms.BindingSource reportePeleasPorTorneoIDBindingSource1;
        private BoxManagerDBDataSetReportePeleasIDTableAdapters.reportePeleasPorTorneoIDTableAdapter reportePeleasPorTorneoIDTableAdapter;
        private System.Windows.Forms.BindingSource reportePeleasPorTorneoIDBindingSource2;
        private BoxManagerDBDataSetPeleasPorTorneoIDTableAdapters.reportePeleasPorTorneoIDTableAdapter reportePeleasPorTorneoIDTableAdapter1;
    }
}