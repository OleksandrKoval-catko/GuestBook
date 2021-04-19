using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace GuestBookApi
{

    public class Startup
    {
        IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            // services.AddSwaggerGen();
            services.AddMvcCore(x => { x.EnableEndpointRouting = false; });
            services.AddDbContext<Context.MainContext>(build => build.UseSqlServer(connectionString));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //  app.UseSwagger();
            //  app.UseSwaggerUI(s =>
            // {
            //    s.SwaggerEndpoint("/swagger/v1/swagger.json", "GuestBookApi v1");
            // });
            app.UseMvcWithDefaultRoute();

        }
    }
}
