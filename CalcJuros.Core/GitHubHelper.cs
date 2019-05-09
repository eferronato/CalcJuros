namespace CalcJuros.Core
{
    /// <summary>
    /// Classe utilizada para buscar a URL do GitHub
    /// Autor: Elton Ferronato - 07/05/2019
    /// </summary>
    public class GitHubHelper
    {
        /// <summary>
        /// Contante que representa a URL do código fonte no github
        /// </summary>
        public static readonly string GITHUB_URL = "https://github.com/eferronato";

        /// <summary>
        /// Retorna a URL do código fonte. 
        /// Created by Elton Ferronato
        /// </summary>
        /// <returns>URL com o repositório do código fonte</returns>

        public string GetURL()
        {
            return GITHUB_URL;
        }
    }
}
