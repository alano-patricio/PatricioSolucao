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
    public partial class listarEditarImovel : Form
    {
        private ImovelDao _imovelDao;
        private List<Imovel> _listaImovel;

        public listarEditarImovel()
        {
            InitializeComponent();
            _listaImovel = new List<Imovel>();
            _imovelDao = new ImovelDao();
        }

        private void listarEditarImovel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void buscarImovelBuscar_Click(object sender, EventArgs e)
        {
            var cpfBuscado = buscarImovelCpfProprietario.Text;
            try
            {
                _listaImovel.Clear();

                _listaImovel = _imovelDao.BuscarImovelPorCpfProprietario(cpfBuscado);

                dvgListarImovel.DataSource = _listaImovel;

                buscarImovelCpfProprietario.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dvgListarImovel_DoubleClick(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dvgListarImovel.CurrentRow.Cells["Id"].Value);

            var enviaIdParaEdicacao = new editarImovel(idSelecionado);

            this.Hide();

            enviaIdParaEdicacao.Show();
        }
    }
}
