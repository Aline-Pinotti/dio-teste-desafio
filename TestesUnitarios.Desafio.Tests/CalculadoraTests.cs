using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class CalculadoraTests
    {
        private Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestarSoma(int num1, int num2, int resultado)
        {
            int calculado = _calculadora.Somar(num1, num2);
            Assert.Equal(resultado, calculado);
        }

         [Theory]
        [InlineData (10, 2, 8)]
        [InlineData (14, 5, 9)]
        public void TestarSubtracao(int num1, int num2, int resultado)
        {
            int calculado = _calculadora.Subtrair(num1, num2);
            Assert.Equal(resultado, calculado);
        }

        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (4, 5, 20)]
        public void TestarMultiplicacao(int num1, int num2, int resultado)
        {
            int calculado = _calculadora.Multiplicar(num1, num2);
            Assert.Equal(resultado, calculado);
        }

       [Theory]
        [InlineData (10, 2, 5)]
        [InlineData (40, 5, 8)]
        public void TestarDivisao(int num1, int num2, int resultado)
        {
            int calculado = _calculadora.Dividir(num1, num2);
            Assert.Equal(resultado, calculado);
        }

        [Fact]
        public void TentarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calculadora.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico(){
            _calculadora.Somar(1, 2);
            _calculadora.Somar(2, 6);
            _calculadora.Somar(1, 7);
            _calculadora.Somar(3, 12);

            var lista = _calculadora.RetornarHistorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}