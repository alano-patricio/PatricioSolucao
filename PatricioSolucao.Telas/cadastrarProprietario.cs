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
    public partial class cadastrarProprietario : Form
    {
        private ProprietarioDao _proprietarioDao;

        public cadastrarProprietario()
        {
            InitializeComponent();
            _proprietarioDao = new ProprietarioDao();
        }

        private void cadastrarProprietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void cadastrarProprietarioAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cadastrarProprietarioNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!");
            }
            else
            {
                if (string.IsNullOrEmpty(cadastrarProprietarioCpf.Text))
                {
                    MessageBox.Show("CPF deve ser preenchido!");
                }
                else
                {
                    if (string.IsNullOrEmpty(cadastrarProprietarioRg.Text))
                    {
                        MessageBox.Show("RG deve ser preenchido!");
                    }
                    else
                    {
                        if (DateTime.Parse(cadastrarProprietarioData.Text).Year > 2001)
                        {
                            MessageBox.Show("Proprietário deve ser maior de idade!");
                        }
                        else
                        {
                            Proprietario proprietario = new Proprietario()
                            {
                                nome = cadastrarProprietarioNome.Text,
                                cpf = cadastrarProprietarioCpf.Text,
                                rg = cadastrarProprietarioRg.Text,
                                dataNascimento = DateTime.Parse(cadastrarProprietarioData.Text),
                                dadosBancarios = cadastrarProprietarioBanco.Text
                            };
                            _proprietarioDao.Adicionar(proprietario);
                            MessageBox.Show("Proprietario adicionado com sucesso!");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
