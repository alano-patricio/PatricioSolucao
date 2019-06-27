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
    public partial class cadastrarLocatario : Form
    {
        private LocatarioDao _locatarioDao;

        public cadastrarLocatario()
        {
            InitializeComponent();
            _locatarioDao = new LocatarioDao();
        }

        private void cadastrarLocatario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Locatario locatario = new Locatario()
            {
                nome = cadastrarLocatarioNome.Text,
                cpf = cadastrarLocatarioCpf.Text,
                rg = cadastrarLocatarioRg.Text,
                dataNascimento = DateTime.Parse(cadastrarLocatarioData.Text),
                renda = float.Parse(cadastrarLocatarioRenda.Text),
                avalista = cadastrarLocatarioAvalista.Checked,
                nomeAvalista = cadastrarLocatarioAvalistaNome.Text,
                cpfAvalista = cadastrarLocatarioAvalistaCpf.Text,
                rendaAvalista = string.IsNullOrEmpty(cadastrarLocatarioAvalistaRenda.Text) ? 0 : float.Parse(cadastrarLocatarioAvalistaRenda.Text)
        };
            _locatarioDao.Adicionar(locatario);
            MessageBox.Show("Locatario cadastrado com sucesso!");
            this.Close();
        }

        private void cadastrarLocatarioAvalista_CheckedChanged(object sender, EventArgs e)
        {
            if (cadastrarLocatarioAvalista.Checked)
            {
                cadastrarLocatarioAvalistaNome.Enabled = true;
                cadastrarLocatarioAvalistaCpf.Enabled = true;
                cadastrarLocatarioAvalistaRenda.Enabled = true;
            }
            else
            {
                cadastrarLocatarioAvalistaNome.Enabled = false;
                cadastrarLocatarioAvalistaCpf.Enabled = false;
                cadastrarLocatarioAvalistaRenda.Enabled = false;
            }
        }
    }
}
