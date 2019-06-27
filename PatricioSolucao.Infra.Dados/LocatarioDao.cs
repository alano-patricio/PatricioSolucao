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
    public class LocatarioDao
    {
        #region Scripts

        public const string _sqlAdicionar =
            @"INSERT INTO locatario
                   (nome
                   ,cpf
                   ,rg
                   ,data
                   ,renda
                   ,avalista
                   ,nomeAvalista
                   ,cpfAvalista
                   ,rendaAvalista)
               VALUES
                   ({0}nome
                   ,{0}cpf
                   ,{0}rg
                   ,{0}dataNascimento
                   ,{0}renda
                   ,{0}avalista
                   ,{0}nomeAvalista
                   ,{0}cpfAvalista
                   ,{0}rendaAvalista)";

        private const string _sqlBuscaTodos =
        @"SELECT * FROM locatario";

        private const string _sqlBuscarLocatarioPeloCpf =
            @"SELECT * FROM locatario where cpf = {0}cpf";

        private const string _sqlBuscarLocatarioPeloId =
           @"SELECT * FROM locatario where id = {0}id";

        private const string _sqlEditar =
  @"UPDATE locatario
               SET nome = {0}nome
                  ,cpf = {0}cpf
                  ,rg = {0}rg 
                  ,data = {0}dataNascimento 
                  ,renda = {0}renda 
                  ,avalista = {0}avalista 
                  ,nomeAvalista = {0}nomeAvalista 
                  ,cpfAvalista = {0}cpfAvalista 
                  ,rendaAvalista = {0}rendaAvalista 
             WHERE id = {0}id";

        #endregion
        public int Adicionar(Locatario novoLocatario)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametros(novoLocatario));
        }

        public Locatario BuscarLocatarioPeloCpf(string cpf)
        {
            var parms = new Dictionary<string, object> { { "cpf", cpf } };

            return Db.Get(_sqlBuscarLocatarioPeloCpf, ConverterLocatario, parms);
        }

        public Locatario BuscarLocatarioPeloId(int id)
        {
            var parms = new Dictionary<string, object> { { "id", id } };

            return Db.Get(_sqlBuscarLocatarioPeloId, ConverterLocatario, parms);
        }

        public void Editar(Locatario locatario)
        {
            Db.Update(_sqlEditar, BuscarParametros(locatario));
        }

        public IList<Locatario> BuscarLocatarioPeloCpf()
        {
            return Db.GetAll(_sqlBuscaTodos, ConverterLocatario);
        }

        private Locatario ConverterLocatario(IDataReader reader)
        {
            Locatario locatario = new Locatario();
            locatario.id = Convert.ToInt32(reader["id"]);
            locatario.nome = Convert.ToString(reader["nome"]);
            locatario.cpf = Convert.ToString(reader["cpf"]);
            locatario.rg = Convert.ToString(reader["rg"]);
            locatario.dataNascimento = Convert.ToDateTime(reader["data"]);
            locatario.renda = Convert.ToInt32(reader["renda"]);
            locatario.avalista = Convert.ToBoolean(reader["avalista"]);
            locatario.nomeAvalista = Convert.ToString(reader["nomeAvalista"]);
            locatario.cpfAvalista = Convert.ToString(reader["cpfAvalista"]);
            locatario.rendaAvalista = Convert.ToInt32(reader["rendaAvalista"]);
            return locatario;
        }

        private Dictionary<string, object> BuscarParametros(Locatario locatario)
        {
            return new Dictionary<string, object>
            {
                {"id",locatario.id},
                {"nome",locatario.nome},
                {"cpf",locatario.cpf},
                {"rg",locatario.rg},
                {"dataNascimento",locatario.dataNascimento},
                {"renda",locatario.renda},
                {"avalista",locatario.avalista},
                {"nomeAvalista",locatario.nomeAvalista},
                {"cpfAvalista",locatario.cpfAvalista},
                {"rendaAvalista",locatario.rendaAvalista}

            };
        }

    }
}
