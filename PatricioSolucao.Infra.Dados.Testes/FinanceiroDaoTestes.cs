using System.Collections;
using System.Collections.Generic;
using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using NUnit.Framework;
using System;


namespace PatricioSolucao.Infra.Dados.Testes
{
    [TestFixture]
    public class FinanceiroDaoTestes
    {
        private FinanceiroDao _financeiroDao;
        [SetUp]
        public void Inicializar()
        {
            Db.Update("DELETE FROM financeiro");
            Db.Update("ALTER TABLE `financeiro` AUTO_INCREMENT=1");

            _financeiroDao = new FinanceiroDao();

            Financeiro novoRegistroFinanceiro = new Financeiro();
            novoRegistroFinanceiro.valor = 500;
            novoRegistroFinanceiro.operacao = false;
            novoRegistroFinanceiro.balanco = 1000;

            _financeiroDao.Adicionar(novoRegistroFinanceiro);
        }

        //[Test]
        //public void Teste_Deve_Acrescer_Um_Valor()
        //{
        //    //CENÁRIO
        //    Financeiro novoRegistroFinanceiro = new Financeiro();
        //    novoRegistroFinanceiro.valor = 300;
        //    novoRegistroFinanceiro.operacao = true;
        //    novoRegistroFinanceiro.balanco = 1000;
        //    int quantidadeValida = 1300;

        //    //AÇÃO
        //    _financeiroDao.Adicionar(novoRegistroFinanceiro);
        //    var resultado = _financeiroDao.BuscarBalanco();

        //    //VERIFICAÇÃO
        //    Assert.True(resultado.balanco > quantidadeValida);
        //    //Assert.AreEqual(idLocatarioAdicionado, resultado);
        //}
    }
}
