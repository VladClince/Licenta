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
    public partial class AdaugaAngajat : Form
    {
        private int success = 1;
        private int successUser = 0;
        public AdaugaAngajat()
        {
            InitializeComponent();
        }

        int creazaUser(string nm, string user)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into logare(user,password,nume) values(@user,@password,@nume)", conn);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", "123");
                cmd.Parameters.AddWithValue("@nume", nm);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private void insert()
        {
            if(nume.Text != "")
            {
                if (prenume.Text != "")
                {
                    if (cnp.Text != "")
                    {
                        if (adresa.Text != "")
                        {
                            if (telefon.Text != "")
                            {
                                string aux_user = null;
                                string aux_name = nume.Text + " " + prenume.Text;
                                string aux_first_char = prenume.Text;
                                aux_user = aux_first_char.Substring(0, 1) + nume.Text;
                                MySql.Data.MySqlClient.MySqlConnection conn;
                                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                try
                                {
                                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                    conn.Open();
                                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into angajat(nume,prenume,cnp,adresa,telefon,data_angajare,data_nasterii) values(@nume,@prenume,@cnp,@adresa,@telefon,@data_angajare,@data_nasterii)", conn);
                                    cmd.Connection = conn;
                                    cmd.Parameters.AddWithValue("@nume", nume.Text);
                                    cmd.Parameters.AddWithValue("@prenume", prenume.Text);
                                    cmd.Parameters.AddWithValue("@cnp", cnp.Text);
                                    cmd.Parameters.AddWithValue("@adresa", adresa.Text);
                                    cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                                    cmd.Parameters.AddWithValue("@data_angajare", dataAngajare.Text.ToString());
                                    cmd.Parameters.AddWithValue("@data_nasterii", dataNasterii.Text.ToString());

                                    int i = cmd.ExecuteNonQuery();

                                    conn.Close();

                                    if (i == success)
                                    {
                                        MessageBox.Show("Angajatul a fost adaugat cu succes!");
                                        Choose ob = new Choose();
                                        ob.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("A aparut o problema la adaugare! Consultatii echipa tehnica pentru remediere.");
                                        Choose ob = new Choose();
                                        ob.Show();
                                        this.Hide();
                                    }
                                    conn.Close();
                                }
                                catch (MySql.Data.MySqlClient.MySqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                if (creazaUser(aux_name, aux_user.ToLower()) == successUser)
                                { }
                                else
                                {
                                    MessageBox.Show("A aparut o problema la crearea contului de logare! Contactati echipa de suport!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu a-ti completat telefonul!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu a-ti completat adresa!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu a-ti completat CNP-ul!");
                    }
                }
                else
                {
                    MessageBox.Show("Nu a-ti completat prenume!");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti completat numele!");
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            insert();   
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }
    }
}
