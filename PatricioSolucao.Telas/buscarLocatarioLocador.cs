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
    public partial class buscarLocatarioLocador : Form
    {
        private ImovelDao _imovelDao;
        private Imovel _imovelEncontrado;
        public int idSelecionado;
        private LocatarioDao _locatarioDao;
        private Locatario _locatarioEncontrado;
        public char situacaoAux;
        public buscarLocatarioLocador(int idSelecionado)
        {
            InitializeComponent();
            _locatarioDao = new LocatarioDao();
            _imovelDao = new ImovelDao();

            this.idSelecionado = idSelecionado;
        }

        private void btnBuscarLocatario_Click(object sender, EventArgs e)
        {
            var cpf = txtBuscarCpfLocatario.Text;

            _locatarioEncontrado = _locatarioDao.BuscarLocatarioPeloCpf(cpf);

            _imovelEncontrado = _imovelDao.BuscarImovelPorId(idSelecionado);
            string editarImovelBairro = _imovelEncontrado.bairro;
            string editarImovelRua = _imovelEncontrado.rua;
            string editarImovelNum = _imovelEncontrado.numero.ToString();
            string editarImovelRef = _imovelEncontrado.pontoReferencia;
            string editarImovelObs = _imovelEncontrado.observacoes;
            string editarImovelProprietario = _imovelEncontrado.nomeProprietario.ToString();
            bool editarImovelTipo = _imovelEncontrado.tipo;
            string editarImovelValor =  _imovelEncontrado.valor.ToString();

            Imovel imovel = new Imovel()
            {
                id = idSelecionado,
                bairro = editarImovelBairro,
                rua = editarImovelRua,
                numero = int.Parse(editarImovelNum),
                pontoReferencia = editarImovelRef,
                observacoes = editarImovelObs,
                id_proprietario = _imovelEncontrado.id_proprietario,
                valor = float.Parse(editarImovelValor),
                situacao = '1',
                id_locatario = _locatarioEncontrado.id,
                tipo = editarImovelTipo,
            };
            _imovelDao.Editar(imovel);
            MessageBox.Show("Imóvel Locado com sucesso!");
            this.Close();
        }

        private void buscarLocatario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }
    }
}
