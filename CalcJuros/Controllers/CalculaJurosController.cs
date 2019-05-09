using CalcJuros.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;

namespace CalcJuros.Controllers
{
    /// <summary>
    /// Classe que define o endpoint "/calculajuros"
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// Efetua o cálculo de Juros compostos de acordo com a fórmula: Valor Final = Valor Inicial * ((1 + juros) ^ Tempo)
        /// A taxa de juros é 1% (fixo conforme solicitado)        
        /// </summary>
        /// <param name="valorInicial">Decimal que representa o valor inicial a ser calculado</param>
        /// <param name="meses">Inteiro que representa o tempo em meses</param>
        /// <returns>O valor calculado com juros, truncado em duas casas decimais sem arredondamento.</returns>                
        [HttpGet("")]
        public ActionResult<string> CalculaJuros(decimal valorInicial, int meses)
        {
            try
            {
                return new Juros().CalcularJuros(valorInicial, meses);
            }
            catch (OverflowException)
            {                
                return BadRequest("O valor informado é muito alto, por favor revise os parâmetros.");                
            }
        }
    }
}