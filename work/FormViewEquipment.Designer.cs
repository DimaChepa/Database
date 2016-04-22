namespace work
{
    partial class FormViewEquipment
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
            this.OilStationDataSet = new work.OilStationDataSet();
            this.EquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EquipmentTableAdapter = new work.OilStationDataSetTableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OilStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEqup";
            reportDataSource1.Value = this.EquipmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "work.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(702, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // OilStationDataSet
            // 
            this.OilStationDataSet.DataSetName = "OilStationDataSet";
            this.OilStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EquipmentBindingSource
            // 
            this.EquipmentBindingSource.DataMember = "Equipment";
            this.EquipmentBindingSource.DataSource = this.OilStationDataSet;
            // 
            // EquipmentTableAdapter
            // 
            this.EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // FormViewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormViewEquipment";
            this.Text = "FormViewEquipment";
            this.Load += new System.EventHandler(this.FormViewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OilStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EquipmentBindingSource;
        private OilStationDataSet OilStationDataSet;
        private OilStationDataSetTableAdapters.EquipmentTableAdapter EquipmentTableAdapter;
    }
}