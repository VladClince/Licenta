using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Net.Mail;

namespace BeeSoft
{
    public partial class Choose : Form
    {
        private int idSetBack = 0;
        private int idSetKeyPrimary = 0;
        private int idSetKeySecondary = 1;
        private int idChooseFavoriteFisaApicultor = 1;
        private int idChooseFavoriteIstConsult = 2;
        private int idChooseFavoriteIstMed = 3;
        private int idChooseFavoriteIstRetete = 4;
        private int idForUser = 0;
        private int idForAdmin = 1;
        private int idDoctor = 0;
        private int counterRadioState = 0;
        private static int count=0;
        private static int k = 11;
        private static int c;
        private string name;
        private const int counterConst = 4;
        private string[] aux = new string[4];
        private int counterRadio1 = 0;
        private int counterRadio2 = 0;
        private int counterRadio3 = 0;
        private int counterRadio4 = 0;
        private void setName()
        {
            string path = @"D:\An 3\Licenta\Folder\Logare\Logare.txt";
            StreamReader sr = File.OpenText(path);
            name = sr.ReadLine();
            sr.Close();
            System.IO.File.Copy(@"D:\An 3\Licenta\BeeSoft\licenta.sql", @"D:\An 3\Licenta\Site Apicultor\licenta.sql", true);
        }

        public Choose()
        {
            InitializeComponent();
            setName();
            findIdDoctor();
            welcome();
            RadioButton1.Select();
            count = 0;
            construct();
            favorite();
            checkInsurance();
        }

        private void checkInsurance()
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
                    string auxName_ = sdr.GetString(4) + " " + sdr.GetString(5);
                    int auxId_ = sdr.GetInt32(0);
                    if (sdr.GetString(14) == "Nu" && ((sdr.IsDBNull(19)) || sdr.GetString(19) != "Da"))
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 587;
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("sebyany14@gmail.com", "timisoara1995");

                        System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("vlad.alexandru.clince@gmail.com", sdr.GetString(16), "BeeSoft", "Va informam ca in baza de date a CNAS nu mai figurati ca si asigurat! In caz afirmativ ignorati acest mesaj, iar in caz contrar va rugam sa verificati acest lucru la Casa Nationala de Asigurari de Sanatate!\n\n Cu respect, Bee Soft!");
                        mm.BodyEncoding = UTF8Encoding.UTF8;
                        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                        client.Send(mm);
                        notifyDoctor(auxName_);
                        updateSendMail(auxId_);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateSendMail(int id_)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                        cmd.CommandText = @"update pacient set sendMail='" + "Da" + "' where idpacient='" + id_ + "' ";
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
        }

        private void notifyDoctor(string name_)
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
                    if (sdr.GetString(1) + " " + sdr.GetString(2) == name)
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 587;
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("sebyany14@gmail.com", "timisoara1995");

                        System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("vlad.alexandru.clince@gmail.com", sdr.GetString(8), "BeeSoft", "Va informam ca in baza de date a CNAS nu mai figureaza ca si asigurat " + name_ + "!");
                        mm.BodyEncoding = UTF8Encoding.UTF8;
                        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                        client.Send(mm);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findIdDoctor()
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
                    if(aux == name)
                    {
                        idDoctor = sdr.GetInt32(0);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void favorite()
        {
            string path = @"D:\An 3\Licenta\Folder\Fisiere pentru salvare\ComenziFavorite.txt";
            StreamReader sr = File.OpenText(path);
            for (int i = 0; i < counterConst; i++)
            {
                aux[i] = sr.ReadLine();
            }
            for (int i = 0; i < counterConst; i++)
            {
                if (aux[i] == "Adeverinta Noua")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Adeverinta Noua";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Adeverinta Noua";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Adeverinta Noua";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Istoric diagnostice")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Istoric diagnostice";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Istoric diagnostice";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Istoric diagnostice";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Bilet Trimitere")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Bilet Trimitere";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Bilet Trimitere";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Bilet Trimitere";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Control periodic nou")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Control periodic nou";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Control periodic nou";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Control periodic nou";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Deschide fisa curenta")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Deschide fisa curenta";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Deschide fisa curenta";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Deschide fisa curenta";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Diagnostic nou")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Diagnostic nou";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Diagnostic nou";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Diagnostic nou";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Fisa Angajat")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Fisa Angajat";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Fisa Angajat";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Fisa Angajat";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Fisiere")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Fisiere";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Fisiere";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Fisiere";
                        ++counterRadio3;
                    }
                }
                if (aux[i] == "Istoric controale periodice")
                {
                    if (counterRadio1 == counterRadioState)
                    {
                        RadioButton1.Text = "Istoric controale periodice";
                        ++counterRadio1;
                    }
                    else if (counterRadio2 == counterRadioState)
                    {
                        RadioButton2.Text = "Istoric controale periodice";
                        ++counterRadio2;
                    }
                    else if (counterRadio3 == counterRadioState)
                    {
                        RadioButton3.Text = "Istoric controale periodice";
                        ++counterRadio3;
                    }
                }
            }
            sr.Close();
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
                    string aux = sdr.GetString(1) + " " + sdr.GetString(2);
                    if(aux==name)
                    {
                        if(aux != "Administrator Administrator")
                        {
                            adaugaAngajat.Visible = false;
                            adaugaAngajat1.Visible = false;
                            managementUser.Visible = false;
                            managementUser1.Visible = false;
                            numeAngajat.Text = aux + "!";
                        }
                        else
                        {
                            pacientNou.Visible = false;
                            pacientNou1.Visible = false;
                            adaugaPacient.Visible = false;
                            adaugaPacient1.Visible = false;
                            numeAngajat.Text ="Administrator!";
                        }
                    }
                }
                conn.Close();
                nrPacienti.Text = count.ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ++count;
        }

        private void construct()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            char[] delimiterChars = { ' ', '-', '\t' };
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient order by nume,prenume asc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    ++count;
                    string aux = sdr.GetString(5);
                    string auxName=sdr.GetString(4);
                    string[] aux1 = aux.Split(delimiterChars);
                    if (count <= 11)
                    {
                        if (aux1.Length < 2)
                        {
                            if((auxName.Count() + aux.Count()) < 10 && auxName.Count() <=5)
                            {
                                listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t\t" + sdr.GetString(6));
                            }
                            else
                            {
                                listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                            }
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                }
                conn.Close();
                nrPacienti.Text = count.ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ++count;
        }

        private void search()
        {
            listBox.Items.Clear();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            int c = 0;
            char[] delimiterChars = { ' ', '-', '\t' };
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient order by nume,prenume asc", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (nume.Text == sdr.GetString(5))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                    else if (prenume.Text == sdr.GetString(5))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                    else if (cnp.Text == sdr.GetString(6))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                    else if (nrFisa.Text == sdr.GetString(7))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                    else if (telefon.Text == sdr.GetString(9))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                    else if (dateConsult.Text == sdr.GetString(15))
                    {
                        ++c;
                        nrPacienti.Text = c.ToString();
                        string aux = sdr.GetString(5);
                        string[] aux1 = aux.Split(delimiterChars);
                        if (aux1.Length < 2)
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                        }
                        else
                        {
                            listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                        }
                    }
                }
                if (c == 0)
                {
                    MessageBox.Show("Nu exista acest apicultor in baza de date!");
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
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            search();
        }

        private void pacientiEvidenta_Click(object sender, EventArgs e)
        {
            ApicultorEvidenta ob = new ApicultorEvidenta();
            ob.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string nameApicultorFinal = null;
                string cnpAux = null;
                string nameApicultor = listBox.SelectedItem.ToString();
                char[] delim = {' ', '\t'};
                string[] nameApicultorAux = nameApicultor.Split(delim);
                if(nameApicultorAux[2].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1];
                    cnpAux = nameApicultorAux[2];
                }
                else if (nameApicultorAux[1].Length > 2 && nameApicultorAux[2].Length <= 2 && nameApicultorAux[3].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1];
                    cnpAux = nameApicultorAux[3];
                }
                else if (nameApicultorAux[2].Length > 2 && nameApicultorAux[3].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2];
                    cnpAux = nameApicultorAux[3];
                }
                else if (nameApicultorAux[1].Length > 2 && nameApicultorAux[2].Length <= 2 && nameApicultorAux[4].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1];
                    cnpAux = nameApicultorAux[4];
                }
                else if (nameApicultorAux[2].Length > 2 && nameApicultorAux[3].Length <= 2 && nameApicultorAux[4].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2];
                    cnpAux = nameApicultorAux[4];
                }
                else if (nameApicultorAux[3].Length > 2 && nameApicultorAux[4].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2] + " " + nameApicultorAux[3];
                    cnpAux = nameApicultorAux[4];
                }
                else if (nameApicultorAux[1].Length > 2 && nameApicultorAux[2].Length <= 2 && nameApicultorAux[5].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1];
                    cnpAux = nameApicultorAux[5];
                }
                else if (nameApicultorAux[2].Length > 2 && nameApicultorAux[3].Length <= 2 && nameApicultorAux[5].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2];
                    cnpAux = nameApicultorAux[5];
                }
                else if (nameApicultorAux[3].Length > 2 && nameApicultorAux[4].Length <= 2 && nameApicultorAux[5].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2] + " " + nameApicultorAux[3];
                    cnpAux = nameApicultorAux[5];
                }
                else if (nameApicultorAux[4].Length > 2 && nameApicultorAux[5].Length == 13)
                {
                    nameApicultorFinal = nameApicultorAux[0] + " " + nameApicultorAux[1] + " " + nameApicultorAux[2] + " " + nameApicultorAux[3] + " " + nameApicultorAux[4];
                    cnpAux = nameApicultorAux[5];
                }
                string path = @"D:\An 3\Licenta\Folder\Apicultor\Info.txt";
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(nameApicultorFinal + " " + cnpAux);
                sw.Close();
                string s = listBox.SelectedItem.ToString();
                if (s != null)
                {
                    if (RadioButton3.Checked == true)
                    {
                        if (RadioButton3.Text == "Istoric diagnostice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstMed);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Bilet Trimitere")
                        {
                            BiletTrimitere ob = new BiletTrimitere(nameApicultorFinal);
                            ob.setKey(idSetKeyPrimary);
                            ob.setBack(idSetBack);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Control periodic nou")
                        {
                            ConsultatieCurenta ob = new ConsultatieCurenta(name);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Deschide fisa curenta")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Diagnostic nou")
                        {
                            DiagnosticCurent ob = new DiagnosticCurent(nameApicultorFinal);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Fisa Angajat")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteFisaApicultor);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Fisiere")
                        {
                            Fisiere ob = new Fisiere(nameApicultorFinal);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton3.Text == "Istoric controale periodice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstConsult);
                            ob.Show();
                            this.Hide();
                        }
                    }
                    else if (RadioButton2.Checked == true)
                    {
                        if (RadioButton2.Text == "Istoric diagnostice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstMed);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Bilet Trimitere")
                        {
                            BiletTrimitere ob = new BiletTrimitere(nameApicultorFinal);
                            ob.setKey(idSetKeyPrimary);
                            ob.setBack(idSetBack);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Control periodic nou")
                        {
                            ConsultatieCurenta ob = new ConsultatieCurenta(name);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Deschide fisa curenta")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Diagnostic nou")
                        {
                            DiagnosticCurent ob = new DiagnosticCurent(nameApicultorFinal);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Fisa Angajat")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteFisaApicultor);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Fisiere")
                        {
                            Fisiere ob = new Fisiere(nameApicultorFinal);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton2.Text == "Istoric controale periodice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstConsult);
                            ob.Show();
                            this.Hide();
                        }
                    }
                    else if (RadioButton1.Checked == true)
                    {
                        if (RadioButton1.Text == "Istoric diagnostice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstMed);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Bilet Trimitere")
                        {
                            BiletTrimitere ob = new BiletTrimitere(nameApicultorFinal);
                            ob.setKey(idSetKeyPrimary);
                            ob.setBack(idSetBack);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Control periodic nou")
                        {
                            ConsultatieCurenta ob = new ConsultatieCurenta(name);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Deschide fisa curenta")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Diagnostic nou")
                        {
                            DiagnosticCurent ob = new DiagnosticCurent(nameApicultorFinal);
                            ob.setKey(idSetKeySecondary);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Fisa Angajat")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteFisaApicultor);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Fisiere")
                        {
                            Fisiere ob = new Fisiere(nameApicultorFinal);
                            ob.Show();
                            this.Hide();
                        }
                        else if (RadioButton1.Text == "Istoric controale periodice")
                        {
                            Apicultor ob = new Apicultor();
                            ob.setNameDoctor(name);
                            ob.ChooseFavorite(idChooseFavoriteIstConsult);
                            ob.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            k = k - 11;
            if (k >= 11)
            {
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    c = k - 11;
                    int c1 = 1;
                    while (sdr.Read())
                    {
                        if (c1 > 0 && c1 <= k)
                        {
                            string aux = sdr.GetString(5);
                            string auxName = sdr.GetString(4);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (aux1.Length < 2)
                            {
                                if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                {
                                    listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t\t" + sdr.GetString(6));
                                    c1++;
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                                    c1++;
                                }
                            }
                            else
                            {
                                listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                                c1++;
                            }
                        }
                        else
                        {
                            c1++;
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
                k = 11;
            }
        }

        private void Urmator_Click(object sender, EventArgs e)
        {
            k = k + 11;
            if (k < count + 11)
            {
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    c = k - 11;
                    int c1 = 1;
                    while (sdr.Read())
                    {
                        if (c1 > c && c1 <= k)
                        {
                            string aux = sdr.GetString(5);
                            string auxName = sdr.GetString(4);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (aux1.Length < 2)
                            {
                                if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                {
                                    listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t\t" + sdr.GetString(6));
                                    c1++;
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t\t" + sdr.GetString(6));
                                    c1++;
                                }
                            }
                            else
                            {
                                listBox.Items.Add(sdr.GetString(4) + " " + sdr.GetString(5) + "\t\t" + sdr.GetString(6));
                                c1++;
                            }
                        }
                        else
                        {
                            c1++;
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
                k = k - 11;
            }
        }

        private void registruConsult_Click(object sender, EventArgs e)
        {
             RegistruConsultatii ob = new RegistruConsultatii();
             ob.Show();
             this.Hide();
        }

        private void alerteLunare_Click(object sender, EventArgs e)
        {
            AlerteLunare ob = new AlerteLunare();
            ob.Show();
            this.Hide();
        }

        private void suportOnline_Click(object sender, EventArgs e)
        {
            SuportOnline ob = new SuportOnline();
            ob.Show();
            this.Hide();
        }

        private void adminPacienti_Click(object sender, EventArgs e)
        {
            AdministrareApicultor ob = new AdministrareApicultor();
            ob.Show();
            this.Hide();
        }

        private void editareInfo_Click(object sender, EventArgs e)
        {
            BiletInvestigatii ob = new BiletInvestigatii();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void adaugaAngajat_Click(object sender, EventArgs e)
        {
            AdaugaAngajat ob = new AdaugaAngajat();
            ob.Show();
            this.Hide();
        }

        private void Facturi_Click(object sender, EventArgs e)
        {
            Facturi ob = new Facturi();
            ob.Show();
            this.Hide();
        }

        private void managementUser_Click(object sender, EventArgs e)
        {
            ManagementUser ob = new ManagementUser();
            ob.Show();
            this.Hide();
        }

        private void registruProg_Click(object sender, EventArgs e)
        {
            RegistruProgramari ob = new RegistruProgramari();
            ob.Show();
            this.Hide();
        }

        private void statisticiBuget_Click(object sender, EventArgs e)
        {
            StatisticiBugetare ob = new StatisticiBugetare();
            ob.Show();
            this.Hide();
        }

        private void statisticiMed_Click(object sender, EventArgs e)
        {
            ProgramariAsteptare ob = new ProgramariAsteptare();
            ob.Show();
            this.Hide();
        }

        private void pacientNou_Click(object sender, EventArgs e)
        {
            AdaugaApicultor ob = new AdaugaApicultor(idDoctor);
            ob.Show();
            this.Hide();
        }

        private void Cauta1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void pacientNou1_Click(object sender, EventArgs e)
        {
            AdaugaApicultor ob = new AdaugaApicultor(idDoctor);
            ob.Show();
            this.Hide();
        }

        private void pacientiEvidenta1_Click(object sender, EventArgs e)
        {
            ApicultorEvidenta ob = new ApicultorEvidenta();
            ob.Show();
            this.Hide();
        }

        private void registruConsult1_Click(object sender, EventArgs e)
        {
            RegistruConsultatii ob = new RegistruConsultatii();
            ob.Show();
            this.Hide();
        }

        private void statisticiMed1_Click(object sender, EventArgs e)
        {
            ProgramariAsteptare ob = new ProgramariAsteptare();
            ob.Show();
            this.Hide();
        }

        private void statisticiBuget1_Click(object sender, EventArgs e)
        {
            StatisticiBugetare ob = new StatisticiBugetare();
            ob.Show();
            this.Hide();
        }

        private void registruProg1_Click(object sender, EventArgs e)
        {
            RegistruProgramari ob = new RegistruProgramari();
            ob.Show();
            this.Hide();
        }

        private void alerteLunare1_Click(object sender, EventArgs e)
        {
            AlerteLunare ob = new AlerteLunare();
            ob.Show();
            this.Hide();
        }

        private void managementUser1_Click(object sender, EventArgs e)
        {
            ManagementUser ob = new ManagementUser();
            ob.Show();
            this.Hide();
        }

        private void adminPacienti1_Click(object sender, EventArgs e)
        {
            AdministrareApicultor ob = new AdministrareApicultor();
            ob.Show();
            this.Hide();
        }

        private void Facturi1_Click(object sender, EventArgs e)
        {
            Facturi ob = new Facturi();
            ob.Show();
            this.Hide();
        }

        private void adaugaAngajat1_Click(object sender, EventArgs e)
        {
            AdaugaAngajat ob = new AdaugaAngajat();
            ob.Show();
            this.Hide();
        }

        private void editareInfo1_Click(object sender, EventArgs e)
        {
            BiletInvestigatii ob = new BiletInvestigatii();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void suportOnline1_Click(object sender, EventArgs e)
        {
            SuportOnline ob = new SuportOnline();
            ob.Show();
            this.Hide();
        }

        private void Deconectare1_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1(idForUser);
            ob.Show();
            this.Hide();
        }

        private void schimbareParola_Click(object sender, EventArgs e)
        {
            SchimbareParola ob = new SchimbareParola();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void schimbareParola1_Click(object sender, EventArgs e)
        {
            SchimbareParola ob = new SchimbareParola();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void ComenziFavorite_Click(object sender, EventArgs e)
        {
            ComenziFavorite ob = new ComenziFavorite();
            ob.Show();
            this.Hide();
        }

        private void adaugaPacient_Click(object sender, EventArgs e)
        {
            AdaugaApicultor ob = new AdaugaApicultor(idDoctor);
            ob.Show();
            this.Hide();
        }

        private void adaugaPacient1_Click(object sender, EventArgs e)
        {
            AdaugaApicultor ob = new AdaugaApicultor(idDoctor);
            ob.Show();
            this.Hide();
        }

        private void nume_TextChanged(object sender, EventArgs e)
        {
            if(nume.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(0);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in nume.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void cnp_TextChanged(object sender, EventArgs e)
        {
            if (cnp.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(2);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in cnp.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void prenume_TextChanged(object sender, EventArgs e)
        {
            if (prenume.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(1);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in prenume.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void nrFisa_TextChanged(object sender, EventArgs e)
        {
            if (nrFisa.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp, nr_fisa from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(3);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in nrFisa.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            if (telefon.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp, telefon from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(3);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in telefon.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void dateConsult_ValueChanged(object sender, EventArgs e)
        {
            if (dateConsult.Text != "")
            {
                int totalCounterToShow = 0;
                count = 0;
                listBox.Items.Clear();
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                char[] delimiterChars = { ' ', '-', '\t' };
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select nume, prenume, cnp, data_nasterii from pacient order by nume,prenume asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        string textFinal = sdr.GetString(3);
                        int counterText = 0;
                        string textToSearch = "";
                        string textToDB = "";
                        foreach (char a in dateConsult.Text)
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
                            ++count;
                            ++totalCounterToShow;
                            string aux = sdr.GetString(1);
                            string auxName = sdr.GetString(0);
                            string[] aux1 = aux.Split(delimiterChars);
                            if (count <= 11)
                            {
                                if (aux1.Length < 2)
                                {
                                    if ((auxName.Count() + aux.Count()) < 10 && auxName.Count() <= 5)
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t\t" + sdr.GetString(2));
                                    }
                                    else
                                    {
                                        listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t\t" + sdr.GetString(2));
                                    }
                                }
                                else
                                {
                                    listBox.Items.Add(sdr.GetString(0) + " " + sdr.GetString(1) + "\t\t" + sdr.GetString(2));
                                }
                            }
                        }
                        nrPacienti.Text = totalCounterToShow.ToString();
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
                listBox.Items.Clear();
                count = 0;
                construct();
            }
        }

        private void Rapoarte1_Click(object sender, EventArgs e)
        {
            EvidenteSiRapoarte ob = new EvidenteSiRapoarte();
            ob.Show();
            this.Hide();
        }

        private void Administrare1_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1(idForAdmin);
            ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            SuportOnline ob = new SuportOnline();
            ob.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SuportOnline ob = new SuportOnline();
            ob.Show();
            this.Hide();
        }

        private void editInfo1_Click(object sender, EventArgs e)
        {
            BiletInvestigatii ob = new BiletInvestigatii();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void editInfo_Click(object sender, EventArgs e)
        {
            BiletInvestigatii ob = new BiletInvestigatii();
            ob.setNume(name);
            ob.Show();
            this.Hide();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    } 
}