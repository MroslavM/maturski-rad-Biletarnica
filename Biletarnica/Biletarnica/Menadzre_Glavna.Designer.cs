
namespace Biletarnica
{
    partial class Menadzer_Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ponudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buducaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponudaToolStripMenuItem,
            this.izvestajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ponudaToolStripMenuItem
            // 
            this.ponudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trenutnaToolStripMenuItem,
            this.buducaToolStripMenuItem});
            this.ponudaToolStripMenuItem.Name = "ponudaToolStripMenuItem";
            this.ponudaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ponudaToolStripMenuItem.Text = "Ponuda";
            // 
            // trenutnaToolStripMenuItem
            // 
            this.trenutnaToolStripMenuItem.Name = "trenutnaToolStripMenuItem";
            this.trenutnaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.trenutnaToolStripMenuItem.Text = "Trenutna ";
            this.trenutnaToolStripMenuItem.Click += new System.EventHandler(this.trenutnaToolStripMenuItem_Click);
            // 
            // buducaToolStripMenuItem
            // 
            this.buducaToolStripMenuItem.Name = "buducaToolStripMenuItem";
            this.buducaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.buducaToolStripMenuItem.Text = "Buduca";
            this.buducaToolStripMenuItem.Click += new System.EventHandler(this.buducaToolStripMenuItem_Click);
            // 
            // izvestajToolStripMenuItem
            // 
            this.izvestajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodajaToolStripMenuItem});
            this.izvestajToolStripMenuItem.Name = "izvestajToolStripMenuItem";
            this.izvestajToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.izvestajToolStripMenuItem.Text = "Pregled";
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.prodajaToolStripMenuItem.Text = "Izvestaj";
            this.prodajaToolStripMenuItem.Click += new System.EventHandler(this.prodajaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(580, 9);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(68, 13);
            this.lbl_ime.TabIndex = 2;
            this.lbl_ime.Text = "Ime i prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "menadzer";
            // 
            // Menadzer_Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menadzer_Glavna";
            this.Text = "Menadzer_Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menadzre_Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Menadzre_Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ponudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buducaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label label2;
    }
}