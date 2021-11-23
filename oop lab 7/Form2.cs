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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Calc()
        {
            double z, a, b, gip;

            if (double.TryParse(textBox1.Text, out z) && double.TryParse(textBox2.Text, out z))
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                gip = Math.Sqrt(a * a + b * b);

                if (a + b <= gip || a + gip <= b || b + gip <= a)
                    richTextBox1.Text = "Данный треугольник не существует";
                else
                    richTextBox1.Text = Convert.ToString(gip);
            }
            else
            {
                richTextBox1.Text = "Неверный тип  данных";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
