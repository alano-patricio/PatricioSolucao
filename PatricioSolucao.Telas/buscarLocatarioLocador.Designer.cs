namespace PatricioSolucao.Telas
{
    partial class buscarLocatarioLocador
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
            this.btnBuscarLocatario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCpfLocatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarLocatario
            // 
            this.btnBuscarLocatario.Location = new System.Drawing.Point(234, 23);
            this.btnBuscarLocatario.Name = "btnBuscarLocatario";
            this.btnBuscarLocatario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLocatario.TabIndex = 35;
            this.btnBuscarLocatario.Text = "Buscar";
            this.btnBuscarLocatario.UseVisualStyleBackColor = true;
            this.btnBuscarLocatario.Click += new System.EventHandler(this.btnBuscarLocatario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "CPF";
            // 
            // txtBuscarCpfLocatario
            // 
            this.txtBuscarCpfLocatario.Location = new System.Drawing.Point(12, 25);
            this.txtBuscarCpfLocatario.Name = "txtBuscarCpfLocatario";
            this.txtBuscarCpfLocatario.Size = new System.Drawing.Size(216, 20);
            this.txtBuscarCpfLocatario.TabIndex = 33;
            this.txtBuscarCpfLocatario.Text = "333.333.333.37";
            // 
            // buscarLocatarioLocador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 54);
            this.Controls.Add(this.btnBuscarLocatario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCpfLocatario);
            this.Name = "buscarLocatarioLocador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatario Locador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buscarLocatario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarLocatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCpfLocatario;
    }
}