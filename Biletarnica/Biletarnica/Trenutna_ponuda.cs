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
    public partial class Trenutna_ponuda : Form
    {
        int broj_sloga = 0;
        DataTable tabela = new DataTable();
        public Trenutna_ponuda()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Film", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }    
        private void Txt_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_naslov.Text = "";
                txt_zanr.Text = "";
                txt_duzina.Text = "";
                txt_premijera.Text = "";
                txt_reziser.Text = "";
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_naslov.Text = tabela.Rows[broj_sloga]["naziv"].ToString();
                txt_zanr.Text = tabela.Rows[broj_sloga]["zanrovi"].ToString();
                txt_duzina.Text = tabela.Rows[broj_sloga]["duzina_min"].ToString();
                txt_premijera.Text = tabela.Rows[broj_sloga]["premijera"].ToString();
                txt_reziser.Text = tabela.Rows[broj_sloga]["reziser"].ToString();
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
        private void Trenutna_ponuda_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
            if (Program.user_uloga == 1)
            {
                btn_delete.Hide();
                btn_insert.Hide();
                btn_delete.Hide();
                txt_id.Hide();
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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO Film (naziv, zanrovi, duzina_min, premijera, reziser) VALUES ('");
            Naredba.Append(txt_naslov.Text + "', '" + txt_zanr.Text + "', '" + txt_duzina.Text + "', '");
            Naredba.Append(txt_premijera.Text + "', '" + txt_reziser.Text  + "')");
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
            SqlCommand komanda = new SqlCommand("insert into cenovnik values (" + txt_id.Text + ", 0)", veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM Film where id = " + txt_id.Text;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE Film SET ");
            Naredba.Append("naziv = '" + txt_naslov.Text + "', ");
            Naredba.Append("zanrovi = '" + txt_zanr.Text + "', ");
            Naredba.Append("duzina_min = '" + txt_duzina.Text + "', ");
            Naredba.Append("premijera = '" + txt_premijera.Text + "', ");
            Naredba.Append("reziser = '" + txt_reziser.Text + "'");
            Naredba.Append(" WHERE id = " + txt_id.Text);
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
    }
}
