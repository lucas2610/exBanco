using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ContaPoupanca cp)
        {
            Total += cp.CalculaTributo();
        }
        public void Acumula(ContaInvestimento ci)
        {
            Total += ci.CalculaTributo();
        }
    }
}
