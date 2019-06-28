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
    public partial class listarEditarLocatario : Form  
    {
        private LocatarioDao _locatarioDao;
        private List<Locatario> _listaLocatario;

        public listarEditarLocatario()
        {
            InitializeComponent();
            _listaLocatario = new List<Locatario>();
            _locatarioDao = new LocatarioDao();
          
        }

        private void listarEditarLocatario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void buscarLocatarioBuscar_Click(object sender, EventArgs e)
        {
            var cpfBuscado = buscarLocatarioCpf.Text;
            try
            {
                _listaLocatario.Clear();

                _listaLocatario = _locatarioDao.BuscarLocatarioPeloCpfComLike(cpfBuscado);

                dvgListarLocatario.DataSource = _listaLocatario;

                buscarLocatarioCpf.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dvgListarLocatario_DoubleClick(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dvgListarLocatario.CurrentRow.Cells["Id"].Value);

            var enviaIdParaEdicacao = new editarLocatario(idSelecionado);

            this.Hide();

            enviaIdParaEdicacao.Show();
        }
    }
}
