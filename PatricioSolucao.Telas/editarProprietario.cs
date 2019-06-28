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
        public editarProprietario()
        {
            InitializeComponent();
        }
        //private void CarregarObjetoTelaCompromisso()
        //{
        //    //Busca o valor da coluna Id.
        //    int idSelecionado = (int)(dgvListaCompromissos.CurrentRow.Cells["Id"].Value);

        //    //Busca o clinte pelo id selcionado no grid.
        //    _compromissoEncontrado = _compromissoDao.BuscarPorId(idSelecionado);

        //    //Se o contato existir então é feita a atribuição
        //    if (_compromissoEncontrado != null)
        //    {
        //        //Muda para a primeira tela.
        //        tabCompromisso.SelectedIndex = 0;
        //        //Preenche os campos com a contato buscado.
        //        txtIdCompromisso.Text = _compromissoEncontrado.Id.ToString();
        //        txtAssunto.Text = _compromissoEncontrado.Assunto;
        //        txtLocal.Text = _compromissoEncontrado.Local;
        //        cbDiaInteiro.Checked = _compromissoEncontrado.DiaCheio;
        //        dtpDataInicial.Text = _compromissoEncontrado.DataIn;
        //        dtpDataFinal.Text = _compromissoEncontrado.DataOut;
        //        dtpHoraInicial.Text = _compromissoEncontrado.HoraIn;
        //        dtpHoraFinal.Text = _compromissoEncontrado.HoraOut;
        //    }
        //    else
        //    {
        //        throw new Exception("Compromisso não encontrado!");
        //    }
        //}
    }
}
