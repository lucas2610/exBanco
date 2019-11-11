using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
   public abstract class Conta
    {
        private double saldo;
        private Cliente titular;
        private int numero;
        private int idade;

        public double Saldo { get; private set; }
        public int Numero { get; set; }
        public int Idade { get; private set; }
        internal Cliente Titular { get => titular; set => titular = value; }

        public virtual void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
        }
        public virtual bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade>=18;
                var possuiCpf = !string.IsNullOrEmpty(this.Titular.Cpf);
                return (maiorDeIdade && possuiCpf);

            }
        }
        //public bool Saca2(double valor, int idade)
        //{
        //    if (idade >= 18)
        //    {
        //        if (this.saldo >= valor)
        //        {
        //            this.saldo -= valor;
        //            return true;
        //        }
        //        return false;
        //    }
        //    else if (this.saldo > valor && valor <= 200 && this.idade<18)
        //    {
        //        this.saldo -= valor;
        //        return true;
        //    }

        //    return false;
        //}
        //public void Transfere(double valor, Conta conta)
        //{
        //    if (this.Saca(valor))
        //    {
        //        conta.Depositar(valor);
        //    }
        //}
    }
}
