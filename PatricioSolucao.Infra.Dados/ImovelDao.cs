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
    public class ImovelDao
    {
        #region Scripts

        public const string _sqlAdicionar =
            @"INSERT INTO imovel
                   (bairro
                   ,rua
                   ,numero
                   ,pontoReferencia
                   ,observacoes
                   ,tipo
                   ,valor
                   ,situacao
                   ,id_proprietario
                   ,id_locatario)
               VALUES
                   ({0}bairro
                   ,{0}rua
                   ,{0}numero
                   ,{0}pontoReferencia
                   ,{0}observacoes
                   ,{0}tipo
                   ,{0}valor
                   ,{0}situacao
                   ,{0}id_proprietario
                   ,{0}id_locatario)";

        private const string _sqlBuscaTodos =
          @"SELECT id
                  ,bairro
                  ,rua
                  ,numero
                  ,pontoReferencia
                  ,observacoes
                  ,tipo
                  ,valor
                  ,situacao
                  ,id_proprietario
                  ,id_locatario
              FROM imovel";

        private const string _sqlImovelProprietario =
            @"SELECT * FROM imovel where id_proprietario = {0}id_proprietario";

        private const string _sqlEditar =
  @"UPDATE imovel
               SET bairro = {0}bairro
                  ,rua = {0}rua
                  ,numero = {0}numero 
                  ,pontoReferencia = {0}pontoReferencia 
                  ,observacoes = {0}observacoes 
                  ,tipo = {0}tipo 
                  ,valor = {0}valor 
                  ,situacao = {0}situacao 
                  ,id_proprietario = {0}id_proprietario
                  ,id_locatario = {0}id_locatario
             WHERE id = {0}id";

        private const string _sqlDeletar =
            @"DELETE FROM imovel WHERE id = {0}id";

        #endregion

        public int Adicionar(Imovel novoImovel)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametrosAdicionar(novoImovel));
        }

        public IList<Imovel> BuscarTodos()
        {
            return Db.GetAll(_sqlBuscaTodos, ConverterImovel);
        }

        public Imovel BuscarImovelPorProprietario(int id_proprietario)
        {
            var parms = new Dictionary<string, object> { { "id_proprietario", id_proprietario } };

            return Db.Get(_sqlImovelProprietario, ConverterImovel, parms);
        }

        public List<Imovel> BuscarImovelPorCpfProprietario(string id_proprietario)
        {
            var parms = new Dictionary<string, object> { { "id_proprietario", id_proprietario } };

            return Db.GetAll(@"SELECT *, proprietario.cpf FROM imovel LEFT JOIN proprietario ON proprietario.id = imovel.id_proprietario WHERE proprietario.cpf LIKE '%%" + id_proprietario + "%'", ConverterImovel);
        }

        public Imovel BuscarImovelPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "id", id } };

            return Db.Get(@"SELECT imovel.id, imovel.id_proprietario, imovel.id_locatario, imovel.bairro, imovel.rua, imovel.numero, imovel.pontoReferencia, imovel.observacoes, imovel.tipo, imovel.valor, imovel.situacao, proprietario.nome FROM imovel LEFT JOIN proprietario ON proprietario.id = imovel.id_proprietario WHERE imovel.id =" + id, ConverterImovelComNomeProprietario);
        }

        public List<Imovel> BuscarImovelPorSituacao(string situacao)
        {
            var parms = new Dictionary<string, object> { { "situacao", situacao } };

            return Db.GetAll(@"SELECT imovel.id, imovel.id_locatario, imovel.id_proprietario, imovel.bairro, imovel.rua, imovel.numero, imovel.pontoReferencia, imovel.observacoes, imovel.tipo, imovel.valor, imovel.situacao, proprietario.nome AS nomeProprietario, locatario.nome AS nomeLocatario FROM imovel LEFT JOIN proprietario ON proprietario.id = imovel.id_proprietario LEFT JOIN locatario ON locatario.id = imovel.id_locatario WHERE imovel.situacao ='" + situacao + "'", ConverterImovelSituacao);
        }

        public Imovel BuscarImovelPorSituacaoEspecifica(string situacao)
        {
            var parms = new Dictionary<string, object> { { "situacao", situacao } };

            return Db.Get(@"SELECT imovel.id, imovel.id_locatario, imovel.id_proprietario, imovel.bairro, imovel.rua, imovel.numero, imovel.pontoReferencia, imovel.observacoes, imovel.tipo, imovel.valor, imovel.situacao, proprietario.nome AS nomeProprietario, locatario.nome AS nomeLocatario FROM imovel LEFT JOIN proprietario ON proprietario.id = imovel.id_proprietario LEFT JOIN locatario ON locatario.id = imovel.id_locatario WHERE imovel.situacao ='" + situacao + "'", ConverterImovelSituacao);
        }
            public void Editar(Imovel imovel)
        {
            Db.Update(_sqlEditar, BuscarParametrosAdicionar(imovel));
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            Db.Delete(_sqlDeletar, parms);
        }

        //#region Metódos Privados - Conversor e Manipulador de Parametros

        private Imovel ConverterImovelAdicionar(IDataReader reader)
        {
            Imovel imovel = new Imovel();
            imovel.id = Convert.ToInt32(reader["id"]);
            imovel.bairro = Convert.ToString(reader["bairro"]);
            imovel.rua = Convert.ToString(reader["rua"]);
            imovel.numero = Convert.ToInt32(reader["numero"]);
            imovel.pontoReferencia = Convert.ToString(reader["pontoReferencia"]);
            imovel.observacoes = Convert.ToString(reader["observacoes"]);
            imovel.tipo = Convert.ToBoolean(reader["tipo"]);
            imovel.valor = Convert.ToInt32(reader["valor"]);
            imovel.situacao = Convert.ToChar(reader["situacao"]);
            imovel.id_proprietario = Convert.ToInt32(reader["id_proprietario"]);
            imovel.id_locatario = Convert.ToInt32(reader["id_locatario"]);
            return imovel;
        }

        private Imovel ConverterImovelComNomeProprietario(IDataReader reader)
        {
            Imovel imovel = new Imovel();
            imovel.id = Convert.ToInt32(reader["id"]);
            imovel.bairro = Convert.ToString(reader["bairro"]);
            imovel.rua = Convert.ToString(reader["rua"]);
            imovel.numero = Convert.ToInt32(reader["numero"]);
            imovel.pontoReferencia = Convert.ToString(reader["pontoReferencia"]);
            imovel.observacoes = Convert.ToString(reader["observacoes"]);
            imovel.tipo = Convert.ToBoolean(reader["tipo"]);
            imovel.valor = Convert.ToInt32(reader["valor"]);
            imovel.situacao = Convert.ToChar(reader["situacao"]);
            imovel.id_proprietario = Convert.ToInt32(reader["id_proprietario"]);
            imovel.id_locatario = Convert.ToInt32(reader["id_locatario"]);
            imovel.nomeProprietario = Convert.ToString(reader["nome"]);
            return imovel;
        }

        private Imovel ConverterImovel(IDataReader reader)
        {
            Imovel imovel = new Imovel();
            imovel.id = Convert.ToInt32(reader["id"]);
            imovel.bairro = Convert.ToString(reader["bairro"]);
            imovel.rua = Convert.ToString(reader["rua"]);
            imovel.numero = Convert.ToInt32(reader["numero"]);
            imovel.pontoReferencia = Convert.ToString(reader["pontoReferencia"]);
            imovel.observacoes = Convert.ToString(reader["observacoes"]);
            imovel.tipo = Convert.ToBoolean(reader["tipo"]);
            imovel.valor = Convert.ToInt32(reader["valor"]);
            imovel.situacao = Convert.ToChar(reader["situacao"]);
            imovel.id_proprietario = Convert.ToInt32(reader["id_proprietario"]);
            return imovel;
        }
        private Imovel ConverterImovelSituacao(IDataReader reader)
        {
            Imovel imovel = new Imovel();
            imovel.id = Convert.ToInt32(reader["id"]);
            imovel.id_locatario = Convert.ToInt32(reader["id_locatario"]);
            imovel.id_proprietario = Convert.ToInt32(reader["id_proprietario"]);
            imovel.bairro = Convert.ToString(reader["bairro"]);
            imovel.rua = Convert.ToString(reader["rua"]);
            imovel.numero = Convert.ToInt32(reader["numero"]);
            imovel.pontoReferencia = Convert.ToString(reader["pontoReferencia"]);
            imovel.observacoes = Convert.ToString(reader["observacoes"]);
            imovel.tipo = Convert.ToBoolean(reader["tipo"]);
            imovel.valor = Convert.ToInt32(reader["valor"]);
            imovel.situacao = Convert.ToChar(reader["situacao"]);
            imovel.nomeProprietario = Convert.ToString(reader["nomeProprietario"]);
            imovel.nomeLocatario = Convert.ToString(reader["nomeLocatario"]);

            return imovel;
        }

        private Dictionary<string, object> BuscarParametrosAdicionar(Imovel imovel)
        {
            return new Dictionary<string, object>
            {
                {"id",imovel.id},
                {"bairro",imovel.bairro},
                {"rua",imovel.rua},
                {"numero",imovel.numero},
                {"pontoReferencia",imovel.pontoReferencia},
                {"observacoes",imovel.observacoes},
                {"tipo",imovel.tipo},
                {"valor",imovel.valor},
                {"situacao",imovel.situacao},
                {"id_proprietario",imovel.id_proprietario},
                {"id_locatario",imovel.id_locatario},

            };
        }

        private Dictionary<string, object> BuscarParametros(Imovel imovel)
        {
            return new Dictionary<string, object>
            {
                {"id",imovel.id},
                {"bairro",imovel.bairro},
                {"rua",imovel.rua},
                {"numero",imovel.numero},
                {"pontoReferencia",imovel.pontoReferencia},
                {"observacoes",imovel.observacoes},
                {"tipo",imovel.tipo},
                {"valor",imovel.valor},
                {"situacao",imovel.situacao},
                {"id_proprietario",imovel.id_proprietario},

            };
        }
    }
}
