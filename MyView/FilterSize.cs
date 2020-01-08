using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyView
{
    public partial class FilterSize : Form
    {
        uint wnd = 3;
        public FilterSize()
        {
            InitializeComponent();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            try
            {
                wnd = uint.Parse(textBox_Size.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный параметр");
            }
            ImProc.par = (int)wnd;
            this.Close();
        }
    }
}
