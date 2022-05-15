
namespace Biletarnica
{
    partial class Buduca_Ponuda
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
            this.btn_dodaj_film = new System.Windows.Forms.Button();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txt_datum = new System.Windows.Forms.TextBox();
            this.txt_vreme = new System.Windows.Forms.TextBox();
            this.btn_cena = new System.Windows.Forms.Button();
            this.btn_termin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Dodaj_ponudu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_film
            // 
            this.cmb_film.FormattingEnabled = true;
            this.cmb_film.Location = new System.Drawing.Point(24, 45);
            this.cmb_film.Name = "cmb_film";
            this.cmb_film.Size = new System.Drawing.Size(121, 21);
            this.cmb_film.TabIndex = 0;
            this.cmb_film.SelectedValueChanged += new System.EventHandler(this.cmb_film_SelectedValueChanged);
            // 
            // cmb_datum
            // 
            this.cmb_datum.FormattingEnabled = true;
            this.cmb_datum.Location = new System.Drawing.Point(151, 45);
            this.cmb_datum.Name = "cmb_datum";
            this.cmb_datum.Size = new System.Drawing.Size(121, 21);
            this.cmb_datum.TabIndex = 1;
            this.cmb_datum.SelectedValueChanged += new System.EventHandler(this.cmb_datum_SelectedValueChanged);
            // 
            // cmb_vreme
            // 
            this.cmb_vreme.FormattingEnabled = true;
            this.cmb_vreme.Location = new System.Drawing.Point(278, 45);
            this.cmb_vreme.Name = "cmb_vreme";
            this.cmb_vreme.Size = new System.Drawing.Size(121, 21);
            this.cmb_vreme.TabIndex = 2;
            this.cmb_vreme.SelectedValueChanged += new System.EventHandler(this.cmb_vreme_SelectedValueChanged);
            // 
            // cmb_sala
            // 
            this.cmb_sala.FormattingEnabled = true;
            this.cmb_sala.Location = new System.Drawing.Point(405, 45);
            this.cmb_sala.Name = "cmb_sala";
            this.cmb_sala.Size = new System.Drawing.Size(121, 21);
            this.cmb_sala.TabIndex = 3;
            this.cmb_sala.SelectedValueChanged += new System.EventHandler(this.cmb_sala_SelectedValueChanged);
            // 
            // btn_dodaj_film
            // 
            this.btn_dodaj_film.Location = new System.Drawing.Point(24, 80);
            this.btn_dodaj_film.Name = "btn_dodaj_film";
            this.btn_dodaj_film.Size = new System.Drawing.Size(121, 23);
            this.btn_dodaj_film.TabIndex = 4;
            this.btn_dodaj_film.Text = "Menjaj ponudu filmova";
            this.btn_dodaj_film.UseVisualStyleBackColor = true;
            this.btn_dodaj_film.Click += new System.EventHandler(this.btn_dodaj_film_Click);
            // 
            // txt_cena
            // 
            this.txt_cena.Location = new System.Drawing.Point(566, 46);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(100, 20);
            this.txt_cena.TabIndex = 6;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 206);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(776, 232);
            this.Grid.TabIndex = 7;
            // 
            // txt_datum
            // 
            this.txt_datum.Location = new System.Drawing.Point(151, 83);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(121, 20);
            this.txt_datum.TabIndex = 8;
            // 
            // txt_vreme
            // 
            this.txt_vreme.Location = new System.Drawing.Point(278, 83);
            this.txt_vreme.Name = "txt_vreme";
            this.txt_vreme.Size = new System.Drawing.Size(121, 20);
            this.txt_vreme.TabIndex = 9;
            // 
            // btn_cena
            // 
            this.btn_cena.Location = new System.Drawing.Point(566, 81);
            this.btn_cena.Name = "btn_cena";
            this.btn_cena.Size = new System.Drawing.Size(100, 23);
            this.btn_cena.TabIndex = 10;
            this.btn_cena.Text = "Promeni cenu";
            this.btn_cena.UseVisualStyleBackColor = true;
            this.btn_cena.Click += new System.EventHandler(this.btn_cena_Click);
            // 
            // btn_termin
            // 
            this.btn_termin.Location = new System.Drawing.Point(235, 109);
            this.btn_termin.Name = "btn_termin";
            this.btn_termin.Size = new System.Drawing.Size(85, 23);
            this.btn_termin.TabIndex = 11;
            this.btn_termin.Text = "Dodaj termin";
            this.btn_termin.UseVisualStyleBackColor = true;
            this.btn_termin.Click += new System.EventHandler(this.btn_termin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vreme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cena";
            // 
            // btn_Dodaj_ponudu
            // 
            this.btn_Dodaj_ponudu.Location = new System.Drawing.Point(706, 45);
            this.btn_Dodaj_ponudu.Name = "btn_Dodaj_ponudu";
            this.btn_Dodaj_ponudu.Size = new System.Drawing.Size(82, 58);
            this.btn_Dodaj_ponudu.TabIndex = 17;
            this.btn_Dodaj_ponudu.Text = "Dodaj u ponudu";
            this.btn_Dodaj_ponudu.UseVisualStyleBackColor = true;
            this.btn_Dodaj_ponudu.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "SVE PONUDE ZA IZABRANI FILM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Novo vreme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Novi datum";
            // 
            // Buduca_Ponuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Dodaj_ponudu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_termin);
            this.Controls.Add(this.btn_cena);
            this.Controls.Add(this.txt_vreme);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.btn_dodaj_film);
            this.Controls.Add(this.cmb_sala);
            this.Controls.Add(this.cmb_vreme);
            this.Controls.Add(this.cmb_datum);
            this.Controls.Add(this.cmb_film);
            this.Name = "Buduca_Ponuda";
            this.Text = "Buduca_Ponuda";
            this.Load += new System.EventHandler(this.Buduca_Ponuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_film;
        private System.Windows.Forms.ComboBox cmb_datum;
        private System.Windows.Forms.ComboBox cmb_vreme;
        private System.Windows.Forms.ComboBox cmb_sala;
        private System.Windows.Forms.Button btn_dodaj_film;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txt_datum;
        private System.Windows.Forms.TextBox txt_vreme;
        private System.Windows.Forms.Button btn_cena;
        private System.Windows.Forms.Button btn_termin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Dodaj_ponudu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}