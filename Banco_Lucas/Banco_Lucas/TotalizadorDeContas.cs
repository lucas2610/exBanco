using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
    class TotalizadorDeContas
    {
        private double valor;

        public double Valor { get => valor; set => valor = value; }

        public void Soma(Conta conta)
        {
            Valor += conta.Saldo;
        }
    }
}
