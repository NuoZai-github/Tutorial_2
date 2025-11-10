using Microsoft.Extensions.Logging;
using Prism; 
using Prism.Ioc; 
using Tutorial2.ViewModels.Pages; 
using Tutorial2.Views.MainPage;   
using Prism.DryIoc; 

namespace Tutorial2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UsePrism((prism) => 
                {
                    prism.RegisterTypes(container =>
                    {
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    })
                    .OnAppStart(app =>
                    {
                        app.NavigateAsync(nameof(MainPage));
                    });
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}