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
    public partial class Izvestaj : Form
    {
        public Izvestaj()
        {
            InitializeComponent();
        }

        private void Izvestaj_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("SELECT naziv, COUNT(rez_prod) as prodate_karte FROM Film");
            naredba.Append(" JOIN Rezervacija_prodaja on Rezervacija_prodaja.id_filma = Film.id");
            naredba.Append(" where rez_prod = 'prodaja' group by naziv  ");
            DataTable tabela = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(naredba.ToString(), veza);
            Adapter.Fill(tabela);
            SqlDataAdapter Adapter1 = new SqlDataAdapter("Select cena from Cenovnik", veza);
            DataTable dt_cena = new DataTable();
            Adapter1.Fill(dt_cena);

            for (int i = 0; i < tabela.Rows.Count ; i++)
            {
                listBox1.Items.Add(tabela.Rows[i]["naziv"] + "  ukupno prodatih karata: " + tabela.Rows[i]["prodate_karte"] + " ukupna zarada: "  + (int)tabela.Rows[i]["prodate_karte"]*(int)dt_cena.Rows[i]["cena"]);
                listBox1.Items.Add("=================================================================================================================");
            }
        }

    }
}
