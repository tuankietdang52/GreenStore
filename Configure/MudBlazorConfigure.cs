using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

namespace GreenStore.Configure
{
    public static class MudBlazorConfigure
    {
        public static WebAssemblyHostBuilder UseMudBlazor(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.UseSnackbarCustomConfigure();
            });
            return builder;
        }

        private static SnackbarConfiguration UseSnackbarCustomConfigure(this SnackbarConfiguration config)
        {
            config.PositionClass = Defaults.Classes.Position.TopRight;
            config.PreventDuplicates = true;
            config.NewestOnTop = true;
            config.SnackbarVariant = Variant.Filled;
            config.ShowCloseIcon = true;
            config.VisibleStateDuration = 2000; // 2 seconds
            config.ShowTransitionDuration = 200;
            config.HideTransitionDuration = 200;

            return config;
        }

        public static MudTheme GetCustomTheme()
        {
            return new MudTheme()
            {
                PaletteLight = new PaletteLight()
                {
                    Primary = Colors.LightGreen.Default,
                    Secondary = Colors.LightGreen.Darken1,
                    Background = "#F7FAF5",
                },
            };
        }
    }
}
