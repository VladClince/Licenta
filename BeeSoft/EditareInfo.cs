using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class BiletInvestigatii : Form
    {
        private int unsuccess = 0;
        private string name;
        public void setNume(string nm)
        {
            name = nm;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from angajat", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string aux = sdr.GetString(1) + " " + sdr.GetString(2);
                    if (name == aux)
                    {
                        nume.Text = "";
                        nume.AppendText(sdr.GetString(1));
                        prenume.Text = "";
                        prenume.AppendText(sdr.GetString(2));
                        cnp.Text = "";
                        cnp.AppendText(sdr.GetString(3));
                        cnp.Enabled = false;
                        adresa.Text = "";
                        adresa.AppendText(sdr.GetString(4));
                        telefon.Text = "";
                        telefon.AppendText(sdr.GetString(5));
                        dataAngajare.Value = Convert.ToDateTime(sdr.GetString(6));
                        dataNasterii.Value = Convert.ToDateTime(sdr.GetString(7));
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public BiletInvestigatii()
        {
            InitializeComponent();
        }

        private void update()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = @"update angajat set nume='" + nume.Text + "',prenume='" + prenume.Text + "',adresa='" + adresa.Text + "',telefon='" + telefon.Text + "',data_angajare='" + dataAngajare.Text.ToString() + "',data_nasterii='" + dataNasterii.Text.ToString() + "' where cnp='" + cnp.Text + "' ";
                cmd.Connection = conn;

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == unsuccess)
                {
                    MessageBox.Show("Datele nu au putut fi actualizate. Contactati echipa de suport pentru remediere!");
                    Choose ob = new Choose();
                    ob.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datale au fost editate cu succes!");
                    Choose ob = new Choose();
                    ob.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            update();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }
    }
}