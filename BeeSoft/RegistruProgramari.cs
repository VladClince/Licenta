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
    public partial class RegistruProgramari : Form
    {
        private int unsuccess = 0;
        private int idSetKeyToApicultor = 4;
        private string prenumeAux;
        private string nameFull;
        private string telefon;
        private string mail;
        private string cnpFake = "0000000000000";
        private int id;
        private int countList;
        private string nume;
        char delim = ' ';
        string[] auxInput;
        string[] dateAux;
        public RegistruProgramari()
        {
            InitializeComponent();
            welcome();
            EnablesButton(false);
        }

        private void welcome()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "' order by data asc, ora asc, nume asc, prenume asc", conn);
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
            datePersonale.Enabled = b;
            datePersonale1.Enabled = b;
            contacteaza.Enabled = b;
            contacteaza1.Enabled = b;
            stergeConsultatie.Enabled = b;
            stergeConsultatie1.Enabled = b;
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
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "'", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string aux = sdr.GetString(3) + " - " + sdr.GetString(4) + " " + sdr.GetString(1) + " " + sdr.GetString(2);
                        if (listBox1.SelectedItem.ToString() == aux)
                        {
                            id = sdr.GetInt32(0);
                            prenumeAux = sdr.GetString(2);
                            nameFull = sdr.GetString(1) + " " + sdr.GetString(2);
                            telefon = sdr.GetString(8);
                            mail = sdr.GetString(9);
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

       
        private void dataCurenta_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            char[] delimiterChars = { ' ', '-', '\t' };
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select  * from programari where status='" + "accept" + "' order by data asc, ora asc, nume asc, prenume asc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string textFinal = sdr.GetString(3);
                    int counterText = 0;
                    string textToSearch = "";
                    string textToDB = "";
                    foreach (char a in dataCurenta.Text)
                    {
                        ++counterText;
                        textToSearch += a;

                    }
                    int auxCounter = 0;
                    for (int j = 0; j < textFinal.Length; j++)
                    {
                        ++auxCounter;
                    }

                    for (int i = 0; i < counterText; i++)
                    {
                        if (i < auxCounter)
                        {
                            textToDB += textFinal[i];
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (textToSearch == textToDB)
                    {
                        listBox1.Items.Add(sdr.GetString(3) + " - " + sdr.GetString(4) + " " + sdr.GetString(1) + " " + sdr.GetString(2));
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void oraSearch_TextChanged(object sender, EventArgs e)
        {
            if (oraSearch.Text != "")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select  * from programari where status='" + "accept" + "' order by data asc, ora asc, nume asc, prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(4);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in oraSearch.Text)
                        {
                            ++counterText;
                            textToSearch += a;

                        }
                        int auxCounter = 0;
                        for (int j = 0; j < textFinal.Length; j++)
                        {
                            ++auxCounter;
                        }

                        for (int i = 0; i < counterText; i++)
                        {
                            if (i < auxCounter)
                            {
                                textToDB += textFinal[i];
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (textToSearch == textToDB)
                        {
                            listBox1.Items.Add(sdr.GetString(3) + " - " + sdr.GetString(4) + " " + sdr.GetString(1) + " " + sdr.GetString(2));
                            EnablesButton(true);
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
            else
            {
                listBox1.Items.Clear();
                welcome();
            }
        }

        private void numeSearch_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "'", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    foreach(string s in listBox1.Items)
                    {
                        auxInput = s.Split(delim);
                        nume = sdr.GetString(1) + " " + sdr.GetString(2);
                        dateAux = nume.Split(delim);
                        countList = auxInput.Count();
                        if (numeSearch.Text == auxInput[3] || numeSearch.Text == auxInput[3] + " " + auxInput[4])
                        {
                            if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[1] || numeSearch.Text == dateAux[0] + " " + dateAux[1] || numeSearch.Text == nume)
                            {
                                if (dateAux.Count() > 2)
                                {
                                    if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[0] + " " +  dateAux[1] || numeSearch.Text == nume)
                                    {
                                        if (dateAux.Count() > 3)
                                        {
                                            if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[0] + " " + dateAux[1] || numeSearch.Text == dateAux[0] + " " + dateAux[1] + " " + dateAux[2] || numeSearch.Text == dateAux[0] + " " + dateAux[1] + " " + dateAux[2] + " " + dateAux[3])
                                            {
                                                EnablesButton(true);
                                                listBox.Items.Clear();
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
                                        else
                                        {
                                            EnablesButton(true);
                                            listBox.Items.Clear();
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
                                }
                                else
                                {
                                    EnablesButton(true);
                                    listBox.Items.Clear();
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
                        }
                        else if(countList > 5)
                        {
                            if (numeSearch.Text == auxInput[3] || numeSearch.Text == auxInput[3] + " " + auxInput[4] || numeSearch.Text == auxInput[3] + " " + auxInput[4] + " " + auxInput[5])
                            {
                                if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[1] || numeSearch.Text == dateAux[0] + " " + dateAux[1] || numeSearch.Text == nume)
                                {
                                    if (dateAux.Count() > 2)
                                    {
                                        if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[0] + " " + dateAux[1] || numeSearch.Text == nume)
                                        {
                                            if (dateAux.Count() > 3)
                                            {
                                                if (numeSearch.Text == dateAux[0] || numeSearch.Text == dateAux[0] + " " + dateAux[1] || numeSearch.Text == dateAux[0] + " " + dateAux[1] + " " + dateAux[2] || numeSearch.Text == dateAux[0] + " " + dateAux[1] + " " + dateAux[2] + " " + dateAux[3])
                                                {
                                                    EnablesButton(true);
                                                    listBox.Items.Clear();
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
                                            else
                                            {
                                                EnablesButton(true);
                                                listBox.Items.Clear();
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
                                    }
                                    else
                                    {
                                        EnablesButton(true);
                                        listBox.Items.Clear();
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

        private void date_personale()
        {
            char[] delimiterChars = { ' ', '-', '\t' };
            string[] aux1 = prenumeAux.Split(delimiterChars);
            if (aux1.Length < 2)
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(nameFull + "\t" + cnpFake.ToString());
                sw.Close();
            }
            else
            {
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(nameFull + "\t" + cnpFake.ToString());
                sw.Close();
            }
            Apicultor ob = new Apicultor();
            ob.setKey(idSetKeyToApicultor);
            ob.Show();
            this.Hide();
        }

        private void datePersonale_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void datePersonale1_Click(object sender, EventArgs e)
        {
            date_personale();
        }

        private void contacteaza_Click(object sender, EventArgs e)
        {
            ContacteazaProgramari ob = new ContacteazaProgramari(telefon, mail, id);
            ob.Show();
            this.Hide();
        }

        private void contacteaza1_Click(object sender, EventArgs e)
        {
            ContacteazaProgramari ob = new ContacteazaProgramari(telefon,mail, id);
            ob.Show();
            this.Hide();
        }

        private void delete()
        {
            DialogResult result = MessageBox.Show(this, "Sigur doriti sa stergeti programarea angajatului/angajatei " + nameFull.ToString() + " ?", "BeeSoft", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    cmd.CommandText = @"delete from programari where id_programari='" + id + "'";
                    cmd.Connection = conn;

                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i == unsuccess)
                    {
                        MessageBox.Show("Programarea nu a putut fi stearsa. Contactati echipa de suport pentru remediere!");
                        RegistruProgramari ob = new RegistruProgramari();
                        ob.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Programarea a fost stearsa din baza de date!");
                        RegistruProgramari ob = new RegistruProgramari();
                        ob.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                EnablesButton(false);
            }
            else
            {
                EnablesButton(false);
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
    }
}