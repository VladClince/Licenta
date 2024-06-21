using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BeeSoft
{
    public partial class ConsultatieCurenta : Form
    {
        private int success = 1;
        private int idKeyChoose = 1;
        private int idKeyApicultor = 2;
        private int id;
        private int key;
        private string nume;
        private string numeDoctor;
        
        public void setKey(int k)
        {
            key = k;
        }
        public ConsultatieCurenta(string nm)
        {
            InitializeComponent();
            nume = nm;
            string path = @"D:\An 3\Licenta\Folder\Logare\Logare.txt";
            StreamReader sr = File.OpenText(path);
            numeDoctor = sr.ReadLine();
            sr.Close();
            numeMedic.Enabled = false;
            numeMedic.Text = numeDoctor.ToString();
        }

        void findName()
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
                    string aux = sdr.GetString(4) + " " + sdr.GetString(5);
                    if (nume == aux)
                    {
                        id = sdr.GetInt32(0);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert()
        {
            if (diagnosticPrincipal.Text != "")
            {
                if (tratament.Text != "")
                {
                    if (ora.Text != "" && minute.Text != "")
                    {
                        if (inaltime.Text != "")
                        {
                            if (greutate.Text != "")
                            {
                                if (durataSimptom.Text != "")
                                {
                                    findName();
                                    MySql.Data.MySqlClient.MySqlConnection conn;
                                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                    try
                                    {
                                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                        conn.Open();
                                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into consultatie(id_pacient,nume_medic,data_consultatie,locul_consultatiei,ora,motivul,numar_registru,asigurat,diagnostic,durata_siptom,tratament,alte_simptome) values(@id_pacient,@nume_medic,@data_consultatie,@locul_consultatiei,@ora,@motivul,@numar_registru,@asigurat,@diagnostic,@durata_siptom,@tratament,@alte_simptome)", conn);
                                        cmd.Connection = conn;

                                        cmd.Parameters.AddWithValue("@id_pacient", id);
                                        cmd.Parameters.AddWithValue("@nume_medic", numeMedic.Text);
                                        cmd.Parameters.AddWithValue("@data_consultatie", dataConsult.Text);
                                        if (Cabinet.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@locul_consultatiei", Cabinet.Text);
                                        }
                                        else if (Domiciliu.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@locul_consultatiei", Domiciliu.Text);
                                        }
                                        cmd.Parameters.AddWithValue("@ora", ora.Text + ":" + minute.Text);
                                        if (Angajare.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@motivul", Angajare.Text);
                                        }
                                        else if (ControlPeriodic.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@motivul", ControlPeriodic.Text);
                                        }
                                        cmd.Parameters.AddWithValue("@numar_registru", int.Parse(inaltime.Text));
                                        cmd.Parameters.AddWithValue("@asigurat", greutate.Text);
                                        cmd.Parameters.AddWithValue("@diagnostic", diagnosticPrincipal.Text);
                                        cmd.Parameters.AddWithValue("@durata_siptom", durataSimptom.Text);
                                        cmd.Parameters.AddWithValue("@tratament", tratament.Text);
                                        cmd.Parameters.AddWithValue("@alte_simptome", alteSimptome.Text);

                                        int i = cmd.ExecuteNonQuery();

                                        conn.Close();

                                        if (i == success)
                                        {
                                            MessageBox.Show("Controlul periodic a fost adaugata cu succes!");
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
                                            MessageBox.Show("A aparut o problema la adaugare! Consultatii echipa tehnica pentru remediere.");
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
                                    MessageBox.Show("Nu a-ti completat durata simptomului!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu a-ti completat greutatea!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu a-ti completat inaltimea!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu a-ti completat ora!");
                    }
                }
                else
                {
                    MessageBox.Show("Nu a-ti completat tratamentul!");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti completat diagnosticul principal!");
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            insert();
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

        private void ok1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            back();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}