
using BeiseMaui.Services;
using BeiseMaui.ViewModels;
using BeiseMaui.Views;

namespace BeiseMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("PingFang-Regular.ttf", "PingFang-Regular.ttf");
                fonts.AddFont("PingFang-Bold.ttf", "PingFang-Bold.ttf");
                fonts.AddFont("PingFang-Light.ttf", "PingFang-Light.ttf");
                fonts.AddFont("PingFang-Medium.ttf", "PingFang-Medium.ttf");
            });



        builder.Services.AddSingleton<IArticleService,ArticleService>();
		builder.Services.AddSingleton<ArticleViewModel>();
		builder.Services.AddSingleton<ArticlePage>();


        builder.Services.AddSingleton<NewPage1>();

        return builder.Build();
	}
}
