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
    public partial class Facturi : Form
    {
        public Facturi()
        {
            InitializeComponent();
            string path = @"D:\An 3\Licenta\Folder\Facturi";

            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
                listBox.Items.Add(dir);

            string[] dirFiles = Directory.GetFiles(path);

            foreach (string file in dirFiles)
                listBox.Items.Add(file);
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

        private void ok_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItem != null)
            {
                string file = listBox.SelectedItem.ToString();
                System.Diagnostics.Process.Start(file);
            }
        }
    }
}