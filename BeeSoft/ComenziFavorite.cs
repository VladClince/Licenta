using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BeeSoft
{
    public partial class ComenziFavorite : Form
    {
        private int numberOfFavouriteChoose = 4;
        private int counter = 0;
        private const int counterConst = 4;
        private string[] aux = new string[4];
        public ComenziFavorite()
        {
            InitializeComponent();
            string path = @"D:\An 3\Licenta\Folder\Fisiere pentru salvare\ComenziFavorite.txt";
            StreamReader sr = File.OpenText(path);
            for (int i = 0; i < counterConst; i++)
            {
                aux[i] = sr.ReadLine();
            }
            for (int i = 0; i < counterConst; i++)
            {
                if (aux[i] == "Istoric diagnostice")
                {
                    istoricMedicale.Checked = true;
                }
                if (aux[i] == "Bilet Trimitere")
                {
                    biletTrimitere.Checked = true;
                }
                if (aux[i] == "Control periodic nou")
                {
                    consultatieNoua.Checked = true;
                }
                if (aux[i] == "Deschide fisa curenta")
                {
                    deschideFisa.Checked = true;
                }
                if (aux[i] == "Diagnostic nou")
                {
                    diagnostic.Checked = true;
                }
                if (aux[i] == "Fisa Angajat")
                {
                    fisaPacient.Checked = true;
                }
                if (aux[i] == "Fisiere")
                {
                    fisiere.Checked = true;
                }
                if (aux[i] == "Istoric controale periodice")
                {
                    istoricConsultatii.Checked = true;
                }
            }
            sr.Close();
        }

        private void add()
        {
            string path = @"D:\An 3\Licenta\Folder\Fisiere pentru salvare\ComenziFavorite.txt";
            StreamWriter sw = File.CreateText(path);
            if (counter > numberOfFavouriteChoose)
            {
                MessageBox.Show("Se pot bifa maxim 4 comenzi favorite!");
                sw.Close();
            }
            else if (counter <= numberOfFavouriteChoose)
            {
                if (istoricMedicale.Checked == true)
                {
                    sw.WriteLine("Istoric diagnostice");
                }
                if (biletTrimitere.Checked == true)
                {
                    sw.WriteLine("Bilet Trimitere");
                }
                if (consultatieNoua.Checked == true)
                {
                    sw.WriteLine("Consultatie");
                }
                if (deschideFisa.Checked == true)
                {
                    sw.WriteLine("Deschide fisa curenta");
                }
                if (diagnostic.Checked == true)
                {
                    sw.WriteLine("Diagnostic nou");
                }
                if (fisaPacient.Checked == true)
                {
                    sw.WriteLine("Fisa Angajat");
                }
                if (fisiere.Checked == true)
                {
                    sw.WriteLine("Fisiere");
                }
                if (istoricConsultatii.Checked == true)
                {
                    sw.WriteLine("Istoric controale periodice");
                }
                sw.Close();
                MessageBox.Show("Comenzile favorite au fost adaugate cu succes!");
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            add();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            add();
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

        private void biletInvestigatii_CheckedChanged(object sender, EventArgs e)
        {
            if (istoricMedicale.Checked == true)
            {
                ++counter;
            }
            else if (istoricMedicale.Checked == false)
            {
                --counter;
            }
        }

        private void biletTrimitere_CheckedChanged(object sender, EventArgs e)
        {
            if (biletTrimitere.Checked == true)
            {
                ++counter;
            }
            else if (biletTrimitere.Checked == false)
            {
                --counter;
            }
        }

        private void consultatieNoua_CheckedChanged(object sender, EventArgs e)
        {
            if (consultatieNoua.Checked == true)
            {
                ++counter;
            }
            else if (consultatieNoua.Checked == false)
            {
                --counter;
            }
        }

        private void deschideFisa_CheckedChanged(object sender, EventArgs e)
        {
            if (deschideFisa.Checked == true)
            {
                ++counter;
            }
            else if (deschideFisa.Checked == false)
            {
                --counter;
            }
        }

        private void diagnostic_CheckedChanged(object sender, EventArgs e)
        {
            if (diagnostic.Checked == true)
            {
                ++counter;
            }
            else if (diagnostic.Checked == false)
            {
                --counter;
            }
        }

        private void fisaPacient_CheckedChanged(object sender, EventArgs e)
        {
            if (fisaPacient.Checked == true)
            {
                ++counter;
            }
            else if (fisaPacient.Checked == false)
            {
                --counter;
            }
        }

        private void fisiere_CheckedChanged(object sender, EventArgs e)
        {
            if (fisiere.Checked == true)
            {
                ++counter;
            }
            else if (fisiere.Checked == false)
            {
                --counter;
            }
        }

        private void istoricConsultatii_CheckedChanged(object sender, EventArgs e)
        {
            if (istoricConsultatii.Checked == true)
            {
                ++counter;
            }
            else if (istoricConsultatii.Checked == false)
            {
                --counter;
            }
        }

        private void istoricRetete_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}