namespace work
{
    partial class FormExpert
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
            this.btnAddThing = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddThing
            // 
            this.btnAddThing.Location = new System.Drawing.Point(68, 40);
            this.btnAddThing.Name = "btnAddThing";
            this.btnAddThing.Size = new System.Drawing.Size(129, 45);
            this.btnAddThing.TabIndex = 0;
            this.btnAddThing.Text = "Добавить оборудование";
            this.btnAddThing.UseVisualStyleBackColor = true;
            this.btnAddThing.Click += new System.EventHandler(this.btnAddThing_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(272, 40);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Сменить поользователя";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(68, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Посмотреть оборудование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddThing);
            this.Name = "FormExpert";
            this.Text = "Инспекция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddThing;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
    }
}