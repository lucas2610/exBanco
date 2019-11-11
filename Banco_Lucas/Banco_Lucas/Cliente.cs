using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Lucas
{
    class Cliente
    {
        //atributos
        private String nome;
        public String cpf;
        public String rg;
        public String endereco;
        //get(leitura) e set(escrita) 
        public String Nome { get; private set; }
        public String Cpf { get; private set; }
        public String Rg { get; private set; }
        public String Endereco { get; private set; }
        //Construtor
        public Cliente(string nome)
        {
            this.Nome = nome;
           
        }
    }
}
