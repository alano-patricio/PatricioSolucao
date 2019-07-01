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
            if (string.IsNullOrEmpty(cadastrarLocatarioNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!");
            }
            else
            {
                if (string.IsNullOrEmpty(cadastrarLocatarioCpf.Text))
                {
                    MessageBox.Show("CPF deve ser preenchido!");
                }
                else
                {
                    if (string.IsNullOrEmpty(cadastrarLocatarioRg.Text))
                    {
                        MessageBox.Show("RG deve ser preenchido!");
                    }
                    else
                    {
                        if (DateTime.Parse(cadastrarLocatarioData.Text).Year > 2001)
                        {
                            MessageBox.Show("Locatario deve ser maior de idade!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cadastrarLocatarioRenda.Text))
                            {
                                MessageBox.Show("Renda deve ser preenchido!");
                            }
                            else
                            {
                                if (cadastrarLocatarioAvalista.Checked)
                                {
                                    if (string.IsNullOrEmpty(cadastrarLocatarioAvalistaNome.Text))
                                    {
                                        MessageBox.Show("Nome do avalista deve ser preenchido!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(cadastrarLocatarioAvalistaCpf.Text))
                                        {
                                            MessageBox.Show("CPF do avalista deve ser preenchido!");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(cadastrarLocatarioAvalistaRenda.Text))
                                            {
                                                MessageBox.Show("Rendo do avalista deve ser preenchido!");
                                            }
                                            else
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
                                                    rendaAvalista = float.Parse(cadastrarLocatarioAvalistaRenda.Text)
                                                };
                                                _locatarioDao.Adicionar(locatario);
                                                MessageBox.Show("Locatario cadastrado com sucesso!");
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                                else
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
                            }
                        }
                    }
                }
            }
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
                cadastrarLocatarioAvalistaNome.Clear();
                cadastrarLocatarioAvalistaCpf.Clear();
                cadastrarLocatarioAvalistaRenda.Clear();
            }
        }

        private void cadastrarLocatarioRenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void cadastrarLocatarioAvalistaRenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
