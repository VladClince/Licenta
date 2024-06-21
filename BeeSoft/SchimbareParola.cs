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
    public partial class SchimbareParola : Form
    {
        private int success = 1;
        private int unsuccess = 0;
        private string nume = null;
        private string aux_parola = null;
        public void setNume(string nm)
        {
            nume = nm;
        }

        public SchimbareParola()
        {
            InitializeComponent();
        }

        int verificareParola()
        {
            aux_parola = parolaCurenta.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from logare", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if(aux_parola == sdr.GetString(2))
                    {
                        return 1;
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void update()
        {
            if (verificareParola() == success)
            {
                if (parolaNoua.Text == parolaNoua2.Text)
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd.CommandText = @"update logare set password='" + parolaNoua.Text + "' where nume='" + nume + "' ";
                        cmd.Connection = conn;

                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i == unsuccess)
                        {
                            MessageBox.Show("Parola nu a putut fi schimbata. Contactati echipa de suport pentru remediere!");
                            Choose ob = new Choose();
                            ob.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Parola a fost schimbata cu succes!");
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
                else
                {
                    MessageBox.Show("Cele doua parole nu corespund!");
                }
            }
            else
            {
                MessageBox.Show("Parola curenta nu este buna!");
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