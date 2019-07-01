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
            editarLocatarioAvalistaNome.Enabled = false;
            editarLocatarioAvalistaCpf.Enabled = false;
            editarLocatarioAvalistaRenda.Enabled = false;
        }

        private void editarLocatarioAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editarLocatarioNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!");
            }
            else
            {
                if (string.IsNullOrEmpty(editarLocatarioCpf.Text))
                {
                    MessageBox.Show("CPF deve ser preenchido!");
                }
                else
                {
                    if (string.IsNullOrEmpty(editarLocatarioRg.Text))
                    {
                        MessageBox.Show("RG deve ser preenchido!");
                    }
                    else
                    {
                        if (DateTime.Parse(editarLocatarioData.Text).Year > 2001)
                        {
                            MessageBox.Show("Locatario deve ser maior de idade!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(editarLocatarioRenda.Text))
                            {
                                MessageBox.Show("Renda deve ser preenchido!");
                            }
                            else
                            {
                                if (editarLocatarioAvalista.Checked)
                                {
                                    if (string.IsNullOrEmpty(editarLocatarioAvalistaNome.Text))
                                    {
                                        MessageBox.Show("Nome do avalista deve ser preenchido!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(editarLocatarioAvalistaCpf.Text))
                                        {
                                            MessageBox.Show("CPF do avalista deve ser preenchido!");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(editarLocatarioAvalistaRenda.Text))
                                            {
                                                MessageBox.Show("Renda do avalista deve ser preenchido!");
                                            }
                                            else
                                            {
                                                Locatario locatario = new Locatario()
                                                {
                                                    id = idSelecionado,
                                                    nome = editarLocatarioNome.Text,
                                                    cpf = editarLocatarioCpf.Text,
                                                    rg = editarLocatarioRg.Text,
                                                    dataNascimento = DateTime.Parse(editarLocatarioData.Text),
                                                    renda = float.Parse(editarLocatarioRenda.Text),
                                                    avalista = editarLocatarioAvalista.Checked,
                                                    nomeAvalista = editarLocatarioAvalistaNome.Text,
                                                    cpfAvalista = editarLocatarioAvalistaCpf.Text,
                                                    rendaAvalista = string.IsNullOrEmpty(editarLocatarioAvalistaRenda.Text) ? 0 : float.Parse(editarLocatarioAvalistaRenda.Text)
                                                };
                                                _locatarioDao.Editar(locatario);
                                                MessageBox.Show("Locatario editado com sucesso!");
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Locatario locatario = new Locatario()
                                    {
                                        id = idSelecionado,
                                        nome = editarLocatarioNome.Text,
                                        cpf = editarLocatarioCpf.Text,
                                        rg = editarLocatarioRg.Text,
                                        dataNascimento = DateTime.Parse(editarLocatarioData.Text),
                                        renda = float.Parse(editarLocatarioRenda.Text),
                                        avalista = editarLocatarioAvalista.Checked,
                                        nomeAvalista = editarLocatarioAvalistaNome.Text,
                                        cpfAvalista = editarLocatarioAvalistaCpf.Text,
                                        rendaAvalista = string.IsNullOrEmpty(editarLocatarioAvalistaRenda.Text) ? 0 : float.Parse(editarLocatarioAvalistaRenda.Text)
                                    };
                                    _locatarioDao.Editar(locatario);
                                    MessageBox.Show("Locatario editado com sucesso!");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
       
        private void editarLocatario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void editarLocatarioRenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void editarLocatarioAvalistaRenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void editarLocatarioAvalista_CheckedChanged(object sender, EventArgs e)
        {
            if (editarLocatarioAvalista.Checked)
            {
                editarLocatarioAvalistaNome.Enabled = true;
                editarLocatarioAvalistaCpf.Enabled = true;
                editarLocatarioAvalistaRenda.Enabled = true;
            }
            else
            {
                editarLocatarioAvalistaNome.Enabled = false;
                editarLocatarioAvalistaCpf.Enabled = false;
                editarLocatarioAvalistaRenda.Enabled = false;
                editarLocatarioAvalistaNome.Clear();
                editarLocatarioAvalistaCpf.Clear();
                editarLocatarioAvalistaRenda.Clear();
            }
        }
    }
}
