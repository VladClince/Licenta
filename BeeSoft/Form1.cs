using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
namespace BeeSoft
{
    public partial class Form1 : Form
    {
        private int idForAdmin;
        public Form1(int id)
        {
            InitializeComponent();
            timer.Interval = 2;
            idForAdmin = id;
            if (idForAdmin != 0)
            {
                user.Text = "admin";
                password.Text = "123456";
            }
        }

        private void Logare_Click(object sender, EventArgs e)
        {
            string path = @"D:\An 3\Licenta\Folder\Logare\Logare.txt";
            StreamWriter sw = File.CreateText(path);

            string pathSecondary = @"D:\An 3\Licenta\Folder\Logare\IdAngajat.txt";
            StreamWriter swSecond = File.CreateText(pathSecondary);

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from logare", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    string utilizator = sdr.GetString(1);
                    string parola = sdr.GetString(2);
                    if (utilizator == user.Text.ToString())
                    {
                        if (parola == password.Text.ToString())
                        {
                            sw.WriteLine(sdr.GetString(3));
                            swSecond.WriteLine(sdr.GetInt32(4).ToString());
                            i = 1;
                        }
                    }
                }
                conn.Close();
                if (i == 1)
                {
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Datele de logare invalide!");
                }
                sw.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sw.Close();
            swSecond.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value++;
            }
            else
            {
                timer.Stop();
                Choose ob = new Choose();
                ob.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}