using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class StatisticiBugetare : Form
    {
        public StatisticiBugetare()
        {
            InitializeComponent();
            welcome();
        }

        private void welcome()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from factura", conn);
                MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    listBox.Items.Add("Data: " + sdr.GetString(1) + "   Tip document: " + sdr.GetString(2));
                    listBox.Items.Add("");
                    listBox.Items.Add("Detalii: " + sdr.GetString(3));
                    listBox.Items.Add("");
                    listBox.Items.Add("Suma facturata: " + sdr.GetString(4) + "   Suma platita: " + sdr.GetString(5));
                    listBox.Items.Add("----------------------------------------------------------------");
                    listBox.Items.Add("");
                }
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            FacturaNoua ob = new FacturaNoua();
            ob.Show();
            this.Hide();
        }

        private void adauga1_Click(object sender, EventArgs e)
        {
            FacturaNoua ob = new FacturaNoua();
            ob.Show();
            this.Hide();
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
    }
}