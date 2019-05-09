using CalcJuros.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalcJuros.Tests
{
    /// <summary>
    /// Classe de teste para o GitHubHelper
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class GitHubHelperTest
    {        
        [Fact]
        public void GetURL_Deve_Retornar_URL_Correta()
        {
            var obj = new GitHubHelper();            
            Assert.Equal(GitHubHelper.GITHUB_URL, obj.GetURL());
        }

        [Fact]
        public void GetURL_Deve_Retornar_URL_Valida()
        {
            var obj = new GitHubHelper();            
            Assert.True(Uri.IsWellFormedUriString(obj.GetURL(), UriKind.Absolute));            
        }
    }
}
