using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace PatricioSolucao.Dominio.Testes
{
    [TestFixture]
    public class FinanceiroTestes
    {
        private Financeiro _financeiro;

        [SetUp]
        public void Inicializador()
        {
            _financeiro = new Financeiro
            {
                id = 1,
                valor = 50,
                operacao = true,
                balanco = 500
            };
        }

        [Test]
        public void Teste_Financeiro_Deve_Ter_Valor_Maior_Que_Zero()
        {
            //ARRANGE
            _financeiro.valor = 0;

           //ACTIONl
           Action resultado = () => _financeiro.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("O campo numero não pode ser zero!");
        }

        [Test]
        public void Teste_Financeiro_Deve_Possuir_Uma_Operacao()
        {
            //ARRANGE
            _financeiro.operacao = true;

            //ACTIONl
            Action resultado = () => _financeiro.Validar();

            //ASSERT
            resultado.Should()
                .Throw<Exception>()
                .WithMessage("Selecione uma operação!");
        }
    }
}
