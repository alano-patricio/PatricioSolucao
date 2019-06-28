namespace PatricioSolucao.Telas
{
    partial class listarEditarProprietario
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
            this.dgvListarProprietario = new System.Windows.Forms.DataGridView();
            this.buscarProprietarioBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarProprietarioCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProprietario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarProprietario
            // 
            this.dgvListarProprietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarProprietario.Location = new System.Drawing.Point(12, 61);
            this.dgvListarProprietario.Name = "dgvListarProprietario";
            this.dgvListarProprietario.Size = new System.Drawing.Size(657, 211);
            this.dgvListarProprietario.TabIndex = 29;
            this.dgvListarProprietario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvListarProprietario_MouseDoubleClick);
            // 
            // buscarProprietarioBuscar
            // 
            this.buscarProprietarioBuscar.Location = new System.Drawing.Point(231, 21);
            this.buscarProprietarioBuscar.Name = "buscarProprietarioBuscar";
            this.buscarProprietarioBuscar.Size = new System.Drawing.Size(75, 23);
            this.buscarProprietarioBuscar.TabIndex = 28;
            this.buscarProprietarioBuscar.Text = "Buscar";
            this.buscarProprietarioBuscar.UseVisualStyleBackColor = true;
            this.buscarProprietarioBuscar.Click += new System.EventHandler(this.buscarProprietarioBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "CPF Proprietário";
            // 
            // buscarProprietarioCpf
            // 
            this.buscarProprietarioCpf.Location = new System.Drawing.Point(9, 23);
            this.buscarProprietarioCpf.Name = "buscarProprietarioCpf";
            this.buscarProprietarioCpf.Size = new System.Drawing.Size(216, 20);
            this.buscarProprietarioCpf.TabIndex = 26;
            // 
            // listarEditarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 283);
            this.Controls.Add(this.dgvListarProprietario);
            this.Controls.Add(this.buscarProprietarioBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarProprietarioCpf);
            this.Name = "listarEditarProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Proprietários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listarEditarProprietario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProprietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarProprietario;
        private System.Windows.Forms.Button buscarProprietarioBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarProprietarioCpf;
    }
}