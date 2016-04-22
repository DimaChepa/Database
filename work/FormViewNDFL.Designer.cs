namespace work
{
    partial class FormViewNDFL
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
            this.DataSetTax = new work.DataSetTax();
            this.SalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalarTableAdapter = new work.DataSetTaxTableAdapters.SalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "work.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1150, 626);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTax
            // 
            this.DataSetTax.DataSetName = "DataSetTax";
            this.DataSetTax.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalarBindingSource
            // 
            this.SalarBindingSource.DataMember = "Salar";
            this.SalarBindingSource.DataSource = this.DataSetTax;
            // 
            // SalarTableAdapter
            // 
            this.SalarTableAdapter.ClearBeforeFill = true;
            // 
            // FormViewNDFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormViewNDFL";
            this.Text = "FormViewNDFL";
            this.Load += new System.EventHandler(this.FormViewNDFL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalarBindingSource;
        private DataSetTax DataSetTax;
        private DataSetTaxTableAdapters.SalarTableAdapter SalarTableAdapter;
    }
}