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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            double z, a, b, x, y, zz;

            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                x = a + b;

                richTextBox1.Text = "X = " + Convert.ToString(x);

            }
            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox2.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                y = a / b;

                richTextBox1.Text = "Y = " + Convert.ToString(y);

            }
            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox3.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                z = a * b;

                richTextBox1.Text = "Z = " + Convert.ToString(z);


            }

            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked && checkBox2.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                x = a + b;
                y = a / b;

                richTextBox1.Text = "X = " + Convert.ToString(x) + "\n" + "Y = " + Convert.ToString(y);

            }

            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked && checkBox3.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                x = a + b;
                z = a * b;

                richTextBox1.Text = "X = " + Convert.ToString(x) + "\n" + "Z = " + Convert.ToString(z);

            }

            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox2.Checked && checkBox3.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);


                y = a / b;
                z = a * b;

                richTextBox1.Text = "Y = " + Convert.ToString(y) + "\n" + "Z = " + Convert.ToString(z);

            }
            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                x = a + b;
                y = a / b;
                z = a * b;

                richTextBox1.Text = "X = " + Convert.ToString(x) + "\n" + "Y = " + Convert.ToString(y) + "\n" + "Z = " + Convert.ToString(z);

            }
            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {

                richTextBox1.Text = "";

            }

            if (double.TryParse(textBox1.Text, out zz) && double.TryParse(textBox2.Text, out zz) && checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {

                richTextBox1.Text = "";

            }
            if ((double.TryParse(textBox1.Text, out zz) == false || double.TryParse(textBox2.Text, out zz) == false) && (textBox1.Text != "" && textBox2.Text != ""))
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
