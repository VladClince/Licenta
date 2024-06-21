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
    public partial class ProgramariAsteptare : Form
    {
        private int unsuccess = 0;
        private int id;
        public ProgramariAsteptare()
        {
            InitializeComponent();
            EnablesButton(false);
            welcome();
        }

        private void welcome()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "waiting" + "' order by data asc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add(sdr.GetString(3) + " - " + sdr.GetString(4) + " " + sdr.GetString(1) + " " + sdr.GetString(2));
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnablesButton(bool b)
        {
            Accepta.Enabled = b;
            Accepta1.Enabled = b;
            Refuza.Enabled = b;
            Refuza1.Enabled = b;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                EnablesButton(true);
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "waiting" + "'", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string aux = sdr.GetString(3) + " - " + sdr.GetString(4) + " " + sdr.GetString(1) + " " + sdr.GetString(2);
                        if (listBox1.SelectedItem.ToString() == aux)
                        {
                            id = sdr.GetInt32(0);
                            listBox.Items.Add("Nume:");
                            listBox.Items.Add(sdr.GetString(1) + " " + sdr.GetString(2));
                            listBox.Items.Add("");
                            listBox.Items.Add("Data:");
                            listBox.Items.Add(sdr.GetString(3));
                            listBox.Items.Add("");
                            listBox.Items.Add("Ora:");
                            listBox.Items.Add(sdr.GetString(4));
                            listBox.Items.Add("");
                            listBox.Items.Add("Motiv:");
                            listBox.Items.Add(sdr.GetString(5));
                            listBox.Items.Add("");
                            listBox.Items.Add("Comentarii:");
                            listBox.Items.Add(sdr.GetString(6));
                            listBox.Items.Add("");
                            listBox.Items.Add("----------------------------------------------------------------");
                        }
                    }
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void accept()
        {
            EnablesButton(false);
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = @"update programari set status='" + "accept" + "' where id_programari='" + id + "' ";
                cmd.Connection = conn;

                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == unsuccess)
                {
                    MessageBox.Show("Programarea nu a putut fi confirmata. Contactati echipa de suport pentru remediere!");
                    ProgramariAsteptare ob = new ProgramariAsteptare();
                    this.Hide();
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Programarea a fost confirmata!");
                    ProgramariAsteptare ob = new ProgramariAsteptare();
                    this.Hide();
                    ob.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Accepta_Click(object sender, EventArgs e)
        {
            accept();
        }

        private void Accepta1_Click(object sender, EventArgs e)
        {
            accept();
        }

        private void refuse()
        {
            EnablesButton(false);
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = @"update programari set status='" + "decline" + "' where id_programari='" + id + "' ";
                cmd.Connection = conn;

                int i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProgramariAsteptare ob = new ProgramariAsteptare();
            ob.Show();
            this.Hide();
        }

        private void Refuza_Click(object sender, EventArgs e)
        {
            refuse();
        }

        private void Refuza1_Click(object sender, EventArgs e)
        {
            refuse();
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void InapoiLabel_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }
    }
}