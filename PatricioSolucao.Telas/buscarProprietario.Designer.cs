namespace PatricioSolucao.Telas
{
    partial class buscarProprietario
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
            this.btnBuscarProprietario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCpfProprietario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarProprietario
            // 
            this.btnBuscarProprietario.Location = new System.Drawing.Point(231, 20);
            this.btnBuscarProprietario.Name = "btnBuscarProprietario";
            this.btnBuscarProprietario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProprietario.TabIndex = 32;
            this.btnBuscarProprietario.Text = "Buscar";
            this.btnBuscarProprietario.UseVisualStyleBackColor = true;
            this.btnBuscarProprietario.Click += new System.EventHandler(this.btnBuscarProprietario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "CPF";
            // 
            // txtBuscarCpfProprietario
            // 
            this.txtBuscarCpfProprietario.Location = new System.Drawing.Point(9, 22);
            this.txtBuscarCpfProprietario.Name = "txtBuscarCpfProprietario";
            this.txtBuscarCpfProprietario.Size = new System.Drawing.Size(216, 20);
            this.txtBuscarCpfProprietario.TabIndex = 30;
            // 
            // buscarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 53);
            this.Controls.Add(this.btnBuscarProprietario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCpfProprietario);
            this.Name = "buscarProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Proprietários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buscarProprietario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarProprietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCpfProprietario;
    }
}