using cetheve_nasa.get_api;
using cetheve_nasa.data;
using System.Windows.Forms;
using cetheve_nasa.image;
using cetheve_nasa.image_data;

namespace Nasa
{
    public partial class Form1 : Form
    {
        private static string api_key = "aPKKtu1N0Z6SzTwlXpOlVCGanzXRTyOi7huSRJsq";

        private static GetApi api = new GetApi();

        private static ImageBg bg_img = new ImageBg();

        public static List<Root> all_data = api.ApiGetter(api_key);

        private static ImageData img_data = bg_img.ImageGetter(api_key);

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForComboBox = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";

        public static string image = "";
        public static string imageTitle = "";
        public static string imageExplanation = "";

        List<Button> buttons = new List<Button>();
        List<Label> labels = new List<Label>();

        public Form1()
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);

            InitializeComponent();
            pictureBox1.ImageLocation = img_data.getter_url.ToString();

            button1.Text = all_data[0].getter_name;
            button2.Text = all_data[1].getter_name;
            button3.Text = all_data[2].getter_name;
            button4.Text = all_data[3].getter_name;
            button5.Text = all_data[4].getter_name;
            button6.Text = all_data[5].getter_name;
            button7.Text = all_data[6].getter_name;
            button8.Text = all_data[7].getter_name;
            button9.Text = all_data[8].getter_name;
            button10.Text = all_data[9].getter_name;
            button11.Text = all_data[10].getter_name;
            button12.Text = all_data[11].getter_name;

            label1.Text = all_data[0].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label2.Text = all_data[1].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label3.Text = all_data[2].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label4.Text = all_data[3].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label5.Text = all_data[4].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label6.Text = all_data[5].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label7.Text = all_data[6].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label8.Text = all_data[7].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label9.Text = all_data[8].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label10.Text = all_data[9].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label11.Text = all_data[10].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";
            label12.Text = all_data[11].getter_close_approach_data[0].getter_miss_distance.getter_kilometers + " km";

            button21.Text = "Background Info";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button1.Text;
            SetValueForText2 = all_data[0].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[0].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[0].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label1.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button2.Text;
            SetValueForText2 = all_data[1].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[1].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[1].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label2.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button3.Text;
            SetValueForText2 = all_data[2].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[2].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[2].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label3.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button4.Text;
            SetValueForText2 = all_data[3].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[3].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[3].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label4.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button5.Text;
            SetValueForText2 = all_data[4].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[4].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[4].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label5.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button6.Text;
            SetValueForText2 = all_data[5].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[5].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[5].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label6.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button7.Text;
            SetValueForText2 = all_data[6].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[6].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[6].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label7.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button8.Text;
            SetValueForText2 = all_data[7].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[7].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[7].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label8.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button9.Text;
            SetValueForText2 = all_data[8].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[8].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[8].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label9.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button10.Text;
            SetValueForText2 = all_data[9].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[9].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[9].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label10.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button11.Text;
            SetValueForText2 = all_data[10].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[10].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[10].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label11.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button12.Text;
            SetValueForText2 = all_data[11].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[11].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[11].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label12.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button13.Text;
            SetValueForText2 = all_data[12].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[12].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[12].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label13.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button14.Text;
            SetValueForText2 = all_data[13].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[13].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[13].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label14.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button15.Text;
            SetValueForText2 = all_data[14].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[14].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[14].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label15.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button16.Text;
            SetValueForText2 = all_data[15].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[15].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[15].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label16.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button17.Text;
            SetValueForText2 = all_data[16].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[16].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[16].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label17.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button18.Text;
            SetValueForText2 = all_data[17].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[17].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[17].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label18.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button19.Text;
            SetValueForText2 = all_data[19].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[19].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[19].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label19.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SetValueForText1 = button20.Text;
            SetValueForText2 = all_data[20].getter_estimated_diameter.getter_meters.getter_estimated_diameter_min + " m";
            SetValueForText3 = all_data[20].getter_absolute_magnitude_h.ToString("E04");
            SetValueForComboBox = DateTime.Now.ToString("yyyy-MM-dd");
            SetValueForText5 = all_data[20].getter_close_approach_data[0].getter_relative_velocity.getter_kilometers_per_second + "km/s";
            SetValueForText6 = label20.Text;

            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            imageTitle = img_data.getter_title.ToString();
            imageExplanation = img_data.getter_explanation.ToString();

            Form3 obj2 = new Form3();
            obj2.Show();
        }
    }
}