namespace PatricioSolucao.Telas
{
    partial class cadastrarProprietario
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrarProprietarioAdd = new System.Windows.Forms.Button();
            this.cadastrarProprietarioBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cadastrarProprietarioRg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarProprietarioCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastrarProprietarioNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarProprietarioData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cadastrarProprietarioAdd
            // 
            this.cadastrarProprietarioAdd.Location = new System.Drawing.Point(661, 109);
            this.cadastrarProprietarioAdd.Name = "cadastrarProprietarioAdd";
            this.cadastrarProprietarioAdd.Size = new System.Drawing.Size(75, 23);
            this.cadastrarProprietarioAdd.TabIndex = 5;
            this.cadastrarProprietarioAdd.Text = "Adicionar";
            this.cadastrarProprietarioAdd.UseVisualStyleBackColor = true;
            this.cadastrarProprietarioAdd.Click += new System.EventHandler(this.cadastrarProprietarioAdd_Click);
            // 
            // cadastrarProprietarioBanco
            // 
            this.cadastrarProprietarioBanco.Location = new System.Drawing.Point(306, 74);
            this.cadastrarProprietarioBanco.Name = "cadastrarProprietarioBanco";
            this.cadastrarProprietarioBanco.Size = new System.Drawing.Size(430, 20);
            this.cadastrarProprietarioBanco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dados bancários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Data de nascimento";
            // 
            // cadastrarProprietarioRg
            // 
            this.cadastrarProprietarioRg.Location = new System.Drawing.Point(529, 23);
            this.cadastrarProprietarioRg.Name = "cadastrarProprietarioRg";
            this.cadastrarProprietarioRg.Size = new System.Drawing.Size(207, 20);
            this.cadastrarProprietarioRg.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "RG";
            // 
            // cadastrarProprietarioCpf
            // 
            this.cadastrarProprietarioCpf.Location = new System.Drawing.Point(306, 23);
            this.cadastrarProprietarioCpf.Name = "cadastrarProprietarioCpf";
            this.cadastrarProprietarioCpf.Size = new System.Drawing.Size(207, 20);
            this.cadastrarProprietarioCpf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "CPF";
            // 
            // cadastrarProprietarioNome
            // 
            this.cadastrarProprietarioNome.Location = new System.Drawing.Point(12, 23);
            this.cadastrarProprietarioNome.Name = "cadastrarProprietarioNome";
            this.cadastrarProprietarioNome.Size = new System.Drawing.Size(279, 20);
            this.cadastrarProprietarioNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome";
            // 
            // cadastrarProprietarioData
            // 
            this.cadastrarProprietarioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cadastrarProprietarioData.Location = new System.Drawing.Point(12, 74);
            this.cadastrarProprietarioData.Name = "cadastrarProprietarioData";
            this.cadastrarProprietarioData.Size = new System.Drawing.Size(279, 20);
            this.cadastrarProprietarioData.TabIndex = 3;
            // 
            // cadastrarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 135);
            this.Controls.Add(this.cadastrarProprietarioData);
            this.Controls.Add(this.cadastrarProprietarioAdd);
            this.Controls.Add(this.cadastrarProprietarioBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cadastrarProprietarioRg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadastrarProprietarioCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastrarProprietarioNome);
            this.Controls.Add(this.label1);
            this.Name = "cadastrarProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proprietário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadastrarProprietario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button cadastrarProprietarioAdd;
        private System.Windows.Forms.TextBox cadastrarProprietarioBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cadastrarProprietarioRg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cadastrarProprietarioCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cadastrarProprietarioNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cadastrarProprietarioData;
    }
}