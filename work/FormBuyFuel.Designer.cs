namespace work
{
    partial class FormBuyFuel
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.cmbBoxNameProvider = new System.Windows.Forms.ComboBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtPrice_litr = new System.Windows.Forms.TextBox();
            this.txtNameFuel = new System.Windows.Forms.TextBox();
            this.Buy_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(809, 531);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 44);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(330, 520);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(129, 44);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cmbBoxNameProvider
            // 
            this.cmbBoxNameProvider.FormattingEnabled = true;
            this.cmbBoxNameProvider.Location = new System.Drawing.Point(330, 35);
            this.cmbBoxNameProvider.Name = "cmbBoxNameProvider";
            this.cmbBoxNameProvider.Size = new System.Drawing.Size(129, 21);
            this.cmbBoxNameProvider.TabIndex = 2;
            this.cmbBoxNameProvider.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameProvider_SelectedIndexChanged);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(330, 94);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(129, 20);
            this.txtVolume.TabIndex = 3;
            // 
            // txtPrice_litr
            // 
            this.txtPrice_litr.Location = new System.Drawing.Point(330, 147);
            this.txtPrice_litr.Name = "txtPrice_litr";
            this.txtPrice_litr.Size = new System.Drawing.Size(129, 20);
            this.txtPrice_litr.TabIndex = 4;
            // 
            // txtNameFuel
            // 
            this.txtNameFuel.Location = new System.Drawing.Point(330, 333);
            this.txtNameFuel.Name = "txtNameFuel";
            this.txtNameFuel.Size = new System.Drawing.Size(129, 20);
            this.txtNameFuel.TabIndex = 6;
            // 
            // Buy_Date
            // 
            this.Buy_Date.CustomFormat = "dd-MM-yyyy";
            this.Buy_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Buy_Date.Location = new System.Drawing.Point(330, 223);
            this.Buy_Date.Name = "Buy_Date";
            this.Buy_Date.Size = new System.Drawing.Size(129, 20);
            this.Buy_Date.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Объем";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена за литр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата покупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Наименование бензина";
            // 
            // FormBuyFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buy_Date);
            this.Controls.Add(this.txtNameFuel);
            this.Controls.Add(this.txtPrice_litr);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.cmbBoxNameProvider);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnReturn);
            this.Name = "FormBuyFuel";
            this.Text = "FormBuyFuel";
            this.Load += new System.EventHandler(this.FormBuyFuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox cmbBoxNameProvider;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPrice_litr;
        private System.Windows.Forms.TextBox txtNameFuel;
        private System.Windows.Forms.DateTimePicker Buy_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}