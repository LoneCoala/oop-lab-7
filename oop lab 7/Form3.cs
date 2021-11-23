using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ShowMessageBox(string message, string text)
        {
            bool showed = false;
            if (!showed)
                MessageBox.Show(message, text);
            showed = true;
        }
        private void Calc()
        {
            double z, v0, a, t, s, v;



            if (double.TryParse(textBox1.Text, out z) && double.TryParse(textBox2.Text, out z) && double.TryParse(textBox3.Text, out z))
            {


                v0 = Convert.ToDouble(textBox1.Text);
                a = Convert.ToDouble(textBox2.Text);
                t = Convert.ToDouble(textBox3.Text);

                v = v0 * a * t;
                s = v0 * t + (a * a / 2);

                textBox4.Text = Convert.ToString(v);
                textBox5.Text = Convert.ToString(s);

            }
            if ((double.TryParse(textBox1.Text, out z) == false || double.TryParse(textBox2.Text, out z) == false || double.TryParse(textBox3.Text, out z) == false) && (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""))
            {
                ShowMessageBox(
                            "Исходные данные не корректны",
                            "Сообщение");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
