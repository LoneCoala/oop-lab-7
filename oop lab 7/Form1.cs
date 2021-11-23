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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void заToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void задача3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void задача4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes) Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes) Application.Exit();
        }
    }
}
