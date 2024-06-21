using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class ContacteazaProgramari : Form
    {
        private string mail;
        private int id;
        public ContacteazaProgramari(string tel, string m, int idProg)
        {
            InitializeComponent();
            telefon.Text = tel;
            mail = m;
            telefon.Enabled = false;
            id = idProg;
        }

        private void send()
        {
            if (mesaj.Text != "")
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("sebyany14@gmail.com", "timisoara1995");

                MailMessage mm = new MailMessage(mail, mail, "BeeSoft - Programare", mesaj.Text);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);

                if (Anulare.Checked == true)
                {
                    cancelAppointment();
                }

                MessageBox.Show("Mesajul dumneavoastra a fost trimis catre pacient!");
                RegistruProgramari ob = new RegistruProgramari();
                ob.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mesajul nu este completat!");
            }
        }

        private void cancelAppointment()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = @"update programari set status='" + "decline" + "' where id_programari='" + id + "' ";
                cmd.Connection = conn;

                int i = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            send();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            send();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            RegistruProgramari ob = new RegistruProgramari();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            RegistruProgramari ob = new RegistruProgramari();
            ob.Show();
            this.Hide();
        }
    }
}