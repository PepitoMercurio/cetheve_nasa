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

namespace Nasa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = Form1.imageTitle;
            label2.Text = Form1.imageExplanation;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
