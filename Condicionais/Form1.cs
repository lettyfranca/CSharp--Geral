using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicionais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo.");
            }   
            else if (saldo < 100000.0) {
                MessageBox.Show("Você é um bom cliente.");
            }
            else
            {
                MessageBox.Show("Você é milionário.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade = 10;
            bool brasileira = true;

            if ((idade >= 16) && (brasileira ==  true)) 
            {
                MessageBox.Show("Você está apto a votar.");
            }
            else
            {
                MessageBox.Show("Você não pode votar.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 3650.1;

            if (valorDaNotaFiscal <= 999)
            {
                valorDaNotaFiscal += (valorDaNotaFiscal * 2) / 100;
                MessageBox.Show("O valor da nota com imposto é = " + valorDaNotaFiscal);
            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
            {
                valorDaNotaFiscal += (valorDaNotaFiscal * 2.5) / 100;
                MessageBox.Show("O valor da nota com imposto é = " + valorDaNotaFiscal);
            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                valorDaNotaFiscal += (valorDaNotaFiscal * 2.8) / 100;
                MessageBox.Show("O valor da nota com imposto é = " + valorDaNotaFiscal);
            }
            else
            {
                valorDaNotaFiscal += (valorDaNotaFiscal * 3) / 100;
                MessageBox.Show("O valor da nota com imposto é = " + valorDaNotaFiscal);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor = 8;
            string mensagem = "";

            mensagem = valor >= 10 ? "Maior que dez!" : "Menor que dez!";
            MessageBox.Show(mensagem);
        }
    }
}
