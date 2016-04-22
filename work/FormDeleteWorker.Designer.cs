namespace work
{
    partial class FormDeleteWorker
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 37);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Уволить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(304, 247);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 26);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(304, 63);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(106, 20);
            this.txtDelete.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите код, сотрудника, который надо удалить";
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Location = new System.Drawing.Point(491, 63);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.Size = new System.Drawing.Size(340, 330);
            this.dataGridViewWorker.TabIndex = 4;
            // 
            // FormDeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 458);
            this.Controls.Add(this.dataGridViewWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Name = "FormDeleteWorker";
            this.Text = "FormDeleteWorker";
            this.Load += new System.EventHandler(this.FormDeleteWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
    }
}