
namespace Biletarnica
{
    partial class Kasa_Glavna
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
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(428, 1);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(68, 13);
            this.lbl_ime.TabIndex = 0;
            this.lbl_ime.Text = "Ime i prezime";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Location = new System.Drawing.Point(515, 1);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(33, 13);
            this.lbl_uloga.TabIndex = 1;
            this.lbl_uloga.Text = "uloga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ponuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Prodaja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kasa_Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_ime);
            this.Name = "Kasa_Glavna";
            this.Text = "Kasa_Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kasa_Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Kasa_Glavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}