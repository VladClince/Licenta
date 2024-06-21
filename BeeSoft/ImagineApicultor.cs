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
    public partial class ImagineApicultor : Form
    {
        private string numeApicultor = null;
        public ImagineApicultor(string nume)
        {
            InitializeComponent();
            numeApicultor = nume;
            readImage();
        }

        private void readImage()
        {
            string path = @"D:\An 3\Licenta\Folder\Apicultor\" + numeApicultor;

            string[] dirs = Directory.GetDirectories(path);

            string photo = path + "\\profile.jpg";

            pictureBox.ImageLocation = photo;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
