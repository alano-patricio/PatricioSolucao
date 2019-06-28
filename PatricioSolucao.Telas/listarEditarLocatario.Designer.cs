namespace PatricioSolucao.Telas
{
    partial class listarEditarLocatario
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
            this.dvgListarLocatario = new System.Windows.Forms.DataGridView();
            this.buscarLocatarioBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarLocatarioCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarLocatario)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListarLocatario
            // 
            this.dvgListarLocatario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarLocatario.Location = new System.Drawing.Point(12, 63);
            this.dvgListarLocatario.Name = "dvgListarLocatario";
            this.dvgListarLocatario.Size = new System.Drawing.Size(657, 211);
            this.dvgListarLocatario.TabIndex = 25;
            // 
            // buscarLocatarioBuscar
            // 
            this.buscarLocatarioBuscar.Location = new System.Drawing.Point(231, 23);
            this.buscarLocatarioBuscar.Name = "buscarLocatarioBuscar";
            this.buscarLocatarioBuscar.Size = new System.Drawing.Size(75, 23);
            this.buscarLocatarioBuscar.TabIndex = 24;
            this.buscarLocatarioBuscar.Text = "Buscar";
            this.buscarLocatarioBuscar.UseVisualStyleBackColor = true;
            this.buscarLocatarioBuscar.Click += new System.EventHandler(this.buscarLocatarioBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CPF Locatário";
            // 
            // buscarLocatarioCpf
            // 
            this.buscarLocatarioCpf.Location = new System.Drawing.Point(9, 25);
            this.buscarLocatarioCpf.Name = "buscarLocatarioCpf";
            this.buscarLocatarioCpf.Size = new System.Drawing.Size(216, 20);
            this.buscarLocatarioCpf.TabIndex = 22;
            // 
            // listarEditarLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 286);
            this.Controls.Add(this.dvgListarLocatario);
            this.Controls.Add(this.buscarLocatarioBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarLocatarioCpf);
            this.Name = "listarEditarLocatario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Locatários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.listarEditarLocatario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarLocatario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListarLocatario;
        private System.Windows.Forms.Button buscarLocatarioBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarLocatarioCpf;
    }
}