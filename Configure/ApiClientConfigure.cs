using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenStore.Clients;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace GreenStore.Configure
{
    public static class ApiClientConfigure
    {
        public static WebAssemblyHostBuilder RegisterApiClient(this WebAssemblyHostBuilder builder)
        {
            string apiUrl =
                builder.Configuration["ApiUrl"]
                ?? throw new NullReferenceException("Can't read ApiUrl");

            builder.Services.AddScoped(scope => new HttpClient { BaseAddress = new Uri(apiUrl) });

            builder.Services.AddScoped<IGreenStoreApiClient>(sp =>
            {
                var http = sp.GetRequiredService<HttpClient>();
                return new GreenStoreApiClient(apiUrl, http);
            });

            return builder;
        }
    }
}
