namespace Banco_Lucas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumeroConta = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.Button_Depositar = new System.Windows.Forms.Button();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNovaConta = new System.Windows.Forms.Button();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClientes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(102, 29);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumeroConta
            // 
            this.textoNumeroConta.Location = new System.Drawing.Point(102, 55);
            this.textoNumeroConta.Name = "textoNumeroConta";
            this.textoNumeroConta.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroConta.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(102, 81);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(102, 107);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            // 
            // Button_Depositar
            // 
            this.Button_Depositar.Location = new System.Drawing.Point(127, 157);
            this.Button_Depositar.Name = "Button_Depositar";
            this.Button_Depositar.Size = new System.Drawing.Size(75, 23);
            this.Button_Depositar.TabIndex = 4;
            this.Button_Depositar.Text = "Depositar";
            this.Button_Depositar.UseVisualStyleBackColor = true;
            this.Button_Depositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonSaque
            // 
            this.buttonSaque.Location = new System.Drawing.Point(25, 157);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(75, 23);
            this.buttonSaque.TabIndex = 5;
            this.buttonSaque.Text = "Saque";
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNovaConta);
            this.groupBox1.Controls.Add(this.textBoxValorTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSaque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoNumeroConta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.Button_Depositar);
            this.groupBox1.Location = new System.Drawing.Point(214, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // buttonNovaConta
            // 
            this.buttonNovaConta.Location = new System.Drawing.Point(25, 196);
            this.buttonNovaConta.Name = "buttonNovaConta";
            this.buttonNovaConta.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaConta.TabIndex = 12;
            this.buttonNovaConta.Text = "Nova Conta";
            this.buttonNovaConta.UseVisualStyleBackColor = true;
            this.buttonNovaConta.Click += new System.EventHandler(this.buttonNovaConta_Click);
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(102, 133);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(97, 35);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(102, 21);
            this.comboContas.TabIndex = 14;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Escolha a Conta";
            // 
            // textBoxClientes
            // 
            this.textBoxClientes.Location = new System.Drawing.Point(214, 378);
            this.textBoxClientes.Multiline = true;
            this.textBoxClientes.Name = "textBoxClientes";
            this.textBoxClientes.Size = new System.Drawing.Size(365, 107);
            this.textBoxClientes.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.textBoxClientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumeroConta;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button Button_Depositar;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button buttonNovaConta;
        private System.Windows.Forms.TextBox textBoxClientes;
    }
}

