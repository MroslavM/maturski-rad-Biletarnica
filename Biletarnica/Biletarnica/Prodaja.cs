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
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        private void Prodaja_Load(object sender, EventArgs e)
        {
            cmb_film_populate();
            cmb_datum.Enabled = false;
            cmb_vreme.Enabled = false;
            cmb_sala.Enabled = false;
            cmb_red.Enabled = false;
            cmb_mesto.Enabled = false;
            btn_prodaja.Enabled = false;
            btn_rezervacija.Enabled = false;
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
            }
        }

        private void cmb_datum_populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT datum FROM Termin ");
            naredba.Append(" JOIN Vezna ON termin.id = id_termina ");
            naredba.Append(" WHERE id_filma = " + cmb_film.SelectedValue);
            //textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
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
                cmb_vreme.Enabled = true;
                cmb_vreme_populate();
            }
        }

        private void cmb_vreme_populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT id_termina as id, vreme FROM Termin ");
            naredba.Append(" JOIN Vezna ON termin.id = id_termina ");
            naredba.Append(" WHERE id_filma = " + cmb_film.SelectedValue);
            naredba.Append(" AND datum = '" + cmb_datum.SelectedValue + "'");
            textBox1.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_vreme = new DataTable();
            Adapter.Fill(dt_vreme);
            cmb_vreme.DataSource = dt_vreme;
            cmb_vreme.ValueMember = "id";
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
            StringBuilder naredba = new StringBuilder("SELECT id_sale as sala FROM Vezna ");
            naredba.Append(" WHERE id_filma = " + cmb_film.SelectedValue);
            naredba.Append(" AND id_termina = " + cmb_vreme.SelectedValue);
            SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
            //textBox1.Text = naredba.ToString();
            DataTable dt_sala = new DataTable();
            Adapter.Fill(dt_sala);
            cmb_sala.DataSource = dt_sala;
            cmb_sala.ValueMember = "sala";
            cmb_sala.DisplayMember = "sala";
            cmb_sala.SelectedIndex = -1;
        }
        private void cmb_sala_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_sala.IsHandleCreated && cmb_sala.Focused)
            {
                cmb_red.Enabled = true;
                cmb_red_populate();
                Grid_rezervacija_populate();
            }
        }
        private void cmb_red_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT red FROM Sediste WHERE id_sale = " + cmb_sala.SelectedValue, veza);
            DataTable dt_red = new DataTable();
            Adapter.Fill(dt_red);
            cmb_red.DataSource = dt_red;
            cmb_red.ValueMember = "red";
            cmb_red.DisplayMember = "red";
            cmb_red.SelectedIndex = -1;
        }

        private void cmb_red_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_red.IsHandleCreated && cmb_red.Focused)
            {
                cmb_mesto.Enabled = true;
                cmb_mesto_populate();
            }
        }
        private void cmb_mesto_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DISTINCT broj FROM Sediste WHERE id_sale = " + cmb_sala.SelectedValue, veza);
            DataTable dt_mesto = new DataTable();
            Adapter.Fill(dt_mesto);
            cmb_mesto.DataSource = dt_mesto;
            cmb_mesto.ValueMember = "broj";
            cmb_mesto.DisplayMember = "broj";
            cmb_mesto.SelectedIndex = -1;
        }
        private void cmb_mesto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_mesto.IsHandleCreated && cmb_mesto.Focused)
            {
                btn_rezervacija.Enabled = true;
                btn_prodaja.Enabled = true;
            }
        }
        private void Grid_rezervacija_populate()
        {
            if (cmb_film.SelectedIndex >=0)
            {
                SqlConnection veza = Konekcija.Connect();
                StringBuilder naredba = new StringBuilder("SELECT naziv AS Naslov_filma, vreme AS Pocetak, id_sale AS Sala, red, broj FROM Rezervacija_prodaja ");
                naredba.Append(" JOIN Film on id_filma = film.id ");
                naredba.Append(" JOIN Termin on id_termina = termin.id");
                naredba.Append(" JOIN Sediste on id_sedista = sediste.id");
                naredba.Append(" WHERE rez_prod = 'rezervacija'");
                naredba.Append(" AND id_filma = " + cmb_film.SelectedValue);
                naredba.Append(" AND id_termina = " + cmb_vreme.SelectedValue);
                naredba.Append(" AND id_sale = " + cmb_sala.SelectedValue);
                //textBox1.Text = naredba.ToString();
                SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
                DataTable dt_rezervacija = new DataTable();
                Adapter.Fill(dt_rezervacija);
                Grid_rezervacije.DataSource = dt_rezervacija;
            }
            else
            {
                SqlConnection veza = Konekcija.Connect();
                StringBuilder naredba = new StringBuilder("SELECT naziv AS Naslov_filma, vreme AS Pocetak, id_sale AS Sala, red, broj FROM Rezervacija_prodaja ");
                naredba.Append(" JOIN Film on id_filma = film.id ");
                naredba.Append(" JOIN Termin on id_termina = termin.id");
                naredba.Append(" JOIN Sediste on id_sedista = sediste.id");
                naredba.Append(" WHERE rez_prod = 'rezervacija'");
                naredba.Append(" AND id_filma = " + 0);
                naredba.Append(" AND id_termina = " + 0);
                naredba.Append(" AND id_sale = " + 0);
                //textBox1.Text = naredba.ToString();
                SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
                DataTable dt_rezervacija = new DataTable();
                Adapter.Fill(dt_rezervacija);
                Grid_rezervacije.DataSource = dt_rezervacija;
            }
                
        }

        private void btn_rezervacija_Click(object sender, EventArgs e)
        {
            
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba_pomoc = new StringBuilder("Select id from Sediste where id_sale = " + cmb_sala.SelectedValue);
            naredba_pomoc.Append(" and red = " + cmb_red.SelectedValue);
            naredba_pomoc.Append(" and broj = " + cmb_mesto.SelectedValue);
            SqlDataAdapter Adapter_pomoc = new SqlDataAdapter(naredba_pomoc.ToString(), veza);
            DataTable dt_pomoc = new DataTable();
            Adapter_pomoc.Fill(dt_pomoc);
            StringBuilder naredba = new StringBuilder("INSERT INTO Rezervacija_Prodaja(id_filma, id_termina, id_sedista, rez_prod)");
            naredba.Append("VALUES (" + cmb_film.SelectedValue + ", ");
            naredba.Append(cmb_vreme.SelectedValue + ", ");
            naredba.Append(dt_pomoc.Rows[0][0] + ", ");
            naredba.Append("'rezervacija')");
            //textBox1.Text = naredba.ToString();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            Grid_rezervacija_populate();
        }

        private void btn_prodaja_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba_pomoc = new StringBuilder("Select id from Sediste where id_sale = " + cmb_sala.SelectedValue);
            naredba_pomoc.Append(" and red = " + cmb_red.SelectedValue);
            naredba_pomoc.Append(" and broj = " + cmb_mesto.SelectedValue);
            SqlDataAdapter Adapter_pomoc = new SqlDataAdapter(naredba_pomoc.ToString(), veza);
            DataTable dt_pomoc = new DataTable();
            Adapter_pomoc.Fill(dt_pomoc);
            StringBuilder naredba = new StringBuilder("INSERT INTO Rezervacija_Prodaja(id_filma, id_termina, id_sedista, rez_prod)");
            naredba.Append("VALUES (" + cmb_film.SelectedValue + ", ");
            naredba.Append(cmb_vreme.SelectedValue + ", ");
            naredba.Append(dt_pomoc.Rows[0][0] + ", ");
            naredba.Append("'prodaja')");
            //textBox1.Text = naredba.ToString();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
        }

        private void btn_sledecikupac_Click(object sender, EventArgs e)
        {
            cmb_film.SelectedIndex = -1;
            cmb_datum.SelectedIndex = -1;
            cmb_vreme.SelectedIndex = -1;
            cmb_sala.SelectedIndex = -1;
            cmb_mesto.SelectedIndex = -1;
            cmb_red.SelectedIndex = -1;
            Grid_rezervacija_populate();
            cmb_datum.Enabled = false;
            cmb_vreme.Enabled = false;
            cmb_sala.Enabled = false;
            cmb_red.Enabled = false;
            cmb_mesto.Enabled = false;
            btn_prodaja.Enabled = false;
            btn_rezervacija.Enabled = false;
        }
    }
}
