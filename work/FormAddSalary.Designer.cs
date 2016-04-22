namespace work
{
    partial class FormAddSalary
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
            this.dataGridGetWorker = new System.Windows.Forms.DataGridView();
            this.btnGetWorker = new System.Windows.Forms.Button();
            this.cmbBoxCode = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWork_hour = new System.Windows.Forms.TextBox();
            this.txtHour_pay = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SalarCalendar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGetWorker
            // 
            this.dataGridGetWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGetWorker.Location = new System.Drawing.Point(514, 104);
            this.dataGridGetWorker.Name = "dataGridGetWorker";
            this.dataGridGetWorker.Size = new System.Drawing.Size(416, 312);
            this.dataGridGetWorker.TabIndex = 0;
            this.dataGridGetWorker.Visible = false;
            // 
            // btnGetWorker
            // 
            this.btnGetWorker.Location = new System.Drawing.Point(828, 26);
            this.btnGetWorker.Name = "btnGetWorker";
            this.btnGetWorker.Size = new System.Drawing.Size(101, 48);
            this.btnGetWorker.TabIndex = 1;
            this.btnGetWorker.Text = "Получить список сотрудников";
            this.btnGetWorker.UseVisualStyleBackColor = true;
            this.btnGetWorker.Click += new System.EventHandler(this.btnGetWorker_Click);
            // 
            // cmbBoxCode
            // 
            this.cmbBoxCode.FormattingEnabled = true;
            this.cmbBoxCode.Location = new System.Drawing.Point(299, 53);
            this.cmbBoxCode.Name = "cmbBoxCode";
            this.cmbBoxCode.Size = new System.Drawing.Size(118, 21);
            this.cmbBoxCode.TabIndex = 2;
            this.cmbBoxCode.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCode_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(299, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtWork_hour
            // 
            this.txtWork_hour.Location = new System.Drawing.Point(300, 164);
            this.txtWork_hour.Name = "txtWork_hour";
            this.txtWork_hour.Size = new System.Drawing.Size(117, 20);
            this.txtWork_hour.TabIndex = 4;
            this.txtWork_hour.TextChanged += new System.EventHandler(this.txtWork_hour_TextChanged);
            // 
            // txtHour_pay
            // 
            this.txtHour_pay.Enabled = false;
            this.txtHour_pay.Location = new System.Drawing.Point(299, 228);
            this.txtHour_pay.Name = "txtHour_pay";
            this.txtHour_pay.Size = new System.Drawing.Size(118, 20);
            this.txtHour_pay.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(299, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(118, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(299, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Начислить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalarCalendar
            // 
            this.SalarCalendar.CustomFormat = "dd-MM-yyyy";
            this.SalarCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SalarCalendar.Location = new System.Drawing.Point(300, 346);
            this.SalarCalendar.MinDate = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.SalarCalendar.Name = "SalarCalendar";
            this.SalarCalendar.Size = new System.Drawing.Size(117, 20);
            this.SalarCalendar.TabIndex = 8;
            this.SalarCalendar.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Число отработаных часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Почасовой тариф";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выдача";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Период";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(300, 496);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(116, 37);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormAddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 559);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalarCalendar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtHour_pay);
            this.Controls.Add(this.txtWork_hour);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbBoxCode);
            this.Controls.Add(this.btnGetWorker);
            this.Controls.Add(this.dataGridGetWorker);
            this.Name = "FormAddSalary";
            this.Text = "FormAddSalary";
            this.Load += new System.EventHandler(this.FormAddSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGetWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGetWorker;
        private System.Windows.Forms.Button btnGetWorker;
        private System.Windows.Forms.ComboBox cmbBoxCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWork_hour;
        private System.Windows.Forms.TextBox txtHour_pay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker SalarCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReturn;
    }
}