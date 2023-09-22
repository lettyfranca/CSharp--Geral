using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesObjetosForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Letícia";
            c.Deposita(100);
            MessageBox.Show("Saldo: " + c.saldo);
            c.Saca(50.00);
            MessageBox.Show("Saldo: " + c.saldo);


            //MessageBox.Show(c.titular);

            //	Se	a	conta	tiver	saldo	suficiente,	deuCerto	conterá	o	valor	true
            //	senão,	ela	conterá	false
            bool deuCerto = c.Saca(100.0);
            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            c.Deposita(100.0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if(mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais.");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta menor = new Conta();
            menor.numero = 3;
            menor.titular = "Luizinho";
            menor.saldo = 500;
            menor.idade = 15;

            menor.Saca(200);
        }
    }
}
