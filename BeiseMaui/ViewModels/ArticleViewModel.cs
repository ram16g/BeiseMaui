using BeiseMaui.Models;
using BeiseMaui.Services;
using BeiseMaui.ViewModels;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace BeiseMaui.ViewModels
{
    public  partial class ArticleViewModel: BaseViewModel
    {

        private string nextPageUrl = "";
        private bool firstLoad = true;

        public ObservableCollection<ArticleListResult.Item> Items { get; } = new(); 
        readonly IArticleService articleService;

        public ArticleViewModel(IArticleService articleService)
        {
            Title = "文章列表";
            this.articleService = articleService;

        }

       public async Task InitializeAsync()
        {
            if (!firstLoad)
            {
                return;
            }
            await LoadItems();   
        }

        [ICommand]
        async Task LoadItems()
        {
            IsBusy = true;
            Items.Clear();
            try
            {
                string url = "https://www.beise.com/index.php?m=app&c=home&a=news";

                var articles = await articleService.GetArticles(url);
                nextPageUrl = articles.data.next_url;

                foreach (var article in articles.data.list)
                {
                    article.formatted = FormatText(article);
                    Items.Add(article);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
                firstLoad = false;
            }
        }

        


        [ICommand]
        async Task LoadMore()
        {
            if (string.IsNullOrEmpty(nextPageUrl))
            {
                return;
            }
            
            IsBusy = false;
            try
            {
                
                var articles = await articleService.GetArticles(nextPageUrl);
                nextPageUrl = articles.data.next_url;


                foreach (var article in articles.data.list)
                {

                    article.formatted = FormatText(article);
                    Items.Add(article); 
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }


        private FormattedString FormatText(ArticleListResult.Item article)
        {
            FormattedString formatted = new FormattedString();
            formatted.Spans.Add(new Span
            {
                Text = "#" + article.title + "#",
                TextColor = Color.FromRgb(253, 156, 12),
                FontFamily = "PingFang-Regular",
                FontSize = 15
            }); ;

            formatted.Spans.Add(new Span
            {
                Text = article.description,
                TextColor = Colors.Black,
                FontFamily = "PingFang-Regular",
                FontSize = 15
            });

            return formatted;
        }

    }
}
