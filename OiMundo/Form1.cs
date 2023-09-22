using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int idade1 = 23;
            int idade2 = 16;
            int idade3 = 12;

            int media = (idade1 + idade2 + idade3) / 3;
            MessageBox.Show("A média da idade das minhas irmãs é " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int pi = 3.14;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi; //o int força a conversão da variável double pi para int
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 2, b = 12, c = -14;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2*a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("As raízes são = " + a1 + " e " + a2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso!");
            } else
            {
                MessageBox.Show("Saldo insuficiente!");
            }

        }
    }
}
