using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int agencia;
        public string conta;
        public string titular;
        public double saldo;


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(valor <= this.saldo)
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
