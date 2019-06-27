using System.Collections;
using System.Collections.Generic;
using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using NUnit.Framework;
using System;

namespace PatricioSolucao.Infra.Dados.Testes
{
    [TestFixture]
    public class LocatarioDaoTestes
    {
        private LocatarioDao _locatarioDao;
        [SetUp]
        public void Inicializar()
        {

            _locatarioDao = new LocatarioDao();

            Db.Update("DELETE FROM locatario");
            Db.Update("ALTER TABLE `locatario` AUTO_INCREMENT=1");

            Locatario novoLocatario = new Locatario();
            novoLocatario.nome = "Alano";
            novoLocatario.cpf = "333.333.333.37";
            novoLocatario.rg = "5.555.555";
            novoLocatario.dataNascimento = new DateTime(1995, 12, 28);
            novoLocatario.renda = 2500;
            novoLocatario.avalista = false;
            novoLocatario.nomeAvalista = "";
            novoLocatario.cpfAvalista = "";
            novoLocatario.rendaAvalista = 0;
            _locatarioDao.Adicionar(novoLocatario);
        }

        [Test]
        public void Teste_Deve_Adicionar_Um_Locatario()
        {
            //CENÁRIO
            Locatario novoLocatario = new Locatario();
            novoLocatario.nome = "Alano";
            novoLocatario.cpf = "333.333.333.37";
            novoLocatario.rg = "5.555.555";
            novoLocatario.dataNascimento = new DateTime(1995, 12, 28);
            novoLocatario.renda = 2500;
            novoLocatario.avalista = false;
            novoLocatario.nomeAvalista = "";
            novoLocatario.cpfAvalista = "";
            novoLocatario.rendaAvalista = 0;

            int idLocatarioAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO
            var resultado = _locatarioDao.Adicionar(novoLocatario);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idLocatarioAdicionado, resultado);
        }

        [Test]
        public void Teste_Deve_Buscar_Locatario_Pelo_Cpf()
        {

            string cpfLocatarioBuscado = "333.333.333.37";

            var resultado = _locatarioDao.BuscarLocatarioPeloCpf(cpfLocatarioBuscado);

            Assert.NotNull(resultado);

        }

        [Test]
        public void Teste_Deve_Editar_Qualquer_Campo_do_Locatario()
        {
            //CENÁRIO
            int idLocatarioEditado = 1;
            string nomeEditado = "Alano Editado";
            Locatario locatarioEditado = _locatarioDao.BuscarLocatarioPeloId(idLocatarioEditado);

            //AÇÃO
            locatarioEditado.nome = nomeEditado;
            _locatarioDao.Editar(locatarioEditado);

            Locatario locatarioBuscado = _locatarioDao.BuscarLocatarioPeloId(idLocatarioEditado);
            Assert.AreEqual(nomeEditado, locatarioBuscado.nome);
        }


        [Test]
        public void Teste_Deve_Buscar_Todos_Os_Locatarios()
        {
            int quantidadeLocatarios = 1;

            var resultado = _locatarioDao.BuscarLocatarioPeloCpf();

            Assert.AreEqual(quantidadeLocatarios, resultado.Count);
        }


    }
}
