using ChooseDay.Services;
using ChooseDay.ViewModels;

namespace ChooseDay;

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

		builder.Services.AddSingleton<MyDayService>();
        builder.Services.AddSingleton<MyDaysViewModel>();

		builder.Services.AddTransient<MyDayDetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<DetailsPage>();

        return builder.Build();
	}
}
