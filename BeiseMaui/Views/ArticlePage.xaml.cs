using BeiseMaui.Models;
using BeiseMaui.Services;
using BeiseMaui.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace BeiseMaui
{
    public partial class ArticlePage : ContentPage
    {
        readonly ArticleViewModel _viewModel;

        public ArticlePage(ArticleViewModel vm)
        {
            InitializeComponent();
            BindingContext = _viewModel = vm;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.InitializeAsync();
        }
    }

    
}
