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
                   ([bairro]
                   ,[rua]
                   ,[numero]
                   ,[pontoReferencia]
                   ,[observacoes]
                   ,[tipo]
                   ,[valor]
                   ,[situacao]
                   ,[id_proprietario])
               VALUES
                   ({0}bairro
                   ,{0}rua
                   ,{0}numero
                   ,{0}pontoReferencia
                   ,{0}observacoes
                   ,{0}tipo
                   ,{0}valor
                   ,{0}situacao
                   ,{0}id_proprietario)";

        private const string _sqlBuscaTodos =
            @"SELECT [Id]
                  ,[Nome]
                  ,[Status]
                  ,[Logradouro]
                  ,[Bairro]
                  ,[Localidade]
                  ,[Complemento]
                  ,[Numero]
                  ,[Cep]
                  ,[UF]
                  ,[Email]
                  ,[Telefone]
              FROM [dbo].[TBCliente]";

        private const string _sqlBuscaPorId =
            @"SELECT [Id]
                  ,[Nome]
                  ,[Status]
                  ,[Logradouro]
                  ,[Bairro]
                  ,[Localidade]
                  ,[Complemento]
                  ,[Numero]
                  ,[Cep]
                  ,[UF]
                  ,[Email]
                  ,[Telefone]
              FROM [dbo].[TBCliente]
              WHERE [Id] = {0}Id";

        private const string _sqlBuscaPorNome =
            @"SELECT [Id]
                  ,[Nome]
                  ,[Status]
                  ,[Logradouro]
                  ,[Bairro]
                  ,[Localidade]
                  ,[Complemento]
                  ,[Numero]
                  ,[Cep]
                  ,[UF]
                  ,[Email]
                  ,[Telefone]
              FROM [dbo].[TBCliente]
              WHERE [Nome] = {0}NomeBuscado";

        private const string _sqlEditar =
            @"UPDATE [dbo].[TBCliente]
               SET [Nome] = {0}Nome
                  ,[Status] = {0}Status
                  ,[Logradouro] = {0}Logradouro
                  ,[Bairro] = {0}Bairro
                  ,[Localidade] = {0}Localidade
                  ,[Complemento] = {0}Complemento
                  ,[Numero] = {0}Numero
                  ,[Cep] = {0}Cep
                  ,[UF] = {0}UF
                  ,[Email] = {0}Email
                  ,[Telefone] = {0}Telefone
             WHERE [Id] = {0}Id";

        private const string _sqlDeletar =
            @"DELETE FROM [dbo].[TBCliente] WHERE [Id] = {0}Id";

        #endregion

        public int Adicionar(Imovel novoImovel)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametros(novoImovel));
        }

        public IList<Imovel> BuscarTodos()
        {
            return Db.GetAll(_sqlBuscaTodos, ConverterImovel);
        }

        //public Contato BuscarPorId(int id)
        //{
        //    var parms = new Dictionary<string, object> { { "Id", id } };

        //    return Db.Get(_sqlBuscaPorId, ConverterContato, parms);
        //}

        //public void Editar(Contato contato)
        //{
        //    Db.Update(_sqlEditar, BuscarParametros(contato));
        //}

        //public void Deletar(int id)
        //{
        //    var parms = new Dictionary<string, object> { { "Id", id } };

        //    Db.Delete(_sqlDeletar, parms);
        //}

        //#region Metódos Privados - Conversor e Manipulador de Parametros

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
                {"id_proprietario",imovel.id_proprietario}

            };
        }

    }
}
