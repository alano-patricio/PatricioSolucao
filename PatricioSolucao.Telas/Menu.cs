using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados;
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
        private ImovelDao _imovelDao;
        private List<Imovel> _listaImovel;
        public Menu()
        {
            InitializeComponent();
            _imovelDao = new ImovelDao();
            _listaImovel = new List<Imovel>();
        }

        private void imóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarProprietario buscarProprietario_ = new buscarProprietario();
            this.Hide();
            MessageBox.Show("Digite o CPF do proprietario do imóvel que deseja cadastrar");
            buscarProprietario_.Show();
            
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
            buscarProprietario listarBaixarProprietario_ = new buscarProprietario();
            this.Hide();
            listarBaixarProprietario_.Show();
        }

        private void crédtioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarFinanceiro financeiro_ = new cadastrarFinanceiro();
            this.Hide();
            financeiro_.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imoveisControl_Click(object sender, EventArgs e)
        {
            // menuVender.Hide();
        }

        private void listarTodosImoveis_Click(object sender, EventArgs e)
        {
            dvgListarLocar.DataSource = null;
            dvgListarVender.DataSource = null;
            dvgListarVendidos.DataSource = null;
            dvgListarLocados.DataSource = null;
            _listaImovel.Clear();
            _listaImovel = _imovelDao.BuscarImovelPorSituacao("0");
            dvgListarLocar.DataSource = _listaImovel;
        }

        private void dvgListarVender_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listarTodosImoveis2_Click(object sender, EventArgs e)
        {
            dvgListarLocar.DataSource = null;
            dvgListarVender.DataSource = null;
            dvgListarVendidos.DataSource = null;
            dvgListarLocados.DataSource = null;
            _listaImovel.Clear();
            _listaImovel = _imovelDao.BuscarImovelPorSituacao("2");
            dvgListarVender.DataSource = _listaImovel;
        }

        private void listarTodosImoveis3_Click(object sender, EventArgs e)
        {
            dvgListarLocar.DataSource = null;
            dvgListarVender.DataSource = null;
            dvgListarVendidos.DataSource = null;
            dvgListarLocados.DataSource = null;
            _listaImovel.Clear();
            _listaImovel = _imovelDao.BuscarImovelPorSituacao("1");
            dvgListarLocados.DataSource = _listaImovel;
        }

        private void listarTodosImoveis4_Click(object sender, EventArgs e)
        {
            dvgListarLocar.DataSource = null;
            dvgListarVender.DataSource = null;
            dvgListarVendidos.DataSource = null;
            dvgListarLocados.DataSource = null;
            _listaImovel.Clear();
            _listaImovel = _imovelDao.BuscarImovelPorSituacao("3");
            dvgListarVendidos.DataSource = _listaImovel;
        }

        private void dvgListarLocar_DoubleClick(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dvgListarLocar.CurrentRow.Cells["Id"].Value);

            var enviaIdParaEdicacao = new buscarLocatarioLocador(idSelecionado);

            this.Hide();
            MessageBox.Show("Informe o CPF completo do locatario");
            enviaIdParaEdicacao.Show();
        }

        private void dvgListarVender_DoubleClick(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dvgListarVender.CurrentRow.Cells["Id"].Value);

            var enviaIdParaCompra = new buscarLocatarioComprador(idSelecionado);

            this.Hide();
            MessageBox.Show("Informe o CPF completo do comprador");
            enviaIdParaCompra.Show();
        }

        private void listarTodosImoveis_Leave(object sender, EventArgs e)
        {
            _listaImovel.Clear();
        }
    }
}
