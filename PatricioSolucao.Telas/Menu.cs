using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatricioSolucao.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void imóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarImovel cadastrarImovel_ = new cadastrarImovel();
            this.Hide();
            cadastrarImovel_.Show();
        }

        private void locatáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrarLocatario cadastrarLocatario_ = new cadastrarLocatario();
            this.Hide();
            cadastrarLocatario_.Show();
        }

        private void locatáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarProprietario cadastrarProprietario_ = new cadastrarProprietario();
            this.Hide();
            cadastrarProprietario_.Show();
        }

        private void imóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarEditarImovel listarEditarImovel_ = new listarEditarImovel();
            this.Hide();
            listarEditarImovel_.Show();
        }

        private void locatáriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listarEditarLocatario listarEditarLocatario_ = new listarEditarLocatario();
            this.Hide();
            listarEditarLocatario_.Show();
        }

        private void proprietáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarEditarProprietario listarEditarProprietario_ = new listarEditarProprietario();
            this.Hide();
            listarEditarProprietario_.Show();
        }

        private void imóveisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listarBaixarImovel listarBaixarImovel_ = new listarBaixarImovel();
            this.Hide();
            listarBaixarImovel_.Show();
        }

        private void locatáriosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listarBaixarLocatario listarBaixarLocatario_ = new listarBaixarLocatario();
            this.Hide();
            listarBaixarLocatario_.Show();
        }

        private void proprietáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listarBaixarProprietario listarBaixarProprietario_ = new listarBaixarProprietario();
            this.Hide();
            listarBaixarProprietario_.Show();
        }

        private void crédtioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro financeiro_ = new Financeiro();
            this.Hide();
            financeiro_.Show();
        }
    }
}
