using BeiseMaui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeiseMaui.Services
{
    public class ArticleService : IArticleService
    {

        HttpClient httpClient;
       
        public ArticleListResult Article { get; private set; }

        public ArticleService()
        {
            httpClient = new HttpClient();
        }
        
        
        public async Task<ArticleListResult> GetArticles(string urlString)
        {
            Article = new ArticleListResult();

            Uri uri = new(urlString);
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //ArticleListResult = JsonSerializer.Deserialize<ArticleListResult>(content, serializerOptions);


                    Article =  Newtonsoft.Json.JsonConvert.DeserializeObject<ArticleListResult>(content);     
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Article;
        }
    }
}
