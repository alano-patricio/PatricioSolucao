using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace PatricioSolucao.Dominio.Testes
{
    [TestFixture]
    public class ImovelTestes
    {
        private Imovel _imovel;

        [SetUp]
        public void Inicializador()
        {
            _imovel = new Imovel
            {
                id = 1,
                bairro = "Centro",
                rua = "Coronel Cordova",
                numero = 331,
                pontoReferencia = "Correio",
                observacoes = "nada",
                tipo = true,
                valor = 355,
                situacao = '1',
                id_proprietario = 1
            };
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Bairro()
        {
            //ARRANGE
            _imovel.bairro = string.Empty;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo bairro não pode ficar em branco!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Rua()
        {
            //ARRANGE
            _imovel.rua = string.Empty;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo rua não pode ficar em branco!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Numero_Maior_Que_Zero()
        {
            //ARRANGE
            _imovel.numero = 0;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo numero não pode ser zero!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Id_Proprietario_Valido()
        {
            //ARRANGE
            _imovel.id_proprietario = 0;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Id inválido!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Tipo()
        {
            //ARRANGE
            _imovel.tipo = true;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Selecione uma opção no campo tipo!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Valor()
        {
            //ARRANGE
            _imovel.valor = 0;

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo valor não pode ficar em branco!");
        }

        [Test]
        public void Teste_Imovel_Deve_Ter_Situacao()
        {
            //ARRANGE
            _imovel.situacao = '4';

            //ACTIONl
            Action resultado = () => _imovel.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo situação incorreto!");
        }
    }

}

