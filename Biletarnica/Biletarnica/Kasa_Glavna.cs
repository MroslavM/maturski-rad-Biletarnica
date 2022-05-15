using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletarnica
{
    public partial class Kasa_Glavna : Form
    {
        public Kasa_Glavna()
        {
            InitializeComponent();
        }

        private void Kasa_Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Kasa_Glavna_Load(object sender, EventArgs e)
        {
            lbl_ime.Text = Program.user_ime + " " + Program.user_prezime;
            lbl_uloga.Text = "Kasa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trenutna_ponuda trenutna = new Trenutna_ponuda();
            trenutna.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prodaja prodaja = new Prodaja();
            prodaja.Show();
        }
    }
}
