namespace work
{
    partial class FormAddEmploy
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddLogin = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddSecond = new System.Windows.Forms.TextBox();
            this.txtAddStatus = new System.Windows.Forms.TextBox();
            this.cmbBoxAddPos = new System.Windows.Forms.ComboBox();
            this.txtAddPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(291, 426);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(118, 40);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Добавить";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(498, 426);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 40);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(118, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(118, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(118, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(118, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(118, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Права";
            // 
            // txtAddLogin
            // 
            this.txtAddLogin.Location = new System.Drawing.Point(291, 55);
            this.txtAddLogin.Name = "txtAddLogin";
            this.txtAddLogin.Size = new System.Drawing.Size(118, 20);
            this.txtAddLogin.TabIndex = 10;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(291, 95);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(118, 20);
            this.txtAddPassword.TabIndex = 11;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(291, 136);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(118, 20);
            this.txtAddSurname.TabIndex = 12;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(291, 180);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(118, 20);
            this.txtAddName.TabIndex = 13;
            // 
            // txtAddSecond
            // 
            this.txtAddSecond.Location = new System.Drawing.Point(291, 233);
            this.txtAddSecond.Name = "txtAddSecond";
            this.txtAddSecond.Size = new System.Drawing.Size(118, 20);
            this.txtAddSecond.TabIndex = 14;
            // 
            // txtAddStatus
            // 
            this.txtAddStatus.Location = new System.Drawing.Point(291, 362);
            this.txtAddStatus.Name = "txtAddStatus";
            this.txtAddStatus.Size = new System.Drawing.Size(118, 20);
            this.txtAddStatus.TabIndex = 17;
            // 
            // cmbBoxAddPos
            // 
            this.cmbBoxAddPos.FormattingEnabled = true;
            this.cmbBoxAddPos.Location = new System.Drawing.Point(291, 310);
            this.cmbBoxAddPos.Name = "cmbBoxAddPos";
            this.cmbBoxAddPos.Size = new System.Drawing.Size(118, 21);
            this.cmbBoxAddPos.TabIndex = 18;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(291, 269);
            this.txtAddPhone.Mask = "(999) 000-00-00";
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(118, 20);
            this.txtAddPhone.TabIndex = 19;
            // 
            // FormAddEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 530);
            this.Controls.Add(this.txtAddPhone);
            this.Controls.Add(this.cmbBoxAddPos);
            this.Controls.Add(this.txtAddStatus);
            this.Controls.Add(this.txtAddSecond);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.txtAddSurname);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddEmp);
            this.Name = "FormAddEmploy";
            this.Text = "FormAddEmploy";
            this.Load += new System.EventHandler(this.FormAddEmploy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddLogin;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddSecond;
        private System.Windows.Forms.TextBox txtAddStatus;
        private System.Windows.Forms.ComboBox cmbBoxAddPos;
        private System.Windows.Forms.MaskedTextBox txtAddPhone;
    }
}