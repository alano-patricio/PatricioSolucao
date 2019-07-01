namespace PatricioSolucao.Telas
{
    partial class cadastrarFinanceiro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastrarFinanceiroValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarFinanceiroBalanco = new System.Windows.Forms.TextBox();
            this.cadastrarFinanceiroOperacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balanço";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // cadastrarFinanceiroValor
            // 
            this.cadastrarFinanceiroValor.Location = new System.Drawing.Point(15, 23);
            this.cadastrarFinanceiroValor.Name = "cadastrarFinanceiroValor";
            this.cadastrarFinanceiroValor.Size = new System.Drawing.Size(148, 20);
            this.cadastrarFinanceiroValor.TabIndex = 0;
            this.cadastrarFinanceiroValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cadastrarFinanceiroValor_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Processar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operação";
            // 
            // cadastrarFinanceiroBalanco
            // 
            this.cadastrarFinanceiroBalanco.Location = new System.Drawing.Point(295, 23);
            this.cadastrarFinanceiroBalanco.Name = "cadastrarFinanceiroBalanco";
            this.cadastrarFinanceiroBalanco.Size = new System.Drawing.Size(148, 20);
            this.cadastrarFinanceiroBalanco.TabIndex = 7;
            // 
            // cadastrarFinanceiroOperacao
            // 
            this.cadastrarFinanceiroOperacao.FormattingEnabled = true;
            this.cadastrarFinanceiroOperacao.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.cadastrarFinanceiroOperacao.Location = new System.Drawing.Point(169, 23);
            this.cadastrarFinanceiroOperacao.Name = "cadastrarFinanceiroOperacao";
            this.cadastrarFinanceiroOperacao.Size = new System.Drawing.Size(120, 21);
            this.cadastrarFinanceiroOperacao.TabIndex = 1;
            // 
            // cadastrarFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 81);
            this.Controls.Add(this.cadastrarFinanceiroOperacao);
            this.Controls.Add(this.cadastrarFinanceiroBalanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cadastrarFinanceiroValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastrarFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Financeiro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cadastrarFinanceiroValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cadastrarFinanceiroBalanco;
        private System.Windows.Forms.ComboBox cadastrarFinanceiroOperacao;
    }
}