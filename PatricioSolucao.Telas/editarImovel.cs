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

    public partial class editarImovel : Form
    {
        private ImovelDao _imovelDao;
        private Imovel _imovelEncontrado;
        private int idSelecionado;
        public char situacaoAux;

        public editarImovel(int idSelecionado)       
        {
            InitializeComponent();
            _imovelDao = new ImovelDao();
            editarImovelProprietario.Enabled = false;
            this.idSelecionado = idSelecionado;
            _imovelEncontrado = _imovelDao.BuscarImovelPorId(idSelecionado);
            editarImovelBairro.Text = _imovelEncontrado.bairro;
            editarImovelRua.Text = _imovelEncontrado.rua;
            editarImovelNum.Text = _imovelEncontrado.numero.ToString();
            editarImovelRef.Text = _imovelEncontrado.pontoReferencia;
            editarImovelObs.Text = _imovelEncontrado.observacoes;
            editarImovelProprietario.Text = _imovelEncontrado.nomeProprietario.ToString();
            editarImovelTipo.Text = _imovelEncontrado.tipo == true ? "Venda" : "Locação" ;
            editarImovelValor.Text = _imovelEncontrado.valor.ToString();
            if (_imovelEncontrado.situacao.ToString() == "0")
            {
                editarImovelSituacao.Text = "Locar";
            } else if (_imovelEncontrado.situacao.ToString() == "1")
            {
                editarImovelSituacao.Text = "Locado";
            }
            else if (_imovelEncontrado.situacao.ToString() == "2")
            {
                editarImovelSituacao.Text = "Vender";
            }
            else if (_imovelEncontrado.situacao.ToString() == "3")
            {
                editarImovelSituacao.Text = "Vendido";
            }

        }

        private void editarImovel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void editarImovelAlterar_Click(object sender, EventArgs e)
        {
            if (editarImovelSituacao.Text == "Locar")
            {
                situacaoAux = '0';
            }
            else if (editarImovelSituacao.Text == "Locado")
            {
                situacaoAux = '1';
            }
            else if (editarImovelSituacao.Text == "Vender")
            {
                situacaoAux = '2';
            }
            else if (editarImovelSituacao.Text == "Vendido")
            {
                situacaoAux = '3';
            }

            // -------------------------------------------------

            if (string.IsNullOrEmpty(editarImovelBairro.Text))
            {
                MessageBox.Show("Bairro precisa ser preenchido!");
            }
            else
            {
                if (string.IsNullOrEmpty(editarImovelRua.Text))
                {
                    MessageBox.Show("Rua precisa ser preenchida!");
                }
                else
                {
                    if (string.IsNullOrEmpty(editarImovelNum.Text))
                    {
                        MessageBox.Show("Numero precisa ser preenchido!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(editarImovelTipo.Text))
                        {
                            MessageBox.Show("Tipo precisa ser selecionado!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(editarImovelValor.Text))
                            {
                                MessageBox.Show("Valor precisa ser preenchido!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(editarImovelSituacao.Text))
                                {
                                    MessageBox.Show("Situação precisa ser selecionado!");
                                }
                                else
                                {
                                    Imovel imovel = new Imovel()
                                    {
                                        id = idSelecionado,
                                        bairro = editarImovelBairro.Text,
                                        rua = editarImovelRua.Text,
                                        numero = int.Parse(editarImovelNum.Text),
                                        pontoReferencia = editarImovelRef.Text,
                                        observacoes = editarImovelObs.Text,
                                        id_proprietario = _imovelEncontrado.id_proprietario,
                                        valor = float.Parse(editarImovelValor.Text),
                                        situacao = situacaoAux,
                                        id_locatario = 1,
                                        tipo = editarImovelTipo.Text == "Locação" ? false : true
                                    };
                                    _imovelDao.Editar(imovel);
                                    MessageBox.Show("Imóvel alterado com sucesso!");
                                    this.Close();
                                                   
                                }
                            }
                        }
                    }
                }
            }
        }

        private void editarImovelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void editarImovelValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}