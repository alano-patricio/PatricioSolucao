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
        private object dgvListarProprietario;

        public listarEditarLocatario()
        {
            InitializeComponent();
            _listaLocatario = new List<Locatario>();
            dgvListarProprietario.DataSource = _locatarioDao.BuscarLocatarioPeloCpf();
            //dgvListarProprietario.DataSource = (List<Locatario>)_locatarioDao.BuscarLocatarioPeloCpf(); sugestão que não funcionou
        }

        private void listarEditarLocatario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void buscarLocatarioBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BuscaListaLocatario()
        {

            //Limpando a lista de contatos
            _listaLocatario.Clear();

            //Indo no banco e trazendo todos os contatos registrados.
            _listaLocatario = (List<Locatario>)_locatarioDao.BuscarLocatarioPeloCpf();

            //Adicionando a lista de contato no grid view.
            dgvListarProprietario.DataSource = _listaLocatario;
        }
    }
}
