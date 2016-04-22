namespace work
{
    partial class FormViewProduct
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
            this.StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetProduct = new work.DataSetProduct();
            this.StockTableAdapter = new work.DataSetProductTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "work.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1022, 468);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // StockBindingSource
            // 
            this.StockBindingSource.DataMember = "Stock";
            this.StockBindingSource.DataSource = this.DataSetProduct;
            // 
            // DataSetProduct
            // 
            this.DataSetProduct.DataSetName = "DataSetProduct";
            this.DataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StockTableAdapter
            // 
            this.StockTableAdapter.ClearBeforeFill = true;
            // 
            // FormViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormViewProduct";
            this.Text = "FormViewProduct";
            this.Load += new System.EventHandler(this.FormViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StockBindingSource;
        private DataSetProduct DataSetProduct;
        private DataSetProductTableAdapters.StockTableAdapter StockTableAdapter;
    }
}