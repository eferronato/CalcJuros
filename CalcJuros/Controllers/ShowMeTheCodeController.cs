using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcJuros.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcJuros.Controllers
{
    /// <summary>
    /// Classe que define o endpoint "/showmethecode"
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        /// <summary>
        /// Retorna a URL do código fonte no GitHub. 
        /// Created by Elton Ferronato
        /// </summary>
        /// <returns>URL com o repositório do código fonte</returns>
        [HttpGet("")]
        public ActionResult<string> ShowMeTheCode()
        {
            return new GitHubHelper().GetURL();
        }
    }
}