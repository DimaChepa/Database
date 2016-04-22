namespace work
{
    partial class FormAddNewPosition
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
            this.brnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddPosition = new System.Windows.Forms.TextBox();
            this.txtAddPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnAdd
            // 
            this.brnAdd.Location = new System.Drawing.Point(404, 187);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(120, 40);
            this.brnAdd.TabIndex = 0;
            this.brnAdd.Text = "Добавить";
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(358, 342);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 40);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Назад";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почасовая оплата(без вычета налогов)";
            // 
            // txtAddPosition
            // 
            this.txtAddPosition.Location = new System.Drawing.Point(404, 91);
            this.txtAddPosition.Name = "txtAddPosition";
            this.txtAddPosition.Size = new System.Drawing.Size(120, 20);
            this.txtAddPosition.TabIndex = 4;
            // 
            // txtAddPay
            // 
            this.txtAddPay.Location = new System.Drawing.Point(404, 132);
            this.txtAddPay.Name = "txtAddPay";
            this.txtAddPay.Size = new System.Drawing.Size(120, 20);
            this.txtAddPay.TabIndex = 5;
            // 
            // FormAddNewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 441);
            this.Controls.Add(this.txtAddPay);
            this.Controls.Add(this.txtAddPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.brnAdd);
            this.Name = "FormAddNewPosition";
            this.Text = "Добавить вакансию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPosition;
        private System.Windows.Forms.TextBox txtAddPay;
    }
}