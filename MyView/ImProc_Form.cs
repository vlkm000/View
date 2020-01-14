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
        //this.imageBox1.MouseDoubleClick += ImageBox1_MouseDoubleClick;
        Mat src;
        Mat dst;
        Image<Gray, Byte> gray;
        Image<Gray, Byte> tmp;
        Image<Gray, Byte> tmp1;
        Image<Bgr, Byte> im;
        static public int par;

        public ImProc()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = src;
            imageBox1.Image = new Mat();
        }

        private void MedianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                FilterSize fs = new FilterSize();
                fs.ShowDialog();
                dst = new Mat();
                dst = src.Clone();
                CvInvoke.MedianBlur(src, dst, par);
                imageBox1.Image = dst;
            }
        }

        private void MeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                FilterSize fs = new FilterSize();
                fs.ShowDialog();
                dst = new Mat();
                dst = src.Clone();
                CvInvoke.Blur(src, dst, new Size(par, par), new Point(-1, -1));
                imageBox1.Image = dst;
            }

        }
        private void ImageBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            imageBox1.Image = src;
        }
        private void GaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                dst = new Mat();
                dst = src.Clone();
                CvInvoke.GaussianBlur(src, dst, new Size(3, 3), 1.5);
                imageBox1.Image = dst;
            }
        }

        private void CannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                dst = new Mat();
                dst = src.Clone();
                CvInvoke.Canny(src, dst, 100, 200);
                imageBox1.Image = dst;
            }
        }


        private void SobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                im = src.ToImage<Bgr, Byte>();
                tmp = im.Convert<Gray, Byte>();
                tmp1 = tmp.Clone();
                gray = tmp.Clone();
                CvInvoke.Sobel(tmp, gray, DepthType.Cv8U, 1, 0, 3);
                CvInvoke.Sobel(tmp, tmp1, DepthType.Cv8U, 0, 1, 3);
                gray = gray.Add(tmp1);
                imageBox1.Image = gray;
            }
        }

        private void EqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                im = src.ToImage<Bgr, Byte>();
                tmp = im.Convert<Gray, Byte>();
                gray = tmp.Clone();
                CvInvoke.EqualizeHist(tmp, gray);
                imageBox1.Image = gray;
            }
        }

        private void CLAHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!src.IsEmpty)
            {
                im = src.ToImage<Bgr, Byte>();
                tmp = im.Convert<Gray, Byte>();
                gray = tmp.Clone();
                CvInvoke.CLAHE(tmp, 20, new Size(32, 32), gray);
                imageBox1.Image = gray;
            }
        }
    }
}
