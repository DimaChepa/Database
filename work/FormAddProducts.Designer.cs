namespace work
{
    partial class FormAddProducts
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
            this.cmbboxName = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalendarSell = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbboxName
            // 
            this.cmbboxName.FormattingEnabled = true;
            this.cmbboxName.Location = new System.Drawing.Point(386, 42);
            this.cmbboxName.Name = "cmbboxName";
            this.cmbboxName.Size = new System.Drawing.Size(100, 21);
            this.cmbboxName.TabIndex = 0;
            this.cmbboxName.SelectedIndexChanged += new System.EventHandler(this.cmbboxName_SelectedIndexChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(386, 85);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(99, 20);
            this.txtCustomer.TabIndex = 3;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(386, 139);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(99, 20);
            this.txtCount.TabIndex = 4;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(384, 349);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(100, 35);
            this.btnSell.TabIndex = 5;
            this.btnSell.Text = "Продать";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(386, 184);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(222, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(222, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(222, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена";
            // 
            // CalendarSell
            // 
            this.CalendarSell.CustomFormat = "dd-MM-yyyy";
            this.CalendarSell.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CalendarSell.Location = new System.Drawing.Point(388, 237);
            this.CalendarSell.Name = "CalendarSell";
            this.CalendarSell.Size = new System.Drawing.Size(96, 20);
            this.CalendarSell.TabIndex = 11;
            this.CalendarSell.ValueChanged += new System.EventHandler(this.CalendarSell_ValueChanged);
            // 
            // FormAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 453);
            this.Controls.Add(this.CalendarSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.cmbboxName);
            this.Name = "FormAddProducts";
            this.Text = "FormAddProducts";
            this.Load += new System.EventHandler(this.FormAddProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CalendarSell;
    }
}