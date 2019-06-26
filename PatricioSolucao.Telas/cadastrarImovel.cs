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
            Imovel imovel = new Imovel()
            {

                bairro = cadastrarImovelBairro.Text,
                rua = cadastrarImovelRua.Text,
                numero = Convert.ToInt16(cadastrarImovelNum.Text),
                pontoReferencia = cadastrarImovelReferencia.Text,
                observacoes = cadastrarImovelObs.Text,
                id_proprietario = idProprietario,
                tipo = true,
                //tipo = Convert.ToBoolean(cadastrarImovelTipo.Text),
                valor = (float)Convert.ToDouble(cadastrarImovelValor.Text),
                //situacao = Convert.ToChar(cadastrarImovelSituacao.Text)
                situacao = '0'
            };
            _imovelDao.Adicionar(imovel);
            MessageBox.Show("Ou deu bom ou deu ruim!");
        }
    }
}
