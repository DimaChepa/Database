namespace work
{
    partial class FormJournal
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
            this.DataSetViewJournal = new work.DataSetViewJournal();
            this.JournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JournalTableAdapter = new work.DataSetViewJournalTableAdapters.JournalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetViewJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetViewJournal";
            reportDataSource1.Value = this.JournalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "work.ReportViewJornal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(881, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetViewJournal
            // 
            this.DataSetViewJournal.DataSetName = "DataSetViewJournal";
            this.DataSetViewJournal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JournalBindingSource
            // 
            this.JournalBindingSource.DataMember = "Journal";
            this.JournalBindingSource.DataSource = this.DataSetViewJournal;
            // 
            // JournalTableAdapter
            // 
            this.JournalTableAdapter.ClearBeforeFill = true;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 488);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormJournal";
            this.Text = "FormJournal";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetViewJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JournalBindingSource;
        private DataSetViewJournal DataSetViewJournal;
        private DataSetViewJournalTableAdapters.JournalTableAdapter JournalTableAdapter;
    }
}