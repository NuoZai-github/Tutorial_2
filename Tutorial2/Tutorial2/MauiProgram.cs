using Microsoft.Extensions.Logging;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Tutorial2.ViewModels.Pages;
using Tutorial2.Views.MainPage;

namespace Tutorial2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UsePrism(prism =>
                {
                    prism.RegisterTypes(container =>
                    {
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    })
                    .OnInitialized(container =>
                    {
                        var navigation = container.Resolve<INavigationService>();
                        navigation.NavigateAsync("MainPage");
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