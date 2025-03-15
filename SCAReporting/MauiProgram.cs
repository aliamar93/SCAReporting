using Microsoft.Extensions.Logging;
using SCAReporting.ViewModel;

namespace SCAReporting;

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

		//initialize 
		// Add SingleTon    A singleton is a class which only allows one instance of itself to be created - and gives simple, easy access to said instance

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();


        //The Transient lifetime creates a new instance of a service every time it is requested
        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<DetailViewModel>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
