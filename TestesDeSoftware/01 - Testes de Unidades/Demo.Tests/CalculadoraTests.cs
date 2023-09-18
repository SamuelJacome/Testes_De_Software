using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(4,2,6)]
        [InlineData(5,5,10)]
        [InlineData(3,7,10)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act 
            var resultado = calculadora.Somar(v1, v2);
            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
