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
    public partial class RegistruConsultatii : Form
    {
        private int unsuccess = 0;
        private int idSetKeyToApicultor = 3;
        private string nume;
        private string prenume;
        private string cnpFake = "0000000000000";
        private int id;
        void afiseazaNume(int id)
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
                    if (sdr.GetInt32(0) == id)
                    {
                        nume = sdr.GetString(4);
                        prenume = sdr.GetString(5);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            System.IO.File.Copy(@"D:\An 3\Licenta\BeeSoft\licenta.sql", @"D:\An 3\Licenta\Site Apicultor\licenta.sql", true);
        }

        public RegistruConsultatii()
        {
            InitializeComponent();
            datePacient.Enabled = false;
            datePacient1.Enabled = false;
            stergeConsultatie.Enabled = false;
            stergeConsultatie1.Enabled = false;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            char[] delimiterChars = { ' ', '-', '\t' };
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie asc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    afiseazaNume(sdr.GetInt32(1));
                    string aux = prenume;
                    string[] aux1 = aux.Split(delimiterChars);
                    if (aux1.Length < 2)
                    {
                        listBox.Items.Add(sdr.GetString(2) + " - " + nume + " " + prenume + " - " + sdr.GetString(3));
                    }
                    else
                    {
                        listBox.Items.Add(sdr.GetString(2) + " - " + nume + " " + prenume + " - " + sdr.GetString(3));
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                datePacient.Enabled = true;
                datePacient1.Enabled = true;
                stergeConsultatie.Enabled = true;
                stergeConsultatie1.Enabled = true;

                listBox1.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        afiseazaNume(sdr.GetInt32(1));
                        string aux = sdr.GetString(2) + " - " + nume + " " + prenume + " - " + sdr.GetString(3);
                        if (listBox.SelectedItem.ToString() == aux)
                        {
                            id = sdr.GetInt32(0);
                            listBox1.Items.Add("Locul Consultatiei: " + sdr.GetString(4) + " la ora: " + sdr.GetString(5));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Data consultatie: " + sdr.GetString(3));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Motiv examen clinic: " + sdr.GetString(6));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Inaltime(cm): " + sdr.GetInt32(7) + ", Greutate(kg): " + sdr.GetString(8));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Boli profesionale: " + sdr.GetString(9));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Examene suplimentare necesare: " + sdr.GetString(10));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Antecedente: " + sdr.GetString(11));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("Concluzii examen clinic: " + sdr.GetString(12));
                            listBox1.Items.Add("----------------------------------------------------------------");
                            listBox1.Items.Add("");
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

        private void RegistruConsultatii_Load(object sender, EventArgs e)
        {

        }

        private void date_apicultor()
        {
            if (listBox.SelectedItem.ToString() != null)
            {
                char[] delimiterChars = { ' ', '-', '\t' };
                string[] aux1 = prenume.Split(delimiterChars);
                if (aux1.Length < 2)
                {
                    string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine(nume + " " + prenume + "\t" + cnpFake.ToString());
                    sw.Close();
                }
                else
                {
                    string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                    StreamWriter sw = File.CreateText(path);
                    sw.WriteLine(nume + " " + prenume + "\t" + cnpFake.ToString());
                    sw.Close();
                }
                Apicultor ob = new Apicultor();
                ob.setKey(idSetKeyToApicultor);
                ob.Show();
                this.Hide();
            }
        }

        private void datePacient_Click(object sender, EventArgs e)
        {
            date_apicultor();
        }

        private void datePacient1_Click(object sender, EventArgs e)
        {
            date_apicultor();
        }

        private void delete()
        {
            if (listBox.SelectedItem.ToString() != null)
            {
                DialogResult result = MessageBox.Show(this, "Sigur doriti sa stergeti controlul periodic?", "BeeSoft", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd.CommandText = @"delete from consultatie where id_consultatie='" + id + "'";
                        cmd.Connection = conn;

                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i == unsuccess)
                        {
                            MessageBox.Show("Controlul periodic nu a putut fi stearsa. Contactati echipa de suport pentru remediere!");
                            RegistruConsultatii ob = new RegistruConsultatii();
                            ob.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Controlul periodic a fost stearsa din baza de date!");
                            RegistruConsultatii ob = new RegistruConsultatii();
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

        private void stergeConsultatie_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void stergeConsultatie1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}