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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void ShowMessageBox(string message, string text)
        {
            bool showed = false;
            if (!showed)
                MessageBox.Show(message, text);
            showed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calc()
        {
            double z, a, b, c, y;

            if (double.TryParse(textBox1.Text, out z) && double.TryParse(textBox2.Text, out z) && radioButton1.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                y = a + b;

                textBox3.Text = Convert.ToString(y);

            }

            if (double.TryParse(textBox1.Text, out z) && double.TryParse(textBox2.Text, out z) && radioButton2.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                y = a / b;

                textBox3.Text = Convert.ToString(y);

            }
            if (double.TryParse(textBox1.Text, out z) && double.TryParse(textBox2.Text, out z) && radioButton3.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                y = a * b;

                textBox3.Text = Convert.ToString(y);

            }





            if ((double.TryParse(textBox1.Text, out z) == false || double.TryParse(textBox2.Text, out z) == false) && (textBox1.Text != "" && textBox2.Text != ""))
            {
                ShowMessageBox(
                            "Исходные данные не корректны",
                            "Сообщение");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
