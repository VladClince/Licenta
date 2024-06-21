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
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System.IO;
namespace BeeSoft
{
    public partial class BiletTrimitere : Form
    {
        private int idBack;
        private int idApicultor;
        private int idDoctor;
        private int choose_ = 0;
        private int apicultor_ = 1;
        private int success = 1;
        private string nameDoctor;
        private string nume;
        private string sex;
        public void setKey(int pt)
        {
            idApicultor = pt;
            findApicultor();
            numePacient.Enabled = false;
            cnp.Enabled = false;
            profesie.Enabled = false;
            adresa.Enabled = false;
        }

        public void setBack(int back)
        {
            idBack = back;
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
                        findApicultor();
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void findApicultor()
        {
            if (idApicultor > 0)
            {
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select idpacient,nume,prenume,cnp,adresa,ocupatie,sex from pacient where idpacient='" + idPatient + "'", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        numePacient.Text = sdr.GetString(1) + " " + sdr.GetString(2);
                        cnp.Text = sdr.GetString(3);
                        profesie.Text = sdr.GetString(5);
                        adresa.Text = sdr.GetString(4);
                        sex = sdr.GetString(6);
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
                findIdApicultor();
            }
        }


        public BiletTrimitere(string nm)
        {
            InitializeComponent();
            setName();
            findIdDoctor();
            nume = nm;
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
                    if (aux == nameDoctor)
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

        private void setName()
        {
            string path = @"D:\An 3\Licenta\Folder\Logare\Logare.txt";
            StreamReader sr = File.OpenText(path);
            nameDoctor = sr.ReadLine();
            sr.Close();
            System.IO.File.Copy(@"D:\An 3\Licenta\BeeSoft\licenta.sql", @"D:\An 3\Licenta\Site Apicultor\licenta.sql", true);
        }

        private void insert()
        {
            if (unitMedicala.Text != "")
            {
                if (sediul.Text != "")
                {
                    if (judet.Text != "")
                    {
                        if (codFiscal.Text != "")
                        {
                            if (casaAsigurari.Text != "")
                            {
                                if (nrContract.Text != "")
                                {
                                    if (asiguratLa.Text != "")
                                    {
                                        if (diagnostic.Text != "")
                                        {
                                            if (codDiagnostic.Text != "")
                                            {
                                                if (motiv.Text != "")
                                                {
                                                    if (parafa.Text != "")
                                                    {
                                                        if (tratamenteEfectuate.Text != "")
                                                        {
                                                            if (nrConsultEfect.Text != "")
                                                            {
                                                                MySql.Data.MySqlClient.MySqlConnection conn;
                                                                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                                                try
                                                                {
                                                                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                                                    conn.Open();
                                                                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into trimitere(id_pacient,unit_medicala,sediul,judet,cod_fiscal,casa_asigurari,nr_contract,asigurat,diagnostic,cod_diagnostic,motiv,tratamente_efectuate,nr_consult_efectuate,data_trimiterii,parafa) values(@id_pacient,@unit_medicala,@sediul,@judet,@cod_fiscal,@casa_asigurari,@nr_contract,@asigurat,@diagnostic,@cod_diagnostic,@motiv,@tratamente_efectuate,@nr_consult_efectuate,@data_trimiterii,@parafa)", conn);
                                                                    cmd.Connection = conn;
                                                                    cmd.Parameters.AddWithValue("@id_pacient", idApicultor);
                                                                    cmd.Parameters.AddWithValue("@unit_medicala", unitMedicala.Text);
                                                                    cmd.Parameters.AddWithValue("@sediul", sediul.Text);
                                                                    cmd.Parameters.AddWithValue("@judet", judet.Text);
                                                                    cmd.Parameters.AddWithValue("@cod_fiscal", int.Parse(codFiscal.Text.ToString()));
                                                                    cmd.Parameters.AddWithValue("@casa_asigurari", casaAsigurari.Text);
                                                                    cmd.Parameters.AddWithValue("@nr_contract", nrContract.Text);
                                                                    cmd.Parameters.AddWithValue("@asigurat", asiguratLa.Text);
                                                                    cmd.Parameters.AddWithValue("@diagnostic", diagnostic.Text);
                                                                    cmd.Parameters.AddWithValue("@cod_diagnostic", int.Parse(codDiagnostic.Text.ToString()));
                                                                    cmd.Parameters.AddWithValue("@motiv", motiv.Text);
                                                                    cmd.Parameters.AddWithValue("@tratamente_efectuate", tratamenteEfectuate.Text);
                                                                    cmd.Parameters.AddWithValue("@nr_consult_efectuate", int.Parse(nrConsultEfect.Text.ToString()));
                                                                    cmd.Parameters.AddWithValue("@data_trimiterii", dataTrimiterii.Text);
                                                                    cmd.Parameters.AddWithValue("@parafa", parafa.Text);

                                                                    int i = cmd.ExecuteNonQuery();

                                                                    conn.Close();

                                                                    if (i == success)
                                                                    {
                                                                        MessageBox.Show("Biletul de trimitere a fost inregistrat!");
                                                                        if (idBack == choose_)
                                                                        {
                                                                            Choose ob = new Choose();
                                                                            ob.Show();
                                                                            this.Hide();
                                                                        }
                                                                        else if (idBack == apicultor_)
                                                                        {
                                                                            Apicultor ob = new Apicultor();
                                                                            ob.Show();
                                                                            this.Hide();
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("A aparut o problema la inregistrare! Consultatii echipa tehnica pentru remediere.");
                                                                        if (idBack == choose_)
                                                                        {
                                                                            Choose ob = new Choose();
                                                                            ob.Show();
                                                                            this.Hide();
                                                                        }
                                                                        else if (idBack == apicultor_)
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
                                                                MessageBox.Show("Nu a-ti completat numarul de consultatii efectuate!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Nu a-ti completat tratamentele efectuate!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Nu a-ti completat parafa!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Nu a-ti completat motivul!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Nu a-ti completat codul diagnosticului!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nu a-ti completat diagnosticul!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nu a-ti completat locul unde este asigurat angajatul!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nu a-ti completat numarul contractului!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu a-ti completat la casa de asigurarii!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu a-ti completat codul fiscal!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu a-ti completat numele judetului!");
                    }
                }
                else
                {
                    MessageBox.Show("Nu a-ti completat numele sediului!");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti completat numele unitatii apicole!");
            }
        }

        private void createSenderTicket()
        {
            try
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();
                Spire.Doc.Section sec = doc.AddSection();
                Spire.Doc.Documents.Paragraph par = sec.AddParagraph();

                Spire.Doc.Fields.TextBox textBox = par.AppendTextBox(180, 30);
                textBox.Format.VerticalOrigin = VerticalOrigin.Margin;
                textBox.Format.VerticalPosition = 100;
                textBox.Format.HorizontalOrigin = HorizontalOrigin.Margin;
                textBox.Format.HorizontalPosition = 50;
                textBox.Format.NoLine = true;

                Spire.Doc.Documents.Paragraph paragraph = sec.AddParagraph();
                paragraph.AppendText("Judetul: " + judet.Text
                           + "\nUnitatea apicola: " + unitMedicala.Text
                           + "\nSediul: " + sediul.Text
                           + "\nCod fiscal: " + codFiscal.Text
                           + "\nCasa de asigurari: " + casaAsigurari.Text
                           + "\nNr contract: " + nrContract.Text);
                paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                paragraph.Format.AfterSpacing = 2;
                paragraph.Format.BeforeSpacing = 0;

                Spire.Doc.Documents.Paragraph paragraph0 = sec.AddParagraph();
                paragraph0.AppendText("\nBILET DE TRIMITERE\n").CharacterFormat.FontSize = 15;
                paragraph0.Format.AfterSpacing = 2;
                paragraph0.Format.BeforeSpacing = 0;
                paragraph0.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                Spire.Doc.Documents.Paragraph paragraph1 = sec.AddParagraph();
                paragraph1.AppendText("Angajatul: " + nume + ", sexul: " + sex + ","
                           + "\nCu domiciliul in: " + adresa.Text + ","
                           + "\nCNP: " + cnp.Text + ","
                           + "\nAsigurat la: " + asiguratLa.Text);
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                paragraph1.Format.AfterSpacing = 0;
                paragraph1.Format.BeforeSpacing = 5;

                Spire.Doc.Documents.Paragraph paragraph2 = sec.AddParagraph();
                paragraph2.AppendText("__________________________________________________________________________________");
                paragraph2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                paragraph2.Format.AfterSpacing = 0;
                paragraph2.Format.BeforeSpacing = 5;

                Spire.Doc.Documents.Paragraph paragraph3 = sec.AddParagraph();
                paragraph3.AppendText("Motivul: " + motiv.Text + ","
                           + "\nCu diagnosticul: " + diagnostic.Text + ", codul diagnosticului: " + codDiagnostic.Text + ","
                           + "\nData trimiterii: " + dataTrimiterii.Text + ", "
                           + "\nTratamente efectuate: " + tratamenteEfectuate.Text + ","
                           + "\nNumarul de consultatii efectuate: " + nrConsultEfect.Text + ","
                           + "\nData eliberarii: " + dataTrimiterii.Text + "\t\t\t\t Semnatura si parafa specialistului:");
                paragraph3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                paragraph3.Format.AfterSpacing = 0;
                paragraph3.Format.BeforeSpacing = 5;

                doc.SaveToFile(@"D:\\An 3\\Licenta\\Folder\\BiletTrimitere.docx", FileFormat.Docx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = ap.Documents.Open(@"D:\\An 3\\Licenta\\Folder\\BiletTrimitere.docx");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            insert();
            createSenderTicket();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            insert();
            createSenderTicket();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (idBack == choose_)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (idBack == apicultor_)
            {
                Apicultor ob = new Apicultor();
                ob.Show();
                this.Hide();
            }
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            if (idBack == choose_)
            {
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
            else if (idBack == apicultor_)
            {
                Apicultor ob = new Apicultor();
                ob.Show();
                this.Hide();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
