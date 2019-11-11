using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
    class ContaCorrente : Conta
    {
        public override bool PodeAbrirContaSozinho => base.PodeAbrirContaSozinho;

        public override void Depositar(double valor)
        {
            base.Depositar(valor -0.10);
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }
    }
}
