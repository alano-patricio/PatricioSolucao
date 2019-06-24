using System.Collections;
using System.Collections.Generic;
using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using NUnit.Framework;

namespace PatricioSolucao.Infra.Dados.Testes
{
    [TestFixture]
    public class ImovelDaoTestes
    {
        private ImovelDao _imovelDao;

        [SetUp]
        public void Inicializar()
        {
            Db.Insert("");//truncar banco
            _imovelDao = new ImovelDao();

        }

        [Test]
        public void Teste_Deve_Adicionar_Um_Imovel()
        {
            //CENÁRIO

            Imovel novoImovel = new Imovel();
            novoImovel.bairro = "Centro";
            novoImovel.rua = "Presidente Nereu Ramos";
            novoImovel.numero = 04;
            novoImovel.pontoReferencia = "Proximo ao teatro";
            novoImovel.observacoes = "";
            novoImovel.tipo = true;
            novoImovel.valor = 753;
            novoImovel.situacao = '1';
            novoImovel.id_proprietario = 1;

            int idImovelAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO
            var resultado = _imovelDao.Adicionar(novoImovel);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idImovelAdicionado, resultado);
        }

        private static void PrepararBanco()
        {
            //Limpando do a tabela imovel
            Db.Update("DELETE FROM [imovel]");

            //Zerando o Id
            Db.Update("DBCC CHECKIDENT('[imovel]', RESEED, 0)");

            //Inserir um imovel 
            Db.Update(@"INSERT INTO imovel
                               (bairro
		                       ,rua
                               ,numero
                               ,pontoReferencia
                               ,observacoes
                               ,tipo
                               ,valor
                               ,situacao
                               ,id_proprietario)
                         VALUES
                               ('Centro'
                               ,'Presidente Nereu Ramos'
                               ,13
                               ,'Em frente ao teatro'
                               ,'nada'
                               ,true
                               ,350
                               ,'1'
		                       ,1)");
        }
    }
}
