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
            builder.Services.AddMudServices();
            return builder;
        }

        public static MudTheme GetCustomTheme()
        {
            return new MudTheme()
            {
                PaletteLight = new PaletteLight()
                {
                    Primary = Colors.LightGreen.Default,
                    Secondary = Colors.LightGreen.Darken1,
                    Background = "#F7FAF5"
                }
            };
        }
    }
}