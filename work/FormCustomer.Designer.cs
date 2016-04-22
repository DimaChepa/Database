namespace work
{
    partial class FormCustomer
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
            this.menuCustomer = new System.Windows.Forms.MenuStrip();
            this.продатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бензинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остатокТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закупитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCustomer
            // 
            this.menuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продатьToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.закупитьToolStripMenuItem});
            this.menuCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(947, 24);
            this.menuCustomer.TabIndex = 0;
            this.menuCustomer.Text = "menuStrip1";
            // 
            // продатьToolStripMenuItem
            // 
            this.продатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бензинToolStripMenuItem,
            this.товарToolStripMenuItem});
            this.продатьToolStripMenuItem.Name = "продатьToolStripMenuItem";
            this.продатьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.продатьToolStripMenuItem.Text = "Продать";
            this.продатьToolStripMenuItem.Click += new System.EventHandler(this.продатьToolStripMenuItem_Click);
            // 
            // бензинToolStripMenuItem
            // 
            this.бензинToolStripMenuItem.Name = "бензинToolStripMenuItem";
            this.бензинToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.бензинToolStripMenuItem.Text = "Бензин";
            this.бензинToolStripMenuItem.Click += new System.EventHandler(this.бензинToolStripMenuItem_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остатокТовараToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // остатокТовараToolStripMenuItem
            // 
            this.остатокТовараToolStripMenuItem.Name = "остатокТовараToolStripMenuItem";
            this.остатокТовараToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.остатокТовараToolStripMenuItem.Text = "Остаток товара";
            this.остатокТовараToolStripMenuItem.Click += new System.EventHandler(this.остатокТовараToolStripMenuItem_Click);
            // 
            // закупитьToolStripMenuItem
            // 
            this.закупитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem1});
            this.закупитьToolStripMenuItem.Name = "закупитьToolStripMenuItem";
            this.закупитьToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.закупитьToolStripMenuItem.Text = "Закупить";
            // 
            // товарToolStripMenuItem1
            // 
            this.товарToolStripMenuItem1.Name = "товарToolStripMenuItem1";
            this.товарToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.товарToolStripMenuItem1.Text = "Товар";
            this.товарToolStripMenuItem1.Click += new System.EventHandler(this.товарToolStripMenuItem1_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(this.menuCustomer);
            this.MainMenuStrip = this.menuCustomer;
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.menuCustomer.ResumeLayout(false);
            this.menuCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem продатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бензинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остатокТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закупитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem1;
    }
}