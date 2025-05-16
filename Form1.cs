using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclo_FOR_JR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textNumero1.Text, out int num))
            {
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add($"{i}*{num} {num*i}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }
    }
}
