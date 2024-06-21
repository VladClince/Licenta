using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class AdministrareApicultor : Form
    {
        private string nameAux;
        private string nameAuxDelete;
        private string stringAux;
        private int id;
        private int key=0;
        private int unsuccess = 0;
        private int choose_ = 0;
        private int apicultoriEvidenta_ = 1;

        public AdministrareApicultor(int i=0)
        {
            InitializeComponent();
            EnabledText(false);
            if(i==1)
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamReader sr = File.OpenText(path);
                stringAux = sr.ReadLine();
                sr.Close();
                apicultoriEvidenta();
            }
            welcome();
        }

        public void setKey(int i)
        {
            key = i;
        }

        private void apicultoriEvidenta()
        {
            char[] delimiterChars = { ' ', '-', '\t' };
            string[] numeAux = stringAux.Split(delimiterChars);
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    nameAux = sdr.GetString(4) + " " + sdr.GetString(5);
                    if (numeAux[0] + " " + numeAux[1] == nameAux)
                    {
                        id = sdr.GetInt32(0);
                        nameAuxDelete = sdr.GetString(4) + " " + sdr.GetString(5);
                        nume.Text = sdr.GetString(4);
                        prenume.Text = sdr.GetString(5);
                        cnp.Text = sdr.GetString(6);
                        adresa.Text = sdr.GetString(8);
                        telefon.Text = sdr.GetString(9);
                        nrFisa.Text = sdr.GetString(7);
                        asigurat.Text = sdr.GetString(14);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void welcome()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5));
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
            nrFisa.Enabled = b;
            asigurat.Enabled = b;

            Editeaza.Enabled = !b;
            Editeaza1.Enabled = !b;
            Sterge.Enabled = !b;
            Sterge1.Enabled = !b;
            Salvare.Enabled = b;
            Salvare1.Enabled = b;
            Renunta.Enabled = b;
            Renunta1.Enabled = b;
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
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        nameAux = sdr.GetString(4) + " " + sdr.GetString(5);
                        if (listBox.SelectedItem.ToString() == nameAux)
                        {
                            id = sdr.GetInt32(0);
                            nameAuxDelete = sdr.GetString(4) + " " + sdr.GetString(5);
                            nume.Text = sdr.GetString(4);
                            prenume.Text = sdr.GetString(5);
                            cnp.Text = sdr.GetString(6);
                            adresa.Text = sdr.GetString(8);
                            telefon.Text = sdr.GetString(9);
                            nrFisa.Text = sdr.GetString(7).ToString();
                            asigurat.Text = sdr.GetString(14);
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

        private void Deconectare_Click(object sender, EventArgs e)
        {
            if(key == choose_)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (key == apicultoriEvidenta_)
            {
                ApicultorEvidenta ob = new ApicultorEvidenta();
                ob.Show();
                this.Hide();
            }
        }

        private void InapoiLabel_Click(object sender, EventArgs e)
        {
            if (key == choose_)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (key == apicultoriEvidenta_)
            {
                ApicultorEvidenta ob = new ApicultorEvidenta();
                ob.Show();
                this.Hide();
            }
        }

        private void Editeaza_Click(object sender, EventArgs e)
        {
            EnabledText(true);
        }

        private void Editeaza1_Click(object sender, EventArgs e)
        {
            EnabledText(true);
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
                        cmd.CommandText = @"delete from pacient where idpacient='" + id + "'";
                        cmd.Connection = conn;

                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i == unsuccess)
                        {
                            MessageBox.Show("Angajatul nu a putut fi sters. Contactati echipa de suport pentru remediere!");
                            AdministrareApicultor ob = new AdministrareApicultor();
                            ob.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Angajatul a fost sters din baza de date!");
                            AdministrareApicultor ob = new AdministrareApicultor();
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

        private void Sterge1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void save()
        {
            if (nume.Text != "")
            {
                if (prenume.Text != "")
                {
                    if (cnp.Text != "")
                    {
                        if (nrFisa.Text != "")
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
                                        if(asigurat.Text == "Nu")
                                        {
                                            cmd.CommandText = @"update pacient set nume='" + nume.Text + "', prenume='" + prenume.Text + "', cnp='" + cnp.Text + "', nr_fisa='" + nrFisa.Text + "', adresa='" + adresa.Text + "', telefon='" + telefon.Text + "', asigurare='" + asigurat.Text + "', sendMail='" + "Nu" + "' where idpacient='" + id + "' ";
                                        }
                                        else
                                        {
                                            cmd.CommandText = @"update pacient set nume='" + nume.Text + "', prenume='" + prenume.Text + "', cnp='" + cnp.Text + "', nr_fisa='" + nrFisa.Text + "', adresa='" + adresa.Text + "', telefon='" + telefon.Text + "', asigurare='" + asigurat.Text + "', sendMail='" + "Da" + "' where idpacient='" + id + "' ";
                                        }
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
                            MessageBox.Show("Numarul de fisa nu a fost completat!");
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

        private void datePersonale_Click(object sender, EventArgs e)
        {
            EnabledText(false);
        }

        private void Renunta1_Click(object sender, EventArgs e)
        {
            EnabledText(false);
        }
    }
}
