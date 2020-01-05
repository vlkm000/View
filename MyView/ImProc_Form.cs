using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace MyView
{
    public partial class ImProc : Form
    {
        public ImProc()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the Image
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName); ;
                //Display the Image
                imageBox1.Image = My_Image;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = null;
        }
    }
}
