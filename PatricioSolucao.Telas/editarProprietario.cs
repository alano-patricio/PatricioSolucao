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
    public partial class editarProprietario : Form

    {
        private ProprietarioDao _proprietarioDao;
        private Proprietario _proprietarioEncontrado;
        private int idSelecionado;

        public editarProprietario()
        {
            InitializeComponent();
        }

        public editarProprietario(int idSelecionado)
        {
            InitializeComponent();
            _proprietarioDao = new ProprietarioDao();
            this.idSelecionado = idSelecionado;
            _proprietarioEncontrado = _proprietarioDao.BuscarPorId(idSelecionado);
            editarProprietarioNome.Text = _proprietarioEncontrado.nome;
            editarProprietarioCpf.Text = _proprietarioEncontrado.cpf;
            editarProprietarioRg.Text = _proprietarioEncontrado.rg;
            editarProprietarioData.Text = _proprietarioEncontrado.dataNascimento.ToString();
            editarProprietarioBanco.Text = _proprietarioEncontrado.dadosBancarios;
        }

        private void editarProprietarioAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editarProprietarioNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!");
            }
            else
            {
                if (string.IsNullOrEmpty(editarProprietarioCpf.Text))
                {
                    MessageBox.Show("CPF deve ser preenchido!");
                }
                else
                {
                    if (string.IsNullOrEmpty(editarProprietarioRg.Text))
                    {
                        MessageBox.Show("RG deve ser preenchido!");
                    }
                    else
                    {
                        if (DateTime.Parse(editarProprietarioData.Text).Year > 2001)
                        {
                            MessageBox.Show("Proprietário deve ser maior de idade!");
                        }
                        else
                        {
                            Proprietario proprietario = new Proprietario()
                            {
                                id = idSelecionado,
                                nome = editarProprietarioNome.Text,
                                cpf = editarProprietarioCpf.Text,
                                rg = editarProprietarioRg.Text,
                                dataNascimento = DateTime.Parse(editarProprietarioData.Text),
                                dadosBancarios = editarProprietarioBanco.Text
                            };
                            _proprietarioDao.Editar(proprietario);
                            MessageBox.Show("Proprietario editado com sucesso!");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void editarProprietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }
    }
}
