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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass == null)
            {
                MessageBox.Show("Morate uneti i email i sifru kako bi ste pristupili aplikaciji");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Zaposleni WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_email.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            //MessageBox.Show("Login uspesan!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            this.Hide();
                            if (Program.user_uloga == 3)
                            {
                                Direktor_Glavna direktor = new Direktor_Glavna();
                                direktor.Show();
                            }
                            else
                            {
                                if (Program.user_uloga == 2)
                                {
                                    Menadzer_Glavna menadzer = new Menadzer_Glavna();
                                    menadzer.Show();
                                }
                                else
                                {
                                    Kasa_Glavna kasa = new Kasa_Glavna();
                                    kasa.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Uneli ste pogresnu lozinku.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste nepostojeci email");
                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
