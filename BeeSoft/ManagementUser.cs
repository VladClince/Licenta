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
    public partial class ManagementUser : Form
    {
        private int unsuccess = 0;
        private string nameAuxDelete;
        private int id;
        public ManagementUser()
        {
            InitializeComponent();
            EnabledText(false);
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
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from angajat", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr.GetString(1) + " " + sdr.GetString(2) != "Administrator Administrator")
                    {
                        listBox.Items.Add(sdr.GetString(1) + " " + sdr.GetString(2));                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnabledText(bool b)
        {
            nume.Enabled = b;
            prenume.Enabled = b;
            cnp.Enabled = b;
            adresa.Enabled = b;
            telefon.Enabled = b;
            dataAngajare.Enabled = b;
            dataNasterii.Enabled = b;

            Editeaza.Enabled = !b;
            Editeaza1.Enabled = !b;
            Sterge.Enabled = !b;
            sterge1.Enabled = !b;
            Salvare.Enabled = b;
            Salvare1.Enabled = b;
            Renunta.Enabled = b;
            Renunta1.Enabled = b;
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

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
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
                        if (listBox.SelectedItem.ToString() == aux)
                        {
                            id = sdr.GetInt32(0);
                            nameAuxDelete = sdr.GetString(1) + " " + sdr.GetString(2);
                            nume.Text = sdr.GetString(1);
                            prenume.Text = sdr.GetString(2);
                            cnp.Text = sdr.GetString(3);
                            adresa.Text = sdr.GetString(4);
                            telefon.Text = sdr.GetString(5);
                            dataAngajare.Value = Convert.ToDateTime(sdr.GetString(6) + " 2:52:35 PM");
                            dataNasterii.Value = Convert.ToDateTime(sdr.GetString(7) + " 2:52:35 PM");
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

        private void delete()
        {
            if(nameAuxDelete != null)
            {
                DialogResult result = MessageBox.Show(this, "Sigur doriti sa stergeti angajatul " + nameAuxDelete.ToString() + " ?", "BeeSoft", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd.CommandText = @"delete from angajat where id_angajat='" + id + "'";
                        cmd.Connection = conn;

                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i == unsuccess)
                        {
                            MessageBox.Show("Angajatul nu a putut fi sters. Contactati echipa de suport pentru remediere!");
                            ManagementUser ob = new ManagementUser();
                            ob.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Angajatul a fost sters din baza de date!");
                            ManagementUser ob = new ManagementUser();
                            ob.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    EnabledText(false);
                }
                else
                {
                    EnabledText(false);
                }
            }
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void sterge1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void Editeaza_Click(object sender, EventArgs e)
        {
            EnabledText(true);
        }

        private void Editeaza1_Click(object sender, EventArgs e)
        {
            EnabledText(true);
        }

        private void save()
        {
            if (nume.Text != "")
            {
                if (prenume.Text != "")
                {
                    if (cnp.Text != "")
                    {
                        if (adresa.Text != "")
                        {
                            if (telefon.Text != "")
                            {
                                MySql.Data.MySqlClient.MySqlConnection conn;
                                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                try
                                {
                                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                    conn.Open();
                                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                                    cmd.CommandText = @"update angajat set nume='" + nume.Text + "', prenume='" + prenume.Text + "', cnp='" + cnp.Text + "', adresa='" + adresa.Text + "', telefon='" + telefon.Text + "', data_angajare='" + dataAngajare.Text.ToString() + "', data_nasterii='" + dataNasterii.Text.ToString() + "' where id_angajat='" + id + "' ";
                                    cmd.Connection = conn;

                                    int i = cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (i == unsuccess)
                                    {
                                        MessageBox.Show("Angajatul nu a putut fi actualizat. Contactati echipa de suport pentru remediere!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Angajatul a fost actualizat!");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                EnabledText(false);
                            }
                            else
                            {
                                MessageBox.Show("Numarul de telefon nu este completat!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Adresa nu este completata!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CNP-ul nu a fost completat!");
                    }
                }
                else
                {
                    MessageBox.Show("Prenumele nu a fost completat!");
                }
            }
            else
            {
                MessageBox.Show("Numele nu a fost completat!");
            }
        }

        private void Salvare_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Salvare1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Renunta_Click(object sender, EventArgs e)
        {
            EnabledText(false);
        }

        private void Renunta1_Click(object sender, EventArgs e)
        {
            EnabledText(false);
        }
    }
}