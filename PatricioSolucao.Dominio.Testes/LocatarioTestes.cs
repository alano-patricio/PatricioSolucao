using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace PatricioSolucao.Dominio.Testes
{
    [TestFixture]
    public class LocatarioTestes
    {
        private Locatario _locatario;

        [SetUp]
        public void Inicializador()
        {
            _locatario = new Locatario
            {
                id = 1,
                nome = "Alano",
                cpf = "011.844.619-37",
                rg = "5.201.146",
                dataNascimento = new DateTime(1995, 12, 28, 00, 00, 00),
                renda = 3000,
                avalista = false,
                nomeAvalista = "",
                cpfAvalista = "555.555.555-55",
                rendaAvalista = 3000
            };
        }

        [Test]
        public void Teste_Locatario_Deve_Possuir_Nome()
        {
            //ARRANGE
            _locatario.nome = string.Empty;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Nome é obrigatório!");
        }

        [Test]
        public void Teste_Locatario_Deve_Possuir_CPF()
        {
            //ARRANGE
            _locatario.cpf = string.Empty;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("CPF é obrigatório!");
        }

        [Test]
        public void Teste_Locatario_Deve_Possuir_RG()
        {
            //ARRANGE
            _locatario.rg = string.Empty;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("RG é obrigatório!");
        }

        [Test]
        public void Teste_Locatario_Deve_Ter_Possuir_Uma_Data_De_Nascimento_Valida()
        {
            //ARRANGE
            _locatario.dataNascimento = new DateTime(0001);

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Deve possuir uma data valida!");
        }

        [Test]
        public void Teste_Locatario_Deve_Ter_Possuir_Uma_Data_De_Nascimento_Que_Comprove_Maior_Idade()
        {
            //ARRANGE
            _locatario.dataNascimento = new DateTime(2001);

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Deve possuir maior idade");
        }

        [Test]
        public void Teste_Locatario_Deve_Ter_Possuir_Uma_Renda()
        {
            //ARRANGE
            _locatario.renda = 0;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Deve possuir uma renda!");
        }

        [Test]
        public void Teste_Locatario_Se_Avalista_For_True_Deve_Possuir_Nome()
        {
            //ARRANGE
            _locatario.avalista = true;
            _locatario.nomeAvalista = string.Empty;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Avalista deve possuir um nome!");
        }

        [Test]
        public void Teste_Locatario_Se_Avalista_For_True_Deve_Possuir_Cpf()
        {
            //ARRANGE
            _locatario.avalista = true;
            _locatario.nomeAvalista = "Harry";
            _locatario.cpfAvalista = string.Empty;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Avalista deve possuir um cpf!");
        }

        [Test]
        public void Teste_Locatario_Se_Avalista_For_True_Deve_Possuir_Renda()
        {
            //ARRANGE
            _locatario.avalista = true;
            _locatario.nomeAvalista = "Harry";
            _locatario.cpfAvalista = "555.555.555-55";
            _locatario.rendaAvalista = 0;

            //ACTIONl
            Action resultado = () => _locatario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Avalista deve possuir renda!");
        }
    }
}
