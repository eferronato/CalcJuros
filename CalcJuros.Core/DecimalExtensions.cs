using System;

namespace CalcJuros.Core
{
    /// <summary>
    /// Classe com extension methods referentes o tipo decimal
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="casas"></param>
        /// <returns></returns>
        public static decimal Truncar(this decimal valor, int casas)
        {
            return Math.Truncate(100 * valor) / 100;
        }
    }

}