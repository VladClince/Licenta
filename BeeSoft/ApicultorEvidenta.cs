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
    public partial class ApicultorEvidenta : Form
    {
        private int idSetKeyPrimary = 1;
        private int unsuccess = 0;
        private int id;
        private string nume;
        private string prenume;
        private string cnp;
        public ApicultorEvidenta()
        {
            InitializeComponent();
            EnabledText(false);
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
            System.IO.File.Copy(@"D:\An 3\Licenta\BeeSoft\licenta.sql", @"D:\An 3\Licenta\Site Apicultor\licenta.sql", true);
        }

        private void EnabledText(bool b)
        {
            Editeaza.Enabled = b;
            Editeaza1.Enabled = b;
            Sterge.Enabled = b;
            sterge1.Enabled = b;
            datePacient.Enabled = b;
            datePacient1.Enabled = b;
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
                EnabledText(true);
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (sdr.Read())
                    {
                        string aux = sdr.GetString(4) + " " + sdr.GetString(5);
                        if (listBox.SelectedItem.ToString() == aux)
                        {
                            id = sdr.GetInt32(0);
                            nume = sdr.GetString(4) + " " + sdr.GetString(5);
                            prenume = sdr.GetString(5);
                            cnp = sdr.GetString(6);
                            listBox1.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Codul numeric personal: " + "\t\t" + sdr.GetString(6));
                            listBox1.Items.Add("Numarul de fisa: " + "\t\t\t" + sdr.GetString(7));
                            listBox1.Items.Add("Adresa: " + "\t\t\t\t" + sdr.GetString(8));
                            listBox1.Items.Add("Numarul de telefon: " + "\t\t" + sdr.GetString(9));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Locul nasterii: " + "\t\t\t" + sdr.GetString(10));
                            listBox1.Items.Add("Data nasterii: " + sdr.GetString(15));
                            listBox1.Items.Add("Nationalitate: " + "\t\t\t" + sdr.GetString(11));
                            listBox1.Items.Add("Cetatenie: " + "\t\t\t" + sdr.GetString(12));
                            listBox1.Items.Add("Ocupatie: " + "\t\t\t" + sdr.GetString(13));
                            listBox1.Items.Add("Asigurare: " + "\t\t\t" + sdr.GetString(14));
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

        private void date_personale()
        {
            char[] delimiterChars = { ' ', '-', '\t' };
            string[] aux1 = prenume.Split(delimiterChars);
            if (aux1.Length < 2)
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(listBox.SelectedItem.ToString() + " " + cnp.ToString());
                sw.Close();
            }
            else
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(listBox.SelectedItem.ToString() + " " + cnp.ToString());
                sw.Close();
            }
            Apicultor ob = new Apicultor();
            ob.setKey(idSetKeyPrimary);
            ob.Show();
            this.Hide();
        }

        private void datePersonale_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void datePacient1_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void edit()
        {
            char[] delimiterChars = { ' ', '-', '\t' };
            string[] aux1 = prenume.Split(delimiterChars);
            if (aux1.Length < 2)
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(listBox.SelectedItem.ToString() + "\t\t\t" + cnp.ToString());
                sw.Close();
            }
            else
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(listBox.SelectedItem.ToString() + "\t\t" + cnp.ToString());
                sw.Close();
            }
            AdministrareApicultor ob = new AdministrareApicultor(1);
            ob.setKey(idSetKeyPrimary);
            ob.Show();
            this.Hide();
        }

        private void Editeaza_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void Editeaza1_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void delete()
        {
            DialogResult result = MessageBox.Show(this, "Sigur doriti sa stergeti angajatul " + nume.ToString() + " ?", "BeeSoft", MessageBoxButtons.OKCancel);
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
                    }
                    else
                    {
                        MessageBox.Show("Angajatul a fost sters din baza de date!");
                        ApicultorEvidenta ob = new ApicultorEvidenta();
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

        private void Sterge_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void sterge1_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}