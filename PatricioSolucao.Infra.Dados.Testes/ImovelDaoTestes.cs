using System.Collections;
using System.Collections.Generic;
using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using NUnit.Framework;
using System;

namespace PatricioSolucao.Infra.Dados.Testes
{
    [TestFixture]
    public class ImovelDaoTestes
    {
        private ImovelDao _imovelDao;
        private ProprietarioDao _proprietarioDao;
        private LocatarioDao _locatarioDao;

        [SetUp]
        public void Inicializar()
        {
            Db.Update("DELETE FROM proprietario");
            Db.Update("ALTER TABLE `proprietario` AUTO_INCREMENT=1");
            Db.Update("DELETE FROM locatario");
            Db.Update("ALTER TABLE `locatario` AUTO_INCREMENT=1");
            Db.Update("DELETE FROM imovel");
            Db.Update("ALTER TABLE `imovel` AUTO_INCREMENT=1");

            _proprietarioDao = new ProprietarioDao();
            _locatarioDao = new LocatarioDao();
            _imovelDao = new ImovelDao();

            _proprietarioDao.Adicionar(ObjetoBase.criaProprietario());
            _locatarioDao.Adicionar(ObjetoBase.criaLocatario());
            
            Imovel novoImovel = new Imovel();
            for(int i = 0; i < 4; i++)
            {
                string aux = Convert.ToString(i);
                novoImovel.bairro = "Centro";
                novoImovel.rua = "Presidente Nereu Ramos";
                novoImovel.numero = 04;
                novoImovel.pontoReferencia = "Proximo ao teatro";
                novoImovel.observacoes = "";
                novoImovel.tipo = true;
                novoImovel.valor = 753;
                novoImovel.situacao = Convert.ToChar(aux);
                novoImovel.id_proprietario = 1;
                novoImovel.id_locatario = 1;

                _imovelDao.Adicionar(novoImovel);
            }
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
            novoImovel.id_locatario = 1;

            int idImovelAdicionado = 5;
            int quantidadeValida = 0;

            //AÇÃO
            var resultado = _imovelDao.Adicionar(novoImovel);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idImovelAdicionado, resultado);
        }

        [Test]
        public void Teste_Deve_Buscar_Imovel_Pelo_Id_Do_Proprietário()
        {

            int idProprietarioBuscado = 1;

            var resultado = _imovelDao.BuscarImovelPorProprietario(idProprietarioBuscado);

            Assert.NotNull(resultado);

        }

        [Test]
        public void Teste_Deve_Editar_Qualquer_Campo_do_Imovel()
        {
            //CENÁRIO
            int idImovelEditado = 1; 
            int idLocatarioEditado = 1;
            Imovel imovelEditado = _imovelDao.BuscarImovelPorId(idImovelEditado);

            //AÇÃO
            imovelEditado.id_locatario = idLocatarioEditado;
            _imovelDao.Editar(imovelEditado);

            Imovel imovelBuscado = _imovelDao.BuscarImovelPorId(idImovelEditado);
            Assert.AreEqual(idLocatarioEditado, imovelBuscado.id_locatario);
        }

        [Test]
        public void Teste_Deve_Listar_Imovel_Para_Locar()
        {
            //CENÁRIO
            string situacaoImovel = "0";
            Imovel resultado = _imovelDao.BuscarImovelPorSituacao(situacaoImovel);
            Assert.NotNull(resultado);
        }

        [Test]
        public void Teste_Deve_Listar_Imovel_Locado()
        {
            //CENÁRIO
            string situacaoImovel = "1";
            Imovel resultado = _imovelDao.BuscarImovelPorSituacao(situacaoImovel);
            Assert.NotNull(resultado);
        }

        [Test]
        public void Teste_Deve_Listar_Imovel_Para_Vender()
        {
            //CENÁRIO
            string situacaoImovel = "2";
            Imovel resultado = _imovelDao.BuscarImovelPorSituacao(situacaoImovel);
            Assert.NotNull(resultado);
        }

        [Test]
        public void Teste_Deve_Listar_Imovel_Vendido()
        {
            //CENÁRIO
            string situacaoImovel = "3";
            Imovel resultado = _imovelDao.BuscarImovelPorSituacao(situacaoImovel);
            Assert.NotNull(resultado);
        }



    }
}
