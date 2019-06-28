namespace PatricioSolucao.Telas
{
    partial class listarEditarImovel
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
            this.buscarImovelCpfProprietario = new System.Windows.Forms.TextBox();
            this.dvgListarImovel = new System.Windows.Forms.DataGridView();
            this.buscarImovelBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarImovel)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarImovelCpfProprietario
            // 
            this.buscarImovelCpfProprietario.Location = new System.Drawing.Point(12, 24);
            this.buscarImovelCpfProprietario.Name = "buscarImovelCpfProprietario";
            this.buscarImovelCpfProprietario.Size = new System.Drawing.Size(216, 20);
            this.buscarImovelCpfProprietario.TabIndex = 36;
            // 
            // dvgListarImovel
            // 
            this.dvgListarImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarImovel.Location = new System.Drawing.Point(12, 63);
            this.dvgListarImovel.Name = "dvgListarImovel";
            this.dvgListarImovel.Size = new System.Drawing.Size(738, 211);
            this.dvgListarImovel.TabIndex = 33;
            // 
            // buscarImovelBuscar
            // 
            this.buscarImovelBuscar.Location = new System.Drawing.Point(234, 22);
            this.buscarImovelBuscar.Name = "buscarImovelBuscar";
            this.buscarImovelBuscar.Size = new System.Drawing.Size(75, 23);
            this.buscarImovelBuscar.TabIndex = 32;
            this.buscarImovelBuscar.Text = "Buscar";
            this.buscarImovelBuscar.UseVisualStyleBackColor = true;
            this.buscarImovelBuscar.Click += new System.EventHandler(this.buscarImovelBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "CPF proprietario";
            // 
            // listarEditarImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarImovelCpfProprietario);
            this.Controls.Add(this.dvgListarImovel);
            this.Controls.Add(this.buscarImovelBuscar);
            this.Name = "listarEditarImovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Imóveis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listarEditarImovel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarImovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox buscarImovelCpfProprietario;
        private System.Windows.Forms.DataGridView dvgListarImovel;
        private System.Windows.Forms.Button buscarImovelBuscar;
        private System.Windows.Forms.Label label3;
    }
}