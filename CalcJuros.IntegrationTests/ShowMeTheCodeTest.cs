using CalcJuros.Core;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalcJuros.IntegrationTests
{
    /// <summary>
    /// Classe que que realiza os testes de integração do endpoint /showmethecode
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class ShowMeTheCodeTest
    {
        private readonly ClientContext _client;

        public ShowMeTheCodeTest()
        {
            _client = new ClientContext();
        }

        /// <summary>
        /// Verifica se a chamada do serviço retorna resposta OK
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task ShowMeTheCode_Retorna_StatusOK()
        {
            var response = await _client.Client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        /// <summary>
        /// Verifica se está retornando a string correta
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task ShowMeTheCode_Retorna_StringCorreta()
        {
            var response = await _client.Client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();
            response.Content.ReadAsStringAsync().Result.Should().Be(GitHubHelper.GITHUB_URL);
        }
    }
}
