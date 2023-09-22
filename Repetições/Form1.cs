using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repetições
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while(i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i++;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i++)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1;
            int soma = 0;
            while (i <= 1000)
            {
                soma += i;
                i++;
            }
            MessageBox.Show("A soma é = " + soma);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("Número: " + i);
                }
                i++;
            } 
            while (i <= 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    num += i;
                }
                
            }
            MessageBox.Show("Resultado = " + num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("Numero = " + i);
                }
                else if (i % 4 == 0)
                {
                    MessageBox.Show("Numero = " + i);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1;n <= 10; n++)
            {
                fatorial = n * fatorial;
                MessageBox.Show("Fatorial de " + n + " é " + fatorial);
            }
        }

        private void Ex07_Click(object sender, EventArgs e)
        {
            int termoAnterior = 0, termoAtual = 1, termoX;

            //MessageBox.Show("O termo 0 é " + termo1);
            //MessageBox.Show("O termo 1 é " + termo2);

            for (int i = 2; i <= 100; i++)
            {
                termoX = termoAnterior + termoAtual;
                MessageBox.Show("Termos" + i + termoAnterior + termoAtual);
                //MessageBox.Show("O termo " + i + " é " + termoX);
                termoAnterior = termoAtual;
                termoAtual = termoX;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    int resultado = a * b;
                    MessageBox.Show("" + resultado);
                }
                Console.WriteLine("");
            }
        }
    }
}
