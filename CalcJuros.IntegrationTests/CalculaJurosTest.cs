using CalcJuros.Core;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalcJuros.IntegrationTests
{
    /// <summary>
    /// Classe que que realiza os testes de integração do endpoint /calculajuros
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class CalculaJurosTest
    {
        private readonly ClientContext _client;

        public CalculaJurosTest()
        {
            _client = new ClientContext();
        }

        /// <summary>
        /// Verifica se a chamada do serviço retorna resposta OK
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CalculaJuros_Retorna_StatusOK()
        {
            var response = await _client.Client.GetAsync("/calculajuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        
        /// <summary>
        /// Verifica se está retornando a string correta
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CalculaJuros_Retorna_Valor_Correto()
        {
            var response = await _client.Client.GetAsync("/calculajuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.Content.ReadAsStringAsync().Result.Should().Be("105,10");
        }
    }
}
