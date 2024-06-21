using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class Fisiere : Form
    {
        Dictionary<string, string> startupinfoDict = new Dictionary<string, string>();
        private string nume;

        public Fisiere(string nm)
        {
            InitializeComponent();
            nume = nm;
            welcome();
            file();
        }

        public void file()
        {
            string path = @"D:\An 3\Licenta\Apicultor\" + nume;

            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
                listBox.Items.Add(dir);

            string[] dirFiles = Directory.GetFiles(path);

            foreach (string file in dirFiles)
                listBox.Items.Add(file);
        }

        private void welcome()
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
                    string aux=sdr.GetString(4) + " " + sdr.GetString(5);
                    if(nume == aux)
                    {
                        nume = sdr.GetString(4) + " " + sdr.GetString(5);
                    }
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
                string file = listBox.SelectedItem.ToString();
                System.Diagnostics.Process.Start(file);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Apicultor ob = new Apicultor();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Apicultor ob = new Apicultor();
            ob.Show();
            this.Hide();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Apicultor ob = new Apicultor();
            ob.Show();
            this.Hide();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            Apicultor ob = new Apicultor();
            ob.Show();
            this.Hide();
        }
    }
}