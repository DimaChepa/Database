namespace work
{
    partial class FormSellFuel
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
            this.btnSell = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbBoxNameFuel = new System.Windows.Forms.ComboBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtPrice_for_litr = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dateTimeSelling = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(332, 479);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(128, 39);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Продать";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(685, 481);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 37);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbBoxNameFuel
            // 
            this.cmbBoxNameFuel.FormattingEnabled = true;
            this.cmbBoxNameFuel.Location = new System.Drawing.Point(332, 41);
            this.cmbBoxNameFuel.Name = "cmbBoxNameFuel";
            this.cmbBoxNameFuel.Size = new System.Drawing.Size(128, 21);
            this.cmbBoxNameFuel.TabIndex = 2;
            this.cmbBoxNameFuel.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameFuel_SelectedIndexChanged);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(332, 92);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(128, 20);
            this.txtVolume.TabIndex = 3;
            // 
            // txtPrice_for_litr
            // 
            this.txtPrice_for_litr.Location = new System.Drawing.Point(332, 141);
            this.txtPrice_for_litr.Name = "txtPrice_for_litr";
            this.txtPrice_for_litr.Size = new System.Drawing.Size(128, 20);
            this.txtPrice_for_litr.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(332, 201);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(128, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // dateTimeSelling
            // 
            this.dateTimeSelling.CustomFormat = "dd-MM-yyyy";
            this.dateTimeSelling.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSelling.Location = new System.Drawing.Point(332, 255);
            this.dateTimeSelling.Name = "dateTimeSelling";
            this.dateTimeSelling.Size = new System.Drawing.Size(128, 20);
            this.dateTimeSelling.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название бензина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата продажи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Продавец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(65, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Объем";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(65, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цена за литр";
            // 
            // FormSellFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeSelling);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPrice_for_litr);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.cmbBoxNameFuel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSell);
            this.Name = "FormSellFuel";
            this.Text = "FormSellFuel";
            this.Load += new System.EventHandler(this.FormSellFuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbBoxNameFuel;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPrice_for_litr;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dateTimeSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}