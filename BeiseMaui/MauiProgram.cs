
using BeiseMaui.Services;
using BeiseMaui.ViewModels;

namespace BeiseMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddSingleton<IArticleService,ArticleService>();
		builder.Services.AddSingleton<ArticleViewModel>();
		builder.Services.AddSingleton<ArticlePage>();

		return builder.Build();
	}
}
