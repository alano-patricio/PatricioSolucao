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
    public partial class listarEditarProprietario : Form
    {
        private ProprietarioDao _proprietarioDao;
        private List<Proprietario> _listaProprietario;
        public listarEditarProprietario()
        {
            InitializeComponent();
            _listaProprietario = new List<Proprietario>();
            _proprietarioDao = new ProprietarioDao();
        }

        private void listarEditarProprietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buscarProprietarioBuscar_Click(object sender, EventArgs e)
        {
            var cpfBuscado = buscarProprietarioCpf.Text;
            try
            {  _listaProprietario.Clear();

                _listaProprietario = _proprietarioDao.BuscarLocatarioPeloCpfComLike(cpfBuscado);

                dgvListarProprietario.DataSource = _listaProprietario;

                buscarProprietarioCpf.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListarProprietario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idSelecionado = (int)(dgvListarProprietario.CurrentRow.Cells["Id"].Value);

            editarProprietario editarProprietario_ = new editarProprietario();

            this.Hide();

            editarProprietario_.Show();

        }
    }
}
