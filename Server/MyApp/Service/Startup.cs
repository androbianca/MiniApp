using BusinessLogic.Configurations;
using Elmah.Io.AspNetCore;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;

namespace Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)

        {
            /* services.AddCors(options =>
             {
                 options.AddDefaultPolicy(
                     builder =>
                     {
                         builder.WithOrigins("http://localhost:4200");
                     });
             });


 */

            services.AddMvc()
                    .AddFluentValidation(o =>
                    {
                        o.RegisterValidatorsFromAssemblyContaining<Startup>();
                    });
            services.AddControllers();
            services.AddElmahIo(o =>
            {
                o.ApiKey = "a19b81e9236340569439a03856ea182c";
                o.LogId = new Guid("e47c45ed-6563-4738-b9a0-29b074692227");
            });
            services.AddBusinessLogic(Configuration.GetConnectionString("MyApp"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/myapp-{Date}.txt");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors();

            app.UseAuthorization();
            app.UseElmahIo();
            app.UseElmahIoSerilog();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
