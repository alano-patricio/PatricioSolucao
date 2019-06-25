using System.Collections;
using System.Collections.Generic;
using PatricioSolucao.Dominio;
using PatricioSolucao.Infra.Dados.Comum;
using NUnit.Framework;
using System;

namespace PatricioSolucao.Infra.Dados.Testes
{
    [TestFixture]
    public class ProprietarioDaoTestes
    {
        private ProprietarioDao _proprietarioDao;

        [SetUp]
        public void Inicializar()
        {
            _proprietarioDao = new ProprietarioDao();

            Db.Update("DELETE FROM proprietario");
            Db.Update("ALTER TABLE `proprietario` AUTO_INCREMENT=1");
            
            Proprietario novoProprietario = new Proprietario();
            novoProprietario.nome = "Alano";
            novoProprietario.cpf = "333.333.333.37";
            novoProprietario.rg = "5.555.555";
            novoProprietario.dataNascimento = new DateTime(1995, 12, 28);
            novoProprietario.dadosBancarios = "abc bolinhas";
            _proprietarioDao.Adicionar(novoProprietario);
     
        }

        [Test]
        public void Teste_Deve_Adicionar_Um_Proprietario()
        {

            //CENÁRIO
            
            Proprietario novoProprietario = new Proprietario();
            novoProprietario.nome = "Alano";
            novoProprietario.cpf = "333.333.333.37";
            novoProprietario.rg = "5.555.555";
            novoProprietario.dataNascimento = new DateTime(1995, 12, 28);
            novoProprietario.dadosBancarios = "abcbolinhas";


            int idProprietarioAdicionado = 2;
            int quantidadeValida = 0;

            //AÇÃO
            var resultado = _proprietarioDao.Adicionar(novoProprietario);

            //VERIFICAÇÃO        
            Assert.True(resultado > quantidadeValida);
            Assert.AreEqual(idProprietarioAdicionado, resultado);
        }

        [Test]
        public void Teste_Deve_Buscar_Todos_Os_Proprietarios()
        {
            int quantidadeProprietarios = 1;

            var resultado = _proprietarioDao.BuscarTodos();

            Assert.AreEqual(quantidadeProprietarios, resultado.Count);
        }

        [Test]
        public void Teste_Deve_Buscar_Por_Cpf()
        {
            string cpfProprietarioBuscado = "333.333.333.37";
            Proprietario resultado = _proprietarioDao.BuscarPorCpf(cpfProprietarioBuscado);
            Assert.NotNull(resultado);
        }

        [Test]
        public void Teste_Deve_Editar_Qualquer_Campo_do_Proprietario()
        {
            //CENÁRIO
            int idProprietarioEditado = 1; //ID DO CLIENTE QUE ESTA SENDO ALTERADO
            string nomeEditado = "Alano EDITADO"; //ALTERAÇÃO DO NOME
            Proprietario proprietarioEditado = _proprietarioDao.BuscarPorId(idProprietarioEditado); //BUSCA DO CLIENTE A SER ALTERADO

            //AÇÃO
            proprietarioEditado.nome = nomeEditado;
            _proprietarioDao.Editar(proprietarioEditado);

            Proprietario proprietarioBuscado = _proprietarioDao.BuscarPorId(idProprietarioEditado);
            Assert.AreEqual(nomeEditado, proprietarioEditado.nome);
        }
    }
}
