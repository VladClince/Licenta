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
    public partial class SuportOnline : Form
    {
        public SuportOnline()
        {
            InitializeComponent();
        }

        private void done()
        {
            if(problemText.Text != "")
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("sebyany14@gmail.com", "timisoara1995");

                MailMessage mm = new MailMessage("vlad.alexandru.clince@gmail.com", "vlad.alexandru.clince@gmail.com", "BeeSoft", problemText.Text);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
                MessageBox.Show("Veti fi contactat in cel mai scurt timp de catre echipa noastra. Va multumim!");
            }
            else
            {
                MessageBox.Show("Nu a-ti completat nici o problema in campul destinat acesteia!");
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            done();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            done();
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