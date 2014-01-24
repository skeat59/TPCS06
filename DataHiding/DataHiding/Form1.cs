using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataHiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image;
        private void load_Click(object sender, EventArgs e)
        {
            opendialog.ShowDialog();
            image = new Bitmap(opendialog.FileName);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {

        }

        private void reveal_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int NbPx = image.Height * image.Width;
                FileStream fs = new FileStream(image, FileMode.open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

            }
        }

        private void opendialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
