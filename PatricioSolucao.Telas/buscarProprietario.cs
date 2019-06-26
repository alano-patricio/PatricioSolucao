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
    public partial class buscarProprietario : Form
    {
        private ProprietarioDao _proprietarioDao;
        private Proprietario _proprietarioEncontrado;

        public buscarProprietario()
        {
            InitializeComponent();
            _proprietarioDao = new ProprietarioDao();
        }

        private void btnBuscarProprietario_Click(object sender, EventArgs e)
        {
            var cpf = txtBuscarCpfProprietario.Text;
            
            _proprietarioEncontrado = _proprietarioDao.BuscarPorCpf(cpf);
            this.Hide();
            var enviaProprietarioParaImovel = new cadastrarImovel(_proprietarioEncontrado.nome, _proprietarioEncontrado.id);
            enviaProprietarioParaImovel.Show();
        }

        private void buscarProprietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }
    }
}