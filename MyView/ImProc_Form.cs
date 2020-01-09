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
        Mat src;
        Mat dst;
        static public int par;
 
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
                //Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                src = new Mat(Openfile.FileName);

                //Display the Image
                imageBox1.Image = src;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = src;
            imageBox1.Image = new Mat();
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                FilterSize fs = new FilterSize();
                fs.ShowDialog();
                dst = new Mat();
                dst = src;
                CvInvoke.MedianBlur(src, dst, par);
                imageBox1.Image = dst;
            }
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                FilterSize fs = new FilterSize();
                fs.ShowDialog();
                dst = new Mat();
                dst = src;
                CvInvoke.Blur(src, dst, new Size(par,par), new Point(-1,-1) );
                imageBox1.Image = dst;
            }

        }
    }
}
