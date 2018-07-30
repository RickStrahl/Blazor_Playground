using System;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<TodoBusiness>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {            
            app.AddComponent<App>("app");
        }
    }
}
