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
    public partial class cadastrarImovel : Form
    {

        private ImovelDao _imovelDao;
        public int idProprietario;
        public char situacaoAux;

        public cadastrarImovel(string recebeNomeProprietario, int recebeIdProprietario)
        {
            InitializeComponent();
            cadastrarImovelNomeProprietario.Text = recebeNomeProprietario;
            cadastrarImovelNomeProprietario.Enabled = false;
            idProprietario = recebeIdProprietario;
            _imovelDao = new ImovelDao();
        }

        private void cadastrarImovel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (cadastrarImovelSituacao.Text == "Locar")
            {
                situacaoAux = '0';
            }
            else if (cadastrarImovelSituacao.Text == "Locado")
            {
                situacaoAux = '1';
            }
            else if (cadastrarImovelSituacao.Text == "Vender")
            {
                situacaoAux = '2';
            }
            else if (cadastrarImovelSituacao.Text == "Vendido")
            {
                situacaoAux = '3';
            }



            Imovel imovel = new Imovel()
            {

                bairro = cadastrarImovelBairro.Text,
                rua = cadastrarImovelRua.Text,
                numero = int.Parse(cadastrarImovelNum.Text),
                pontoReferencia = cadastrarImovelReferencia.Text,
                observacoes = cadastrarImovelObs.Text,
                id_proprietario = idProprietario,
                valor = float.Parse(cadastrarImovelValor.Text),
                situacao = situacaoAux,
                id_locatario = 1,
                tipo = cadastrarImovelTipo.Text == "Locação" ? false : true   
        };
            _imovelDao.Adicionar(imovel);
            MessageBox.Show("Imóvel adicionado com sucesso!");
            this.Close();
        }
    }
}
