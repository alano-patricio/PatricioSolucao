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
    public class FinanceiroDao
    {
        #region Scripts

        public const string _sqlAdicionar =
            @"INSERT INTO financeiro
                   (valor
                   ,operacao
                   ,balanco)
               VALUES
                   ({0}valor
                   ,{0}operacao
                   ,{0}balanco)";

        private const string _sqlBuscaBalanco = 
            @"SELECT * from financeiro where id = (select max(id) FROM financeiro)";
        
        #endregion
        public int Adicionar(Financeiro novoValor)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametrosAdicionar(novoValor));
        }

        public Financeiro BuscarBalanco()
        {
            return Db.Get(_sqlBuscaBalanco, ConverterFinancerioAdicionar);
        }

        private Financeiro ConverterFinancerioAdicionar(IDataReader reader)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.valor = Convert.ToInt32(reader["valor"]);
            financeiro.operacao = Convert.ToBoolean(reader["operacao"]);
            financeiro.balanco = Convert.ToInt32(reader["balanco"]);
        
            return financeiro;
        }

        private Dictionary<string, object> BuscarParametrosAdicionar(Financeiro financeiro)
        {
            return new Dictionary<string, object>
            {
                {"valor",financeiro.valor},
                {"operacao",financeiro.operacao},
                {"balanco",financeiro.balanco},
            };
        }
    }
}
