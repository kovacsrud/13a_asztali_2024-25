using MauiHybridMeroora.mvvm.model;
using MauiHybridMeroora.mvvm.viewmodel;
using MauiHybridMeroora.repository;
using Microsoft.Extensions.Logging;

namespace MauiHybridMeroora
{
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

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<BaseRepository<MeroOra>>();
            builder.Services.AddSingleton<MeroViewModel>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
