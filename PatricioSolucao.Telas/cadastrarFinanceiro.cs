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
    public partial class cadastrarFinanceiro : Form
        
    {
        private FinanceiroDao _financeiroDao;
        public float balancoAux;
        public cadastrarFinanceiro()
        {
            InitializeComponent();
            _financeiroDao = new FinanceiroDao();
            var recebeValores =_financeiroDao.BuscarBalanco();
            cadastrarFinanceiroBalanco.Text = recebeValores.balanco.ToString();
            cadastrarFinanceiroBalanco.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Financeiro_Load(object sender, EventArgs e)
        {

        }

        private void Financeiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cadastrarFinanceiroValor.Text))
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                if (string.IsNullOrEmpty(cadastrarFinanceiroOperacao.Text))
                {
                    MessageBox.Show("Selecione uma operção!");
                }
                else
                {
                    if (cadastrarFinanceiroOperacao.Text == "Credito")
                    {
                        balancoAux = float.Parse(cadastrarFinanceiroBalanco.Text) + float.Parse(cadastrarFinanceiroValor.Text);
                    }
                    else
                    {
                        balancoAux = float.Parse(cadastrarFinanceiroBalanco.Text) - float.Parse(cadastrarFinanceiroValor.Text);
                    }
                    Financeiro financeiro = new Financeiro()
                    {
                        valor = int.Parse(cadastrarFinanceiroValor.Text),
                        balanco = balancoAux,
                        operacao = cadastrarFinanceiroOperacao.Text == "Crédito" ? false : true
                    };
                    _financeiroDao.Adicionar(financeiro);
                    MessageBox.Show("Registro bancário lançado com sucesso!");
                    this.Close();
                }
            }
        }

        private void cadastrarFinanceiroValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
