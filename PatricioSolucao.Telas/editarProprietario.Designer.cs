namespace PatricioSolucao.Telas
{
    partial class editarProprietario
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
            this.editarProprietarioBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editarProprietarioRg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editarProprietarioCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editarProprietarioNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editarProprietarioData = new System.Windows.Forms.DateTimePicker();
            this.editarProprietarioAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editarProprietarioBanco
            // 
            this.editarProprietarioBanco.Location = new System.Drawing.Point(306, 76);
            this.editarProprietarioBanco.Name = "editarProprietarioBanco";
            this.editarProprietarioBanco.Size = new System.Drawing.Size(430, 20);
            this.editarProprietarioBanco.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dados bancários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Data de nascimento";
            // 
            // editarProprietarioRg
            // 
            this.editarProprietarioRg.Location = new System.Drawing.Point(529, 25);
            this.editarProprietarioRg.Name = "editarProprietarioRg";
            this.editarProprietarioRg.Size = new System.Drawing.Size(207, 20);
            this.editarProprietarioRg.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "RG";
            // 
            // editarProprietarioCpf
            // 
            this.editarProprietarioCpf.Location = new System.Drawing.Point(306, 25);
            this.editarProprietarioCpf.Name = "editarProprietarioCpf";
            this.editarProprietarioCpf.Size = new System.Drawing.Size(207, 20);
            this.editarProprietarioCpf.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "CPF";
            // 
            // editarProprietarioNome
            // 
            this.editarProprietarioNome.Location = new System.Drawing.Point(12, 25);
            this.editarProprietarioNome.Name = "editarProprietarioNome";
            this.editarProprietarioNome.Size = new System.Drawing.Size(279, 20);
            this.editarProprietarioNome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // editarProprietarioData
            // 
            this.editarProprietarioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.editarProprietarioData.Location = new System.Drawing.Point(12, 76);
            this.editarProprietarioData.Name = "editarProprietarioData";
            this.editarProprietarioData.Size = new System.Drawing.Size(279, 20);
            this.editarProprietarioData.TabIndex = 34;
            // 
            // editarProprietarioAlterar
            // 
            this.editarProprietarioAlterar.Location = new System.Drawing.Point(661, 153);
            this.editarProprietarioAlterar.Name = "editarProprietarioAlterar";
            this.editarProprietarioAlterar.Size = new System.Drawing.Size(75, 23);
            this.editarProprietarioAlterar.TabIndex = 32;
            this.editarProprietarioAlterar.Text = "Alterar";
            this.editarProprietarioAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarProprietarioAlterar.UseVisualStyleBackColor = true;
            this.editarProprietarioAlterar.Click += new System.EventHandler(this.editarProprietarioAlterar_Click);
            // 
            // editarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 184);
            this.Controls.Add(this.editarProprietarioData);
            this.Controls.Add(this.editarProprietarioAlterar);
            this.Controls.Add(this.editarProprietarioBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editarProprietarioRg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editarProprietarioCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editarProprietarioNome);
            this.Controls.Add(this.label1);
            this.Name = "editarProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proprietario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.editarProprietario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editarProprietarioBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editarProprietarioRg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editarProprietarioCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editarProprietarioNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker editarProprietarioData;
        private System.Windows.Forms.Button editarProprietarioAlterar;
    }
}