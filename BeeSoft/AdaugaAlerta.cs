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
    public partial class AdaugaAlerta : Form
    {
        private int success = 1;
        private int idAngajat;

        public AdaugaAlerta()
        {
            InitializeComponent();
            string path = @"D:\An 3\Licenta\Folder\Logare\IdAngajat.txt";
            StreamReader sr = File.OpenText(path);
            idAngajat = Int32.Parse(sr.ReadLine());
            sr.Close();
        }

        private void insert()
        {
            if(tipAlerta.Text != "")
            {
                if(descriere.Text != "")
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into alerte(tip_alerta, descriere, data_expirare, id_medic) values(@tip_alerta, @descriere, @data_expirare, @id_medic)", conn);
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@tip_alerta", tipAlerta.Text);
                        cmd.Parameters.AddWithValue("@descriere", descriere.Text);
                        cmd.Parameters.AddWithValue("@data_expirare", dataExpirare.Text);
                        cmd.Parameters.AddWithValue("@id_medic", idAngajat);
                        
                        int i = cmd.ExecuteNonQuery();

                        conn.Close();

                        if (i == success)
                        {
                            MessageBox.Show("Alerta a fost adaugata cu succes!");
                            AlerteLunare ob = new AlerteLunare();
                            ob.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("A aparut o problema la adaugare! Consultatii echipa tehnica pentru remediere.");
                            AlerteLunare ob = new AlerteLunare();
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
                    MessageBox.Show("Campul descrierii nu este completat!");
                }
            }
            else
            {
                MessageBox.Show("Tipul alertei nu este completat!");
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
            AlerteLunare ob = new AlerteLunare();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            AlerteLunare ob = new AlerteLunare();
            ob.Show();
            this.Hide();
        }
    }
}
