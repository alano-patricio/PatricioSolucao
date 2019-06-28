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
    public partial class editarLocatario : Form
    {
        private LocatarioDao _locatarioDao;
        private Locatario _locatarioEncontrado;
        private int idSelecionado;
        public editarLocatario()
        {
            InitializeComponent();
        }

        public editarLocatario(int idSelecionado)
        {
            InitializeComponent();
            _locatarioDao = new LocatarioDao();
            this.idSelecionado = idSelecionado;
            _locatarioEncontrado = _locatarioDao.BuscarLocatarioPeloId(idSelecionado);
            editarLocatarioNome.Text = _locatarioEncontrado.nome;
            editarLocatarioCpf.Text = _locatarioEncontrado.cpf;
            editarLocatarioRg.Text = _locatarioEncontrado.rg;
            editarLocatarioData.Text = _locatarioEncontrado.dataNascimento.ToString();
            editarLocatarioRenda.Text = _locatarioEncontrado.renda.ToString();
            editarLocatarioAvalista.Checked = _locatarioEncontrado.avalista;
            editarLocatarioAvalistaNome.Text = _locatarioEncontrado.nomeAvalista;
            editarLocatarioAvalistaCpf.Text = _locatarioEncontrado.cpfAvalista;
            editarLocatarioAvalistaRenda.Text = _locatarioEncontrado.rendaAvalista.ToString();
        }
    }
}
