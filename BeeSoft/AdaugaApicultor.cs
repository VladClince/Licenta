using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class AdaugaApicultor : Form
    {
        private bool status = false;
        private int success = 1;
        private int idDoctor;
        byte[] arr;
        MemoryStream ms;
        PictureBox PictureBox1 = new PictureBox();
        string pathSource = null;
        public AdaugaApicultor(int id)
        {
            InitializeComponent();
            idDoctor = id;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void insert()
        {
            if(nume.Text != "")
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
                                    if (loculNasterii.Text != "")
                                    {
                                        if (nationalitate.Text != "")
                                        {
                                            if (cetatenie.Text != "")
                                            {
                                                if (ocupatie.Text != "")
                                                {
                                                    if (asigurarePacient.Text != "")
                                                    {
                                                        if (sex.Text != "")
                                                        {
                                                            if (email.Text != "")
                                                            {
                                                                MySql.Data.MySqlClient.MySqlConnection conn;
                                                                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                                                                try
                                                                {
                                                                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                                                    conn.Open();
                                                                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into pacient(id_medic, nume, prenume, cnp, nr_fisa, adresa, telefon, locul_nasterii, nationalitate, cetatenie, ocupatie, asigurare, data_nasterii, email, sex, imagine) values(@id_medic, @nume, @prenume, @cnp, @nr_fisa, @adresa, @telefon, @locul_nasterii, @nationalitate, @cetatenie, @ocupatie, @asigurare, @data_nasterii, @email, @sex, @imagine)", conn);
                                                                    cmd.Connection = conn;

                                                                    cmd.Parameters.AddWithValue("@id_medic", idDoctor);
                                                                    cmd.Parameters.AddWithValue("@nume", nume.Text);
                                                                    cmd.Parameters.AddWithValue("@prenume", prenume.Text);
                                                                    cmd.Parameters.AddWithValue("@cnp", cnp.Text);
                                                                    cmd.Parameters.AddWithValue("@nr_fisa", nrFisa.Text);
                                                                    cmd.Parameters.AddWithValue("@adresa", adresa.Text);
                                                                    cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                                                                    cmd.Parameters.AddWithValue("@locul_nasterii", loculNasterii.Text);
                                                                    cmd.Parameters.AddWithValue("@nationalitate", nationalitate.Text);
                                                                    cmd.Parameters.AddWithValue("@cetatenie", cetatenie.Text);
                                                                    cmd.Parameters.AddWithValue("@ocupatie", ocupatie.Text);
                                                                    cmd.Parameters.AddWithValue("@asigurare", asigurarePacient.Text);
                                                                    cmd.Parameters.AddWithValue("@data_nasterii", dataNasterii.Text);
                                                                    cmd.Parameters.AddWithValue("@email", email.Text);
                                                                    cmd.Parameters.AddWithValue("@sex", sex.Text);
                                                                    cmd.Parameters.AddWithValue("@imagine", arr);

                                                                    int i = cmd.ExecuteNonQuery();

                                                                    conn.Close();

                                                                    if (i == success)
                                                                    {
                                                                        MessageBox.Show("Angajatul a fost adaugat cu succes!");
                                                                        string path = @"D:\An 3\Licenta\Folder\Apicultor\" + nume.Text + " " + prenume.Text;
                                                                        bool folderExists = Directory.Exists(path);
                                                                        if (!folderExists)
                                                                            Directory.CreateDirectory(path);
                                                                        if (status)
                                                                        {
                                                                            File.Copy(pathSource, path + "\\profile.jpg");
                                                                        }
                                                                        Choose ob = new Choose();
                                                                        ob.Show();
                                                                        this.Hide();
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("A aparut o problema la adaugare! Consultatii echipa tehnica pentru remediere.");
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
                                                            else
                                                            {
                                                                MessageBox.Show("Nu a-ti introdus email-ul angajatului!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Nu a-ti introdus sexul angajatului!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Nu a-ti introdus daca angajatul este asigurat!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Nu a-ti introdus ocupatia!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Nu a-ti introdus cetatenia!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nu a-ti introdus nationalitatea!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nu a-ti introdus locul nasterii!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nu a-ti introdus telefonul!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu a-ti introdus adresa!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu a-ti introdus numarul de fisa!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu a-ti introdus CNP-ul!");
                    }
                }
                else
                {
                    MessageBox.Show("Nu a-ti introdus prenumele!");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti introdus numele!");
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void alegePoza_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); 
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ms = new MemoryStream();
                PictureBox1.Image = new Bitmap(open.FileName);
                PictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, arr.Length);
                pathSource = open.FileName;
                status = true;
            }
        }
    }
}
