using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;
namespace BeeSoft
{
    public partial class Apicultor : Form
    {
        private int idChooseFisaPat = 1;
        private int idChooseIstConsult = 2;
        private int idChooseIstMed = 3;
        private int idKeyChoose = 0;
        private int idKeyPatEvid = 1;
        private int idKeyRegConsult = 3;
        private int idKeyRegProg = 4;
        private int idSetBack = 1;
        private int idSetKeySecond = 2;
        private DateTime searchBegin;
        private DateTime searchEnd;
        private DateTime searchBeginDB;
        private DateTime searchEndDB;
        private int idApicultor;
        private int idEmployee;
        private int length_cnp=13;
        private int id;
        private int key = 0;
        private string nume;
        private string nume_consultatie=null;
        private string nume_aux_final = null;
        private string numeDoctor;
        private string theLastDateConsultation = null;
        private string affection = null;

        public void setNameDoctor(string nm)
        {
            numeDoctor=nm;
            findIdEmployee();
        }

        public void hideFisa()
        {
            alege.Hide();
            alege1.Hide();
            data1.Hide();
            data2.Hide();
            sorteaza.Hide();

            alegeComboBox.Hide();
            chooseDataBegin.Hide();
            chooseDataFinal.Hide();
            sortComboBox.Hide();

            Cauta.Hide();
            Cauta1.Hide();
        }

        public void showFisa()
        {
            alege.Show();
            alege1.Show();
            data1.Show();
            data2.Show();
            sorteaza.Show();

            alegeComboBox.Show();
            chooseDataBegin.Show();
            chooseDataFinal.Show();
            sortComboBox.Show();

            Cauta.Show();
            Cauta1.Show();
        }

        public void setName()
        {
            string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
            StreamReader sr = File.OpenText(path);
            nume = sr.ReadLine();
            sr.Close();
            char[] delimiterChars = { ' ', '\t', '\n'};
            string[] nume_aux = nume.Split(delimiterChars);

            if (nume_aux[2].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1];
            }
            else if (nume_aux[3].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1] + " " + nume_aux[2];
            }
            else if (nume_aux[4].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1] + " " + nume_aux[2] + " " + nume_aux[3];
            }
            else if (nume_aux[5].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1] + " " + nume_aux[2] + " " + nume_aux[3] + " " + nume_aux[4];
            }
        }

        private void findApicultor()
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
                    if (nume_aux_final == aux)
                    {
                        listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5));
                        listBox.Items.Add("");
                        listBox.Items.Add("");
                        listBox.Items.Add("Codul numeric personal: " + "\t\t" + sdr.GetString(6));
                        listBox.Items.Add("");
                        listBox.Items.Add("Numarul de fisa: " + "\t\t\t" + sdr.GetString(7));
                        listBox.Items.Add("");
                        listBox.Items.Add("Adresa: " + "\t\t\t\t" + sdr.GetString(8));
                        listBox.Items.Add("");
                        listBox.Items.Add("Numarul de telefon: " + "\t\t" + sdr.GetString(9));
                        listBox.Items.Add("");
                        listBox.Items.Add("Data ultimului control periodic: " + "\t" + theLastDateConsultation);
                        listBox.Items.Add("");
                        listBox.Items.Add("Afectiunii: " + "\t\t\t" + affection);
                        listBox.Items.Add("");
                        listBox.Items.Add("Locul si data nasterii: " + "\t\t" + sdr.GetString(10) + " - " + sdr.GetString(15));
                        listBox.Items.Add("");
                        listBox.Items.Add("Nationalitate: " + "\t\t\t" + sdr.GetString(11) + "\t\t\t Cetatenie: " + " " + sdr.GetString(12));
                        listBox.Items.Add("");
                        listBox.Items.Add("Ocupatie: " + "\t\t\t" + sdr.GetString(13) + "\t\t\t Sex: " + " " + sdr.GetString(17));
                        listBox.Items.Add("");
                        listBox.Items.Add("Asigurare: " + "\t\t\t" + sdr.GetString(14));
                        listBox.Items.Add("");
                        listBox.Items.Add("Email: " + "\t\t\t\t" + sdr.GetString(16));

                        if (!(sdr.IsDBNull(18)))
                        {
                            Imagine.Visible = true;
                            Imagine1.Visible = true;
                        }
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Apicultor()
        {
            InitializeComponent();
            Imagine.Visible = false;
            Imagine1.Visible = false;
            setName();
            findIdApicultor();
            findTheLastDateConsultation();
            findAffection();
            findApicultor();
            hideFisa();
            System.IO.File.Copy(@"D:\An 3\Licenta\BeeSoft\licenta.sql", @"D:\An 3\Licenta\Site Apicultor\licenta.sql", true);
        }

        public void setKey(int i)
        {
            key = i;
        }

        private void findIdApicultor()
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
                    string auxName = sdr.GetString(4) + " " + sdr.GetString(5);
                    if (nume_aux_final == auxName)
                    {
                        idApicultor = sdr.GetInt32(0);
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

        private void findIdEmployee()
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
                    string auxName = sdr.GetString(1) + " " + sdr.GetString(2);
                    if (numeDoctor == auxName)
                    {
                        idEmployee = sdr.GetInt32(0);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findId()
        {
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
                    if (id == sdr.GetInt32(1))
                    {
                        id = sdr.GetInt32(1);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findName()
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
                    if (nume_aux_final == aux)
                    {
                        nume_consultatie = aux;
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

        private void findTheLastDateConsultation()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select id_pacient, data_consultatie from consultatie", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (id == sdr.GetInt32(0))
                    {
                        theLastDateConsultation = sdr.GetString(1);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findAffection()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select id_pacient, diagnostic_clinic from diagnostice", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (id == sdr.GetInt32(0))
                    {
                        if(affection == null)
                        {
                            affection = sdr.GetString(1);
                        }
                        else
                        {
                            affection += ", " + sdr.GetString(1);
                        }
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void date_personale()
        {

            listBox.Show();
            hideFisa();
            listBox.Items.Clear();
            char[] delimiterChars = { ' ', '\t' };
            string[] nume_aux = nume.Split(delimiterChars);
            if (nume_aux[2].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1];
            }
            else if (nume_aux[3].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1];
            }
            else if (nume_aux[4].Length == length_cnp && nume_aux[2] == "")
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1];
            }
            else if (nume_aux[4].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1] + " " + nume_aux[2] + " " + nume_aux[3];
            }
            else if (nume_aux[5].Length == length_cnp)
            {
                nume_aux_final = nume_aux[0] + " " + nume_aux[1] + " " + nume_aux[2] + " " + nume_aux[3];
            }
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
                    if (nume_aux_final == aux)
                    {
                        listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5));
                        listBox.Items.Add("");
                        listBox.Items.Add("");
                        listBox.Items.Add("Codul numeric personal: " + "\t\t" + sdr.GetString(6));
                        listBox.Items.Add("");
                        listBox.Items.Add("Numarul de fisa: " + "\t\t\t" + sdr.GetString(7));
                        listBox.Items.Add("");
                        listBox.Items.Add("Adresa: " + "\t\t\t\t" + sdr.GetString(8));
                        listBox.Items.Add("");
                        listBox.Items.Add("Numarul de telefon: " + "\t\t" + sdr.GetString(9));
                        listBox.Items.Add("");
                        listBox.Items.Add("Data ultimului control periodic: " + "\t" + theLastDateConsultation);
                        listBox.Items.Add("");
                        listBox.Items.Add("Afectiunii: " + "\t\t\t" + affection);
                        listBox.Items.Add("");
                        listBox.Items.Add("Locul si data nasterii: " + "\t\t" + sdr.GetString(10) + " - " + sdr.GetString(15));
                        listBox.Items.Add("");
                        listBox.Items.Add("Nationalitate: " + "\t\t\t" + sdr.GetString(11) + "\t\t\t Cetatenie: " + " " + sdr.GetString(12));
                        listBox.Items.Add("");
                        listBox.Items.Add("Ocupatie: " + "\t\t\t" + sdr.GetString(13) + "\t\t\t Sex: " + " " + sdr.GetString(17));
                        listBox.Items.Add("");
                        listBox.Items.Add("Asigurare: " + "\t\t\t" + sdr.GetString(14));
                        listBox.Items.Add("");
                        listBox.Items.Add("Email: " + "\t\t\t\t" + sdr.GetString(16));
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datePersonale_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void datePersonale1_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void Consultatii2_Click(object sender, EventArgs e)
        {
            ConsultatieCurenta ob = new ConsultatieCurenta(nume_aux_final);
            ob.setKey(idSetKeySecond);
            ob.Show();
            this.Hide();
        }

        private void ConsultatieCurentaLabel_Click(object sender, EventArgs e)
        {
            ConsultatieCurenta ob = new ConsultatieCurenta(nume_aux_final);
            ob.setKey(idSetKeySecond);
            ob.Show();
            this.Hide();
        }

        private void BiletTrimitere_Click(object sender, EventArgs e)
        {
            BiletTrimitere ob = new BiletTrimitere(nume_aux_final);
            ob.setKey(idApicultor);
            ob.setBack(idSetBack);
            ob.Show();
            this.Hide();
        }

        private void BiletInvestigatii_Click(object sender, EventArgs e)
        {
            readIstoricMedicale();
        }

        private void FisaPacient_Click(object sender, EventArgs e)
        {
            listBox.Hide();
            showFisa();
        }

        private void Fisiere_Click(object sender, EventArgs e)
        {
            Fisiere ob = new Fisiere(nume_aux_final);
            ob.Show();
            this.Hide();
        }

        private void Fisiere1_Click(object sender, EventArgs e)
        {
            Fisiere ob = new Fisiere(nume_aux_final);
            ob.Show();
            this.Hide();
        }

        private void Consultatii_Click(object sender, EventArgs e)
        {
            readIstoricConsult();
        }

        private void Consultatii1_Click(object sender, EventArgs e)
        {
            readIstoricConsult();
        }

        private void back()
        {
            if (key == idKeyChoose)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (key == idKeyPatEvid)
            {
                ApicultorEvidenta ob = new ApicultorEvidenta();
                ob.Show();
                this.Hide();
            }
            else if (key == idKeyRegConsult)
            {
                RegistruConsultatii ob = new RegistruConsultatii();
                ob.Show();
                this.Hide();
            }
            else if (key == idKeyRegProg)
            {
                RegistruProgramari ob = new RegistruProgramari();
                ob.Show();
                this.Hide();
            }
        }

        private void Deconectare_Click(object sender, EventArgs e)
        {
            back();
        }

        private void InapoiLabel_Click(object sender, EventArgs e)
        {
            back();
        }

        private void diagnostice()
        {
            listBox.Show();
            hideFisa();
            listBox.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (id == sdr.GetInt32(1))
                    {
                        listBox.Items.Add(nume_aux_final);
                        listBox.Items.Add("");
                        listBox.Items.Add("Numele specialistului: " + numeDoctor);
                        listBox.Items.Add("");
                        listBox.Items.Add("Cod diagnostic: " + sdr.GetString(3));
                        listBox.Items.Add("");
                        listBox.Items.Add("Diagnostic clinic: " + sdr.GetString(4));
                        listBox.Items.Add("");
                        listBox.Items.Add("Tip boala: " + sdr.GetString(5));
                        listBox.Items.Add("");
                        listBox.Items.Add("Data identificare: " + sdr.GetString(6));
                        listBox.Items.Add("");
                        listBox.Items.Add("Stare boala: " + sdr.GetString(7));
                        listBox.Items.Add("");
                        listBox.Items.Add("Observatii: " + sdr.GetString(8));
                        listBox.Items.Add("----------------------------------------------------------------");
                        listBox.Items.Add("");
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Diagnostice_Click(object sender, EventArgs e)
        {
            diagnostice();
        }

        private void Diagnostice1_Click(object sender, EventArgs e)
        {
            diagnostice();
        }

        private void diagnostice2b_Click(object sender, EventArgs e)
        {
            DiagnosticCurent ob = new DiagnosticCurent(nume_aux_final);
            ob.setKey(idSetKeySecond);
            ob.setName(idApicultor, idEmployee);
            ob.Show();
            this.Hide();
        }

        private void diagnostice2a_Click(object sender, EventArgs e)
        {
            DiagnosticCurent ob = new DiagnosticCurent(nume_aux_final);
            ob.setKey(idSetKeySecond);
            ob.setName(idApicultor, idEmployee);
            ob.Show();
            this.Hide();
        }

        private void BiletTrimitere1_Click(object sender, EventArgs e)
        {
            BiletTrimitere ob = new BiletTrimitere(nume_aux_final);
            ob.setKey(idApicultor);
            ob.setBack(idSetBack);
            ob.Show();
            this.Hide();
        }

        private void biletInvestigatii1_Click(object sender, EventArgs e)
        {
            readIstoricMedicale();
        }

        private void FisaPacient1_Click(object sender, EventArgs e)
        {
            listBox.Hide();
            showFisa();
        }

        private void readFisaAngajat()
        {
            if (alegeComboBox.Text == "Controale periodice")
            {
                listBox.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add("Numele specialistului: " + sdr.GetString(2));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data consultatie: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Locul Consultatiei: " + sdr.GetString(4) + " la ora: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Motiv examen clinic: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Inaltime(cm): " + sdr.GetInt32(7) + ", Greutate(kg): " + sdr.GetString(8));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Boli profesionale: " + sdr.GetString(9));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Examene suplimentare necesare: " + sdr.GetString(10));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Antecedente: " + sdr.GetString(11));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Concluzii examen clinic: " + sdr.GetString(12));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add("Numele specialistului: " + sdr.GetString(2));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data consultatie: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Locul Consultatiei: " + sdr.GetString(4) + " la ora: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Motiv examen clinic: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Inaltime(cm): " + sdr.GetInt32(7) + ", Greutate(kg): " + sdr.GetString(8));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Boli profesionale: " + sdr.GetString(9));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Examene suplimentare necesare: " + sdr.GetString(10));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Antecedente: " + sdr.GetString(11));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Concluzii examen clinic: " + sdr.GetString(12));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
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
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add("Numele specialistului: " + sdr.GetString(2));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data consultatie: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Locul Consultatiei: " + sdr.GetString(4) + " la ora: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Motiv examen clinic: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Inaltime(cm): " + sdr.GetInt32(7) + ", Greutate(kg): " + sdr.GetString(8));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Boli profesionale: " + sdr.GetString(9));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Examene suplimentare necesare: " + sdr.GetString(10));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Antecedente: " + sdr.GetString(11));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Concluzii examen clinic: " + sdr.GetString(12));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
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
            else if (alegeComboBox.Text == "Diagnostice")
            {
                listBox.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice order by data_identificare asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add(nume_aux_final);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Numele specialistului: " + numeDoctor);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Cod diagnostic: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Diagnostic clinic: " + sdr.GetString(4));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Tip boala: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data identificare: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Stare boala: " + sdr.GetString(7));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Observatii: " + sdr.GetString(8));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice order by data_identificare desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add(nume_aux_final);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Numele specialistului: " + numeDoctor);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Cod diagnostic: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Diagnostic clinic: " + sdr.GetString(4));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Tip boala: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data identificare: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Stare boala: " + sdr.GetString(7));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Observatii: " + sdr.GetString(8));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
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
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                findName();
                                if (id == sdr.GetInt32(1))
                                {
                                    int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                    if (resultEnd >= 0)
                                    {
                                        listBox.Show();
                                        hideFisa();
                                        listBox.Items.Add(nume_aux_final);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Numele specialistului: " + numeDoctor);
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Cod diagnostic: " + sdr.GetString(3));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Diagnostic clinic: " + sdr.GetString(4));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Tip boala: " + sdr.GetString(5));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Data identificare: " + sdr.GetString(6));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Stare boala: " + sdr.GetString(7));
                                        listBox.Items.Add("");
                                        listBox.Items.Add("Observatii: " + sdr.GetString(8));
                                        listBox.Items.Add("----------------------------------------------------------------");
                                        listBox.Items.Add("");
                                    }
                                }
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
        }

        private void readIstoricConsult()
        {
            listBox.Show();
            hideFisa();
            listBox.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie desc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (id == sdr.GetInt32(1))
                    {
                        listBox.Items.Add("Numele specialistului: " + sdr.GetString(2));
                        listBox.Items.Add("");
                        listBox.Items.Add("Data consultatie: " + sdr.GetString(3));
                        listBox.Items.Add("");
                        listBox.Items.Add("Locul Consultatiei: " + sdr.GetString(4) + " la ora: " + sdr.GetString(5));
                        listBox.Items.Add("");
                        listBox.Items.Add("Motiv examen clinic: " + sdr.GetString(6));
                        listBox.Items.Add("");
                        listBox.Items.Add("Inaltime(cm): " + sdr.GetInt32(7) + ", Greutate(kg): " + sdr.GetString(8));
                        listBox.Items.Add("");
                        listBox.Items.Add("Boli profesionale: " + sdr.GetString(9));
                        listBox.Items.Add("");
                        listBox.Items.Add("Examene suplimentare necesare: " + sdr.GetString(10));
                        listBox.Items.Add("");
                        listBox.Items.Add("Antecedente: " + sdr.GetString(11));
                        listBox.Items.Add("");
                        listBox.Items.Add("Concluzii examen clinic: " + sdr.GetString(12));
                        listBox.Items.Add("----------------------------------------------------------------");
                        listBox.Items.Add("");
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readIstoricMedicale()
        {
            listBox.Show();
            hideFisa();
            listBox.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (id == sdr.GetInt32(1))
                    {
                        listBox.Items.Add(nume_aux_final);
                        listBox.Items.Add("");
                        listBox.Items.Add("Numele specialistului: " + numeDoctor);
                        listBox.Items.Add("");
                        listBox.Items.Add("Cod diagnostic: " + sdr.GetString(3));
                        listBox.Items.Add("");
                        listBox.Items.Add("Diagnostic clinic: " + sdr.GetString(4));
                        listBox.Items.Add("");
                        listBox.Items.Add("Tip boala: " + sdr.GetString(5));
                        listBox.Items.Add("");
                        listBox.Items.Add("Data identificare: " + sdr.GetString(6));
                        listBox.Items.Add("");
                        listBox.Items.Add("Stare boala: " + sdr.GetString(7));
                        listBox.Items.Add("");
                        listBox.Items.Add("Observatii: " + sdr.GetString(8));
                        listBox.Items.Add("----------------------------------------------------------------");
                        listBox.Items.Add("");
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChooseFavorite(int idChooseFavorite)
        {
            if(idChooseFavorite == idChooseFisaPat)
            {
                readFisaAngajat();
            }
            else if(idChooseFavorite == idChooseIstConsult)
            {
                readIstoricConsult();
            }
            else if(idChooseFavorite == idChooseIstMed)
            {
                readIstoricMedicale();
            }
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            readFisaAngajat();
        }

        private void Cauta1_Click(object sender, EventArgs e)
        {
            readFisaAngajat();   
        }

        private void Imagine_Click(object sender, EventArgs e)
        {
            ImagineApicultor ob = new ImagineApicultor(nume_aux_final);
            ob.Show();
        }

        private void Imagine1_Click(object sender, EventArgs e)
        {
            ImagineApicultor ob = new ImagineApicultor(nume_aux_final);
            ob.Show();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alege1_Click(object sender, EventArgs e)
        {

        }
    }
}