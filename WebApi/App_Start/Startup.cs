using Microsoft.Owin;
using NSwag.AspNet.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(BeingArtisanWebApi.Startup))]
namespace BeingArtisanWebApi
{   
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseStaticFiles();

            app.UseSwagger(typeof(Startup).Assembly, settings =>
            {
                // configure settings here
                // settings.GeneratorSettings.*: Generator settings and extension points
                // settings.*: Routing and UI settings

                settings.PostProcess = (process) =>
                {
                    process.Info.Title = "WebAPI";
                };
            });

            app.UseSwaggerUi3(typeof(Startup).Assembly, settings =>
            {
                settings.TagsSorter = "alpha";
            });
        }
    }
}