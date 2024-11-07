using Microsoft.Extensions.Logging;
using SQLiteCar.MVVM.Models;
using SQLiteCar.Repositories;

namespace SQLiteCar;

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
		builder.Services.AddSingleton<CarRepository>();
		

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
