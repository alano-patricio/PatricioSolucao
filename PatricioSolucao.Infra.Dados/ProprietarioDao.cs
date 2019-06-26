using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatricioSolucao.Infra.Dados
{
    public class ProprietarioDao
    {
        #region Scripts

        public const string _sqlAdicionar =
            @"INSERT INTO proprietario
                   (nome
                   ,cpf
                   ,rg
                   ,dataNascimento
                   ,dadosBancarios)
               VALUES
                   ({0}nome
                   ,{0}cpf
                   ,{0}rg
                   ,{0}dataNascimento
                   ,{0}dadosBancarios)";

        private const string _sqlBuscaTodos =
         @"SELECT * FROM proprietario";

        private const string _sqlBuscarPorCpf =
            @"SELECT * FROM proprietario where cpf = {0}cpf";

        private const string _sqlBuscarPorId =
            @"SELECT * FROM proprietario where id = {0}id";

        private const string _sqlEditar =
           @"UPDATE proprietario
           SET nome = {0}nome
           ,cpf = {0}cpf
           ,rg = {0}rg
           ,dataNascimento = {0}dataNascimento
           ,dadosBancarios = {0}dadosBancarios
             WHERE id = {0}id";

        #endregion

        public int Adicionar(Proprietario novoProprietario)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametros(novoProprietario));
        }
        public IList<Proprietario> BuscarTodos()
        {
            return Db.GetAll(_sqlBuscaTodos, ConverterProprietario);
        }

        public Proprietario BuscarPorCpf(string cpf)
        {
            var parms = new Dictionary<string, object> { { "cpf", cpf } };

            return Db.Get(_sqlBuscarPorCpf, ConverterProprietario, parms);
        }

        //public List<Proprietario> BuscarPorCpf(string cpf)
        //{
        //    string query = "select * from proprietario WHERE cpf LIKE '%%" + cpf + "%' ";
        //    return Db.buscaCPF(query);
        //}

        public Proprietario BuscarPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "id", id } };

            return Db.Get(_sqlBuscarPorId, ConverterProprietario, parms);
        }

        public void Editar(Proprietario proprietario)
        {
            Db.Update(_sqlEditar, BuscarParametros(proprietario));
        }

        private Proprietario ConverterProprietario(IDataReader reader)
        {
            Proprietario proprietario = new Proprietario();
            proprietario.id = Convert.ToInt32(reader["id"]);
            proprietario.nome = Convert.ToString(reader["nome"]);
            proprietario.cpf = Convert.ToString(reader["cpf"]);
            proprietario.rg = Convert.ToString(reader["rg"]);
            proprietario.dataNascimento = Convert.ToDateTime(reader["dataNascimento"]);
            proprietario.dadosBancarios = Convert.ToString(reader["dadosBancarios"]);
            return proprietario;
        }

        private Dictionary<string, object> BuscarParametros(Proprietario proprietario)
        {
            return new Dictionary<string, object>
            {
                {"id",proprietario.id},
                {"nome",proprietario.nome},
                {"cpf",proprietario.cpf},
                {"rg",proprietario.rg},
                {"dataNascimento",proprietario.dataNascimento},
                {"dadosBancarios",proprietario.dadosBancarios}
            };
        }

    }
}
