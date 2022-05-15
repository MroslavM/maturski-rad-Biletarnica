
namespace Biletarnica
{
    partial class Prodaja
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
            this.cmb_film = new System.Windows.Forms.ComboBox();
            this.cmb_datum = new System.Windows.Forms.ComboBox();
            this.cmb_vreme = new System.Windows.Forms.ComboBox();
            this.cmb_sala = new System.Windows.Forms.ComboBox();
            this.lbl_cena = new System.Windows.Forms.Label();
            this.btn_rezervacija = new System.Windows.Forms.Button();
            this.btn_prodaja = new System.Windows.Forms.Button();
            this.Grid_rezervacije = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sledecikupac = new System.Windows.Forms.Button();
            this.cmb_red = new System.Windows.Forms.ComboBox();
            this.cmb_mesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_rezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_film
            // 
            this.cmb_film.FormattingEnabled = true;
            this.cmb_film.Location = new System.Drawing.Point(15, 88);
            this.cmb_film.Name = "cmb_film";
            this.cmb_film.Size = new System.Drawing.Size(204, 21);
            this.cmb_film.TabIndex = 0;
            this.cmb_film.SelectedValueChanged += new System.EventHandler(this.cmb_film_SelectedValueChanged);
            // 
            // cmb_datum
            // 
            this.cmb_datum.FormattingEnabled = true;
            this.cmb_datum.Location = new System.Drawing.Point(232, 88);
            this.cmb_datum.Name = "cmb_datum";
            this.cmb_datum.Size = new System.Drawing.Size(121, 21);
            this.cmb_datum.TabIndex = 1;
            this.cmb_datum.SelectedValueChanged += new System.EventHandler(this.cmb_datum_SelectedValueChanged);
            // 
            // cmb_vreme
            // 
            this.cmb_vreme.FormattingEnabled = true;
            this.cmb_vreme.Location = new System.Drawing.Point(359, 88);
            this.cmb_vreme.Name = "cmb_vreme";
            this.cmb_vreme.Size = new System.Drawing.Size(121, 21);
            this.cmb_vreme.TabIndex = 2;
            this.cmb_vreme.SelectedValueChanged += new System.EventHandler(this.cmb_vreme_SelectedValueChanged);
            // 
            // cmb_sala
            // 
            this.cmb_sala.FormattingEnabled = true;
            this.cmb_sala.Location = new System.Drawing.Point(12, 159);
            this.cmb_sala.Name = "cmb_sala";
            this.cmb_sala.Size = new System.Drawing.Size(71, 21);
            this.cmb_sala.TabIndex = 3;
            this.cmb_sala.SelectedValueChanged += new System.EventHandler(this.cmb_sala_SelectedValueChanged);
            // 
            // lbl_cena
            // 
            this.lbl_cena.AutoSize = true;
            this.lbl_cena.Location = new System.Drawing.Point(746, 321);
            this.lbl_cena.Name = "lbl_cena";
            this.lbl_cena.Size = new System.Drawing.Size(31, 13);
            this.lbl_cena.TabIndex = 4;
            this.lbl_cena.Text = "cena";
            // 
            // btn_rezervacija
            // 
            this.btn_rezervacija.Location = new System.Drawing.Point(652, 359);
            this.btn_rezervacija.Name = "btn_rezervacija";
            this.btn_rezervacija.Size = new System.Drawing.Size(94, 44);
            this.btn_rezervacija.TabIndex = 6;
            this.btn_rezervacija.Text = "Rezervisi";
            this.btn_rezervacija.UseVisualStyleBackColor = true;
            this.btn_rezervacija.Click += new System.EventHandler(this.btn_rezervacija_Click);
            // 
            // btn_prodaja
            // 
            this.btn_prodaja.Location = new System.Drawing.Point(784, 359);
            this.btn_prodaja.Name = "btn_prodaja";
            this.btn_prodaja.Size = new System.Drawing.Size(83, 44);
            this.btn_prodaja.TabIndex = 7;
            this.btn_prodaja.Text = "Prodaj";
            this.btn_prodaja.UseVisualStyleBackColor = true;
            this.btn_prodaja.Click += new System.EventHandler(this.btn_prodaja_Click);
            // 
            // Grid_rezervacije
            // 
            this.Grid_rezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_rezervacije.Location = new System.Drawing.Point(9, 253);
            this.Grid_rezervacije.Name = "Grid_rezervacije";
            this.Grid_rezervacije.Size = new System.Drawing.Size(611, 235);
            this.Grid_rezervacije.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(635, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naslov filma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sala";
            // 
            // btn_sledecikupac
            // 
            this.btn_sledecikupac.Location = new System.Drawing.Point(763, 455);
            this.btn_sledecikupac.Name = "btn_sledecikupac";
            this.btn_sledecikupac.Size = new System.Drawing.Size(104, 33);
            this.btn_sledecikupac.TabIndex = 14;
            this.btn_sledecikupac.Text = "Sledeci kupac";
            this.btn_sledecikupac.UseVisualStyleBackColor = true;
            this.btn_sledecikupac.Click += new System.EventHandler(this.btn_sledecikupac_Click);
            // 
            // cmb_red
            // 
            this.cmb_red.FormattingEnabled = true;
            this.cmb_red.Location = new System.Drawing.Point(89, 159);
            this.cmb_red.Name = "cmb_red";
            this.cmb_red.Size = new System.Drawing.Size(66, 21);
            this.cmb_red.TabIndex = 15;
            this.cmb_red.SelectedValueChanged += new System.EventHandler(this.cmb_red_SelectedValueChanged);
            // 
            // cmb_mesto
            // 
            this.cmb_mesto.FormattingEnabled = true;
            this.cmb_mesto.Location = new System.Drawing.Point(161, 159);
            this.cmb_mesto.Name = "cmb_mesto";
            this.cmb_mesto.Size = new System.Drawing.Size(64, 21);
            this.cmb_mesto.TabIndex = 16;
            this.cmb_mesto.SelectedValueChanged += new System.EventHandler(this.cmb_mesto_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Red";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mesto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "REZERVACIJE";
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_mesto);
            this.Controls.Add(this.cmb_red);
            this.Controls.Add(this.btn_sledecikupac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Grid_rezervacije);
            this.Controls.Add(this.btn_prodaja);
            this.Controls.Add(this.btn_rezervacija);
            this.Controls.Add(this.lbl_cena);
            this.Controls.Add(this.cmb_sala);
            this.Controls.Add(this.cmb_vreme);
            this.Controls.Add(this.cmb_datum);
            this.Controls.Add(this.cmb_film);
            this.Name = "Prodaja";
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.Prodaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_rezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_film;
        private System.Windows.Forms.ComboBox cmb_datum;
        private System.Windows.Forms.ComboBox cmb_vreme;
        private System.Windows.Forms.ComboBox cmb_sala;
        private System.Windows.Forms.Label lbl_cena;
        private System.Windows.Forms.Button btn_rezervacija;
        private System.Windows.Forms.Button btn_prodaja;
        private System.Windows.Forms.DataGridView Grid_rezervacije;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sledecikupac;
        private System.Windows.Forms.ComboBox cmb_red;
        private System.Windows.Forms.ComboBox cmb_mesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}