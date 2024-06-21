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
    public partial class DiagnosticCurent : Form
    {
        private int idKeyChoose = 1;
        private int idKeyApicultor = 2;
        private int success = 1;
        private int idApicultor = 0;
        private int idEmployee = 0;
        private int key;
        private string nume;
        private string numeDoctor;

        public void setKey(int k)
        {
            key = k;
        }

        public void setName(int pt, int em)
        {
            this.idApicultor = pt;
            this.idEmployee = em;
        }

        public DiagnosticCurent(string nm)
        {
            InitializeComponent();
            nume = nm;
            string path = @"D:\An 3\Licenta\Folder\Logare\Logare.txt";
            StreamReader sr = File.OpenText(path);
            numeDoctor = sr.ReadLine();
            sr.Close();
        }

        public void findIdApicultor()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select idpacient,nume,prenume from pacient", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string aux = sdr.GetString(1) + " " + sdr.GetString(2);
                    if (aux == nume)
                    {
                        idApicultor = sdr.GetInt32(0);
                    }
                }
                conn.Close();
                findIdEmployee();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void findIdEmployee()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select id_angajat,nume,prenume from angajat", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string aux = sdr.GetString(1) + " " + sdr.GetString(2);
                    if (aux == numeDoctor)
                    {
                        idEmployee = sdr.GetInt32(0);
                    }
                }
                conn.Close();
                insert();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insert()
        {
            if (codDiagnostic.Text != "")
            {
                if (diagnosticClinic.Text != "")
                {
                    if (tipBoala.Text != "")
                    {
                        if (stareBoala.Text != "")
                        {
                            if (observatii.Text != "")
                            {
                                MySql.Data.MySqlClient.MySqlConnection conn;
                                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                try
                                {
                                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                    conn.Open();
                                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into diagnostice(id_pacient,id_angajat,cod_diagnostic,diagnostic_clinic,tip_boala,data_identificare,stare_boala,observatii) values(@id_pacient, @id_angajat, @cod_diagnostic, @diagnostic_clinic, @tip_boala, @data_identificare, @stare_boala, @observatii)", conn);
                                    cmd.Connection = conn;
                                    cmd.Parameters.AddWithValue("@id_pacient", idApicultor);
                                    cmd.Parameters.AddWithValue("@id_angajat", idEmployee);
                                    cmd.Parameters.AddWithValue("@cod_diagnostic", codDiagnostic.Text);
                                    cmd.Parameters.AddWithValue("@diagnostic_clinic", diagnosticClinic.Text);
                                    cmd.Parameters.AddWithValue("@tip_boala", tipBoala.Text.ToString());
                                    cmd.Parameters.AddWithValue("@data_identificare", dataIdentificare.Text.ToString());
                                    cmd.Parameters.AddWithValue("@stare_boala", stareBoala.Text);
                                    cmd.Parameters.AddWithValue("@observatii", observatii.Text);

                                    int i = cmd.ExecuteNonQuery();

                                    conn.Close();

                                    if (i == success)
                                    {
                                        MessageBox.Show("Diagnosticul a fost adaugat cu succes!");
                                        if (key == idKeyChoose)
                                        {
                                            Choose ob = new Choose();
                                            ob.Show();
                                            this.Hide();
                                        }
                                        else if (key == idKeyApicultor)
                                        {
                                            Apicultor ob = new Apicultor();
                                            ob.Show();
                                            this.Hide();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Diagnosticul nu a putut fi adaugat. Contactati echipa de suport pentru remediere!");
                                        if (key == idKeyChoose)
                                        {
                                            Choose ob = new Choose();
                                            ob.Show();
                                            this.Hide();
                                        }
                                        else if (key == idKeyApicultor)
                                        {
                                            Apicultor ob = new Apicultor();
                                            ob.Show();
                                            this.Hide();
                                        }
                                    }
                                    conn.Close();
                                }
                                catch (MySql.Data.MySqlClient.MySqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Campul \"observatii\" nu este completat!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Starea bolii nu a fost completata!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tipul bolii nu a fost completat!");
                    }
                }
                else
                {
                    MessageBox.Show("Diagnosticul clinic nu a fost completat!");
                }
            }
            else
            {
                MessageBox.Show("Codul diagnosticului nu a fost completat!");
            }
        }

        private void done()
        {
            if (idApicultor > 0 && idEmployee > 0)
            {
                insert();
            }
            else if (idApicultor == 0 && idEmployee == 0)
            {
                findIdApicultor();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            done();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            done();
        }

        private void back()
        {
            if (key == idKeyChoose)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (key == idKeyApicultor)
            {
                Apicultor ob = new Apicultor();
                ob.Show();
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            back();
        }
    }
}