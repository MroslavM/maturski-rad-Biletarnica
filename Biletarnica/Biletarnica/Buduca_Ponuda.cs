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
    public partial class Buduca_Ponuda : Form
    {
        public Buduca_Ponuda()
        {
            InitializeComponent();
        }

        private void Buduca_Ponuda_Load(object sender, EventArgs e)
        {
            cmb_film_populate();
            cmb_datum.Enabled = false;
            cmb_vreme.Enabled = false;
            cmb_sala.Enabled = false;
            txt_cena.Enabled = false;
            btn_Dodaj_ponudu.Enabled = false;
            textBox1.Hide();
        }
        private void cmb_film_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT id, naziv FROM Film", veza);
            DataTable dt_film = new DataTable();
            Adapter.Fill(dt_film);
            cmb_film.DataSource = dt_film;
            cmb_film.ValueMember = "id";
            cmb_film.DisplayMember = "naziv";
            cmb_film.SelectedIndex = -1;

        }

        private void cmb_film_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_film.IsHandleCreated && cmb_film.Focused)
            {
                cmb_datum.Enabled = true;
                cmb_datum_populate();
                SqlConnection veza = Konekcija.Connect();
                SqlDataAdapter Adapter_cena = new SqlDataAdapter("Select cena from Cenovnik where id_filma = " + cmb_film.SelectedValue, veza);
                //textBox1.Text = "Select cena from Cenovnik where id_filma = " + cmb_film.SelectedValue;
                DataTable dt_cena = new DataTable();
                Adapter_cena.Fill(dt_cena);
                txt_cena.Enabled = true;
                if (dt_cena.Rows.Count >= 1)
                {
                    txt_cena.Text = dt_cena.Rows[0][0].ToString();
                }
                Grid_populate();
            }
        }
        private void cmb_datum_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT datum FROM Termin", veza);
            DataTable dt_datum = new DataTable();
            Adapter.Fill(dt_datum);
            cmb_datum.DataSource = dt_datum;
            cmb_datum.ValueMember = "datum";
            cmb_datum.DisplayMember = "datum";
            cmb_datum.SelectedIndex = -1;
        }
        private void cmb_datum_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_datum.IsHandleCreated && cmb_datum.Focused)
            {
                cmb_vreme_populate();
                cmb_vreme.Enabled = true;
            }
        }

        private void cmb_vreme_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT vreme FROM Termin where datum = '" + cmb_datum.SelectedValue + "'", veza);
            textBox1.Text = "SELECT DISTINCT vreme FROM Termin where datum = '" + cmb_datum.SelectedValue + "'";
            DataTable dt_vreme = new DataTable();
            Adapter.Fill(dt_vreme);
            cmb_vreme.DataSource = dt_vreme;
            cmb_vreme.ValueMember = "vreme";
            cmb_vreme.DisplayMember = "vreme";
            cmb_vreme.SelectedIndex = -1;
        }

        private void cmb_vreme_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_vreme.IsHandleCreated && cmb_vreme.Focused)
            {
                cmb_sala.Enabled = true;
                cmb_sala_populate();
            }
        }
        private void cmb_sala_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT id FROM Sala", veza);
            DataTable dt_sala = new DataTable();
            Adapter.Fill(dt_sala);
            cmb_sala.DataSource = dt_sala;
            cmb_sala.ValueMember = "id";
            cmb_sala.DisplayMember = "id";
            cmb_sala.SelectedIndex = -1;
        }
        private void cmb_sala_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_Dodaj_ponudu.Enabled = true;
        }

        private void btn_cena_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("UPDATE Cenovnik SET cena = " + txt_cena.Text + "WHERE id_filma = " + cmb_film.SelectedValue, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba_pomoc = new StringBuilder("Select id from Termin");
            naredba_pomoc.Append(" WHERE datum = '" + cmb_datum.SelectedValue + "'");
            naredba_pomoc.Append(" and vreme = '" + cmb_vreme.SelectedValue + "'");
            //textBox1.Text = naredba_pomoc.ToString();
            SqlDataAdapter Adapter_pomoc = new SqlDataAdapter(naredba_pomoc.ToString(), veza);
            DataTable dt_pomoc = new DataTable();
            Adapter_pomoc.Fill(dt_pomoc);
            StringBuilder naredba = new StringBuilder("INSERT INTO Vezna VALUES (" + cmb_film.SelectedValue + ",");
            naredba.Append(dt_pomoc.Rows[0][0].ToString() + ",");
            naredba.Append(cmb_sala.SelectedValue + ")");
            //textBox1.Text = naredba.ToString();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            Grid_populate();
        }

        private void btn_dodaj_film_Click(object sender, EventArgs e)
        {
            Trenutna_ponuda trenutna = new Trenutna_ponuda();
            trenutna.Show();
        }

        private void btn_termin_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            if (String.IsNullOrEmpty(txt_datum.Text) || String.IsNullOrEmpty(txt_datum.Text))
            {
                MessageBox.Show("Unesite i datum i vreme kako biste ih dodali u ponudu");
            }
            else
            {
                StringBuilder naredba = new StringBuilder("INSERT INTO Termin VALUES ('");
                naredba.Append(txt_datum.Text + "', '");
                naredba.Append(txt_vreme.Text + "')");
                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                cmb_datum_populate();
                cmb_vreme_populate();
                txt_datum.Text = "";
                txt_vreme.Text = "";
            }
        }
        private void Grid_populate() 
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("SELECT naziv, datum, vreme, sala.id as sala, cena from Film ");
            naredba.Append(" join cenovnik on cenovnik.id_filma = film.id");
            naredba.Append(" join vezna on vezna.id_filma = film.id");
            naredba.Append(" join termin on termin.id = vezna.id_termina");
            naredba.Append(" join sala on sala.id = vezna.id_sale");
            naredba.Append(" where film.id = " + cmb_film.SelectedValue);
            //textBox1.Text = naredba.ToString();
            SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_grid = new DataTable();
            Adapter.Fill(dt_grid);
            Grid.DataSource = dt_grid;
        }
    }
}
