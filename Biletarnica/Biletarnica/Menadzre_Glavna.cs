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
    public partial class Menadzer_Glavna : Form
    {
        public Menadzer_Glavna()
        {
            InitializeComponent();
        }

        private void Menadzre_Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menadzre_Glavna_Load(object sender, EventArgs e)
        {
            lbl_ime.Text = Program.user_ime + " " + Program.user_prezime;
        }

        private void trenutnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trenutna_ponuda trenutna = new Trenutna_ponuda();
            trenutna.Show();
        }

        private void buducaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buduca_Ponuda buduca = new Buduca_Ponuda();
            buduca.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaj izvestaj = new Izvestaj();
            izvestaj.Show();
        }
    }
}
