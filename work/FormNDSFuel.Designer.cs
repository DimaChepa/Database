namespace work
{
    partial class FormNDSFuel
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OilStationDataSet1 = new work.OilStationDataSet1();
            this.Selling_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Selling_ClientTableAdapter = new work.OilStationDataSet1TableAdapters.Selling_ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OilStationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selling_ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetNDSFuel";
            reportDataSource2.Value = this.Selling_ClientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "work.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1030, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // OilStationDataSet1
            // 
            this.OilStationDataSet1.DataSetName = "OilStationDataSet1";
            this.OilStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Selling_ClientBindingSource
            // 
            this.Selling_ClientBindingSource.DataMember = "Selling_Client";
            this.Selling_ClientBindingSource.DataSource = this.OilStationDataSet1;
            // 
            // Selling_ClientTableAdapter
            // 
            this.Selling_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // FormNDSFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormNDSFuel";
            this.Text = "Отчет по НДС";
            this.Load += new System.EventHandler(this.FormNDSFuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OilStationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Selling_ClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Selling_ClientBindingSource;
        private OilStationDataSet1 OilStationDataSet1;
        private OilStationDataSet1TableAdapters.Selling_ClientTableAdapter Selling_ClientTableAdapter;
    }
}