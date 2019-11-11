namespace Banco_Lucas
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(76, 16);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(76, 42);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.buttonCadastro);
            this.Cadastro.Controls.Add(this.label1);
            this.Cadastro.Controls.Add(this.label2);
            this.Cadastro.Controls.Add(this.textoNumero);
            this.Cadastro.Controls.Add(this.textoTitular);
            this.Cadastro.Location = new System.Drawing.Point(281, 37);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(200, 128);
            this.Cadastro.TabIndex = 4;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "Novo Cadastro";
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Location = new System.Drawing.Point(76, 69);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(100, 23);
            this.buttonCadastro.TabIndex = 4;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastro);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Cadastro;
        private System.Windows.Forms.Button buttonCadastro;
    }
}