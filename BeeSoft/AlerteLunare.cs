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
    public partial class AlerteLunare : Form
    {
        private bool status = false;
        private int id;
        private int unsuccess = 0;
        string aux;
        string now;
        char delimCaract = ' ';
        public AlerteLunare()
        {
            InitializeComponent();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from alerte", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    now = DateTime.Now.ToString();
                    string[] time = now.Split(delimCaract);
                    listBox.Items.Add(sdr.GetString(1) + "      -        " + sdr.GetString(2) + " " + sdr.GetString(3));
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void findId()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from alerte", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string compare=sdr.GetString(1) + "      -        " + sdr.GetString(2) + " " + sdr.GetString(3);
                    if(aux == compare)
                    {
                        id=sdr.GetInt32(0);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete()
        {
            if(status)
            {
                aux = listBox.SelectedItem.ToString();
                findId();
                string[] alerta = aux.Split(delimCaract);
                if (aux != null)
                {
                    DialogResult result = MessageBox.Show(this, "Sigur doriti sa stergeti alerta?", "BeeSoft", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        MySql.Data.MySqlClient.MySqlConnection conn;
                        string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                        try
                        {
                            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                            conn.Open();
                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                            cmd.CommandText = @"delete from alerte where id_alerte='" + id + "'";
                            cmd.Connection = conn;

                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i == unsuccess)
                            {
                                MessageBox.Show("Alerta nu a putut fi stearsa. Contactati echipa de suport pentru remediere!");
                                AlerteLunare ob = new AlerteLunare();
                                ob.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Alerta a fost stearsa din baza de date!");
                                AlerteLunare ob = new AlerteLunare();
                                ob.Show();
                                this.Hide();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void stergeAlerta_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void stergeAlerta1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void adaugaAlerta_Click(object sender, EventArgs e)
        {
            AdaugaAlerta ob = new AdaugaAlerta();
            ob.Show();
            this.Hide();
        }

        private void adaugaAlerta1_Click(object sender, EventArgs e)
        {
            AdaugaAlerta ob = new AdaugaAlerta();
            ob.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = true;
        }
    }
}