using MauiApp8.Pages;
using MauiApp8.ViewModels;

namespace MauiApp8;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<Pages.Task>();
		builder.Services.AddSingleton<MainViewModels>();

		return builder.Build();
	}
}
