using System;

namespace CalcJuros.Core
{
    /// <summary>
    /// Classe utilizada para realizar o cálculo de juros compostos
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class Juros
    {
        /// <summary>
        /// Efetua o cálculo de Juros compostos de acordo com a fórmula: Valor Final = Valor Inicial * ((1 + juros) ^ Tempo)
        /// A taxa de juros é 1% (fixo conforme solicitado)        
        /// </summary>
        /// <param name="valorInicial">Decimal que representa o valor inicial a ser calculado</param>
        /// <param name="meses">Inteiro que representa o tempo em meses</param>
        /// <returns>O valor calculado com juros, truncado em duas casas decimais sem arredondamento.</returns>
        public string CalcularJuros(decimal valorInicial, int meses)
        {
            const double PERC_JUROS = 0.01;

            double juros = Math.Pow(1 + PERC_JUROS, meses);
            decimal valorFinal = valorInicial * Convert.ToDecimal(juros);

            //Trunca o valor para 2 casas decimais sem arredondar
            return string.Format("{0:0.00}", valorFinal.Truncar(2));
        }
    }
}
