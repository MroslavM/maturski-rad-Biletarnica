using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biletarnica
{
    public partial class Zaposleni : Form
    {
        DataTable tabela = new DataTable();
        int broj_sloga = 0;
        public Zaposleni()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Zaposleni", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Txt_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_lozinka.Text = "";
                txt_uloga.Text = "";
                txt_radnovreme.Text = "";
                txt_satnica.Text = "";
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_jmbg.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["email"].ToString();
                txt_lozinka.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
                txt_radnovreme.Text = tabela.Rows[broj_sloga]["radno_vreme"].ToString();
                txt_satnica.Text = tabela.Rows[broj_sloga]["satnica"].ToString();
            }
            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }
        private void Zaposleni_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO Zaposleni (ime, prezime, jmbg, email, pass, uloga, radno_vreme, satnica) VALUES ('");
            Naredba.Append(txt_ime.Text + "', '" + txt_prezime.Text + "', '" + txt_jmbg.Text + "', '");
            Naredba.Append(txt_email.Text + "', '" + txt_lozinka.Text + "', '" + txt_uloga.Text + "', '");
            Naredba.Append(txt_radnovreme.Text + "', '" + txt_satnica.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand KomandaInsert = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                KomandaInsert.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE Zaposleni SET ");
            Naredba.Append("ime = '" + txt_ime.Text + "', ");
            Naredba.Append("prezime = '" + txt_prezime.Text + "', ");
            Naredba.Append("email = '" + txt_email.Text + "', ");
            Naredba.Append("jmbg = '" + txt_jmbg.Text + "', ");
            Naredba.Append("pass = '" + txt_lozinka.Text + "', ");
            Naredba.Append("uloga = '" + txt_uloga.Text + "', ");
            Naredba.Append("radno_vreme = '" + txt_radnovreme.Text + "', ");
            Naredba.Append("satnica = '" + txt_satnica.Text + "'");
            Naredba.Append("WHERE id = " + txt_id.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand KomandaUpdate = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                KomandaUpdate.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {

                MessageBox.Show(Greska.Message);
            }
            Load_Data();
            Txt_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM Zaposleni where id = " + txt_id.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand KomandaDelete = new SqlCommand(Naredba, veza);
            bool brisanje = false;
            try
            {
                veza.Open();
                KomandaDelete.ExecuteNonQuery();
                veza.Close();
                brisanje = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisanje)
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                Txt_Load();
            }
        }
    }
}
