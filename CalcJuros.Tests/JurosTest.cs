using CalcJuros.Core;
using System;
using Xunit;

namespace CalcJuros.Tests
{
    /// <summary>
    /// Classe de teste para o CalculaJuros
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class JurosTest
    {
        private Juros _juros;

        public JurosTest()
        {
            _juros = new Juros();
        }

        /// <summary>
        /// Resultado esperado: 105,10
        /// </summary>
        [Fact]        
        public void CalcularJuros_Deve_Retornar_Valor_Correto()
        {            
            Assert.Equal("105,10", _juros.CalcularJuros(100, 5));
            Assert.Equal("72256,96", _juros.CalcularJuros(9876.543M, 200));
            Assert.Equal("471941364,91", _juros.CalcularJuros(3259876.543M, 500));            
        }               

        /// <summary>
        /// Testa se está truncando corretamente em 2 casas sem arredondar
        /// </summary>
        [Fact]
        public void CalcularJuros_Deve_Truncar_Sem_Arredondar()
        {            
            Assert.Equal("109,36", _juros.CalcularJuros(100, 9));
            Assert.Equal("111,56", _juros.CalcularJuros(100, 11 ));
        }

        /// <summary>
        /// Testa se possui exatamente 2 casas decimais
        /// </summary>
        [Fact]
        public void CalcularJuros_Deve_Retornar_Duas_Casas_Decimais()
        {
            const string DEC_SEPARATOR = ",";
            var value = _juros.CalcularJuros(100, 5);

            Assert.Contains(DEC_SEPARATOR, value);            
            Assert.Equal(2, value.Substring(value.LastIndexOf(DEC_SEPARATOR) + 1).Length);
        }
    }
}
