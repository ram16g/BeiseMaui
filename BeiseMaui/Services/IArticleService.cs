using BeiseMaui.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeiseMaui.Services
{
    public interface IArticleService
    {
        Task<ArticleListResult> GetArticles(string page);
    }
}
