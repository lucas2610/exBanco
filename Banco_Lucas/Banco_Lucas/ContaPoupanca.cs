using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
    public class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}
