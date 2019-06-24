using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace PatricioSolucao.Dominio.Testes
{
    public class ProprietarioTestes
    {
        private Proprietario _proprietario;

        [SetUp]
        public void Inicializador()
        {
            _proprietario = new Proprietario
            {
                id = 1,
                nome = "Alano",
                cpf = "011.844.619-37",
                rg = "5.201.146",
                dataNascimento = new DateTime(1995, 12, 28, 00, 00, 00),
                dadosBancarios = "0300 13 1213154 BB"
            };
        }

        [Test]
        public void Teste_Proprietario_Deve_Possuir_Nome()
        {
            //ARRANGE
            _proprietario.nome = string.Empty;

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Nome é obrigatório!");
        }

        [Test]
        public void Teste_Proprietario_Deve_Possuir_CPF()
        {
            //ARRANGE
            _proprietario.cpf = string.Empty;

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("CPF é obrigatório!");
        }

        [Test]
        public void Teste_Proprietario_Deve_Possuir_RG()
        {
            //ARRANGE
            _proprietario.rg = string.Empty;

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("RG é obrigatório!");
        }

        [Test]
        public void Teste_Proprietario_Deve_Ter_Possuir_Uma_Data_De_Nascimento_Valida()
        {
            //ARRANGE
            _proprietario.dataNascimento = new DateTime(0001);

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Deve possuir uma data valida!");
        }

        [Test]
        public void Teste_Proprietario_Deve_Ter_Possuir_Uma_Data_De_Nascimento_Que_Comprove_Maior_Idade()
        {
            //ARRANGE
            _proprietario.dataNascimento = new DateTime(2001);

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Deve possuir maior idade");
        }

        [Test]
        public void Teste_Proprietario_Deve_Possuir_Dados_Bancarios()
        {
            //ARRANGE
            _proprietario.dadosBancarios = string.Empty;

            //ACTIONl
            Action resultado = () => _proprietario.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Forma de recebimento é obrigatório!");
        }

    }
}
