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
    public partial class FacturaNoua : Form
    {
        private int success = 1;
        private int idAngajat;

        public FacturaNoua()
        {
            InitializeComponent();
            string path = @"D:\An 3\Licenta\Folder\Logare\IdAngajat.txt";
            StreamReader sr = File.OpenText(path);
            idAngajat = Int32.Parse(sr.ReadLine());
            sr.Close();
        }

        private void insert()
        {
            if (tipDocument.Text != "")
            {
                if (detalii.Text != "")
                {
                    if (sumaFacturata.Text != "")
                    {
                        if (sumaPlatita.Text != "")
                        {
                            MySql.Data.MySqlClient.MySqlConnection conn;
                            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                            try
                            {
                                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                                conn.Open();
                                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into factura(data,tip_document,detalii,suma_facturata,suma_platita, id_medic) values(@data,@tip_document,@detalii,@suma_facturata,@suma_platita,@id_medic)", conn);
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@data", data.Text);
                                cmd.Parameters.AddWithValue("@tip_document", tipDocument.Text);
                                cmd.Parameters.AddWithValue("@detalii", detalii.Text);
                                cmd.Parameters.AddWithValue("@suma_facturata", sumaFacturata.Text);
                                cmd.Parameters.AddWithValue("@suma_platita", sumaPlatita.Text);
                                cmd.Parameters.AddWithValue("@id_medic", idAngajat);

                                int i = cmd.ExecuteNonQuery();

                                conn.Close();

                                if (i == success)
                                {
                                    MessageBox.Show("Factura a fost adaugata cu succes!");
                                    StatisticiBugetare ob = new StatisticiBugetare();
                                    ob.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Factura nu a putut fi adaugata. Contactati echipa de suport pentru remediere!");
                                    StatisticiBugetare ob = new StatisticiBugetare();
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
                            MessageBox.Show("Nu a-ti completat suma platita!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu a-ti completat suma facturata!");
                    }
                }
                else
                {
                    MessageBox.Show("Nu a-ti completat campul \"detalii\"!");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti completat tipul documentului!");
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

        private void cancel_Click(object sender, EventArgs e)
        {
            StatisticiBugetare ob = new StatisticiBugetare();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            StatisticiBugetare ob = new StatisticiBugetare();
            ob.Show();
            this.Hide();
        }
    }
}