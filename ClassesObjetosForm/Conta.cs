using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesObjetosForm
{
    internal class Conta
    {
        public int numero;
        public string titular;
        public double saldo = 100.0;
        public int idade;

        public bool Saca(double valor)
        {
            
            if (this.saldo >= valor)
            {
                if (this.idade < 18 && valor > 200.0)
                {
                    MessageBox.Show("Você só pode efetuar saques de até R$200,00");
                }
                else 
                {
                    this.saldo -= valor;
                    return true;
                }
                
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if(this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
