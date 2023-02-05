using cetheve_nasa.image;
using cetheve_nasa.image_data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasa
{
    public partial class Form2 : Form
    {
        private static string api_key = "aPKKtu1N0Z6SzTwlXpOlVCGanzXRTyOi7huSRJsq";

        //On récupère l'image du background
        private static ImageBg bg_img = new ImageBg();
        private static ImageData img_data = bg_img.ImageGetter(api_key);

        public Form2()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = img_data.getter_url.ToString();

            button1.Text = "Back";
            label1.Text = "Name : " + Form1.SetValueForText1;
            label2.Text = "Estimated Diameter : " + Form1.SetValueForText2;
            label3.Text = "Absolute Magnitude : " + Form1.SetValueForText3;
            label4.Text = "Date : " + Form1.SetValueForComboBox;
            label5.Text = "Relative Velocity : " + Form1.SetValueForText5;
            label6.Text = "Miss Distence : " + Form1.SetValueForText6;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();

        }
    }
}
