using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Lucas
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private Conta[] contas;
        private int numeroDeContas;

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);

        }
        public void AdicionarLista(Conta conta)
        {
            
            textBoxClientes.Text += "\nTitular: " + conta.Titular.Nome;
        }
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[3];

            Conta conta1 = new ContaCorrente();
            conta1.Titular = new Cliente("João");
            conta1.Numero = 1;
            this.AdicionaConta(conta1);
            this.AdicionarLista(conta1);

            Conta conta2 = new ContaPoupanca();
            conta2.Titular = new Cliente("Lucas");
            conta2.Numero = 1;
            this.AdicionaConta(conta2);
            this.AdicionarLista(conta2);

            Conta conta3 = new ContaCorrente();
            conta3.Titular = new Cliente("Pedro");
            conta3.Numero = 1;
            this.AdicionaConta(conta3);
            this.AdicionarLista(conta3);


            //foreach (Conta conta in contas)
            //{
            //    comboContas.Items.Add("Titular: " + conta.Titular.Nome);
            //}



        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            String valorDigitado = textoValor.Text;
            double valorDepositado = Convert.ToDouble(valorDigitado);
            selecionada.Depositar(valorDepositado);
            //this.conta.Depositar(valorDepositado);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            //TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();
            //totalizadorDeContas.Soma(conta);
            //textBoxValorTotal.Text = Convert.ToString(totalizadorDeContas.Valor);


        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Saca(valorOperacao);
            // this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
           

        }

        private void buttonBuscarConta_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumeroConta.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumeroConta.Text = Convert.ToString(selecionada.Numero);
        }

        private void buttonNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();

        }
    }
}
