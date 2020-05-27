using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenges.Data;
using Challenges.Data.Repos;
using Challenges.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Challenges
{
    public class Startup
    {


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IMathematicalServices, MathematicalServices>();
            services.AddSingleton<IStringServices, StringServices>();
            services.AddSingleton<ISortingServices, SortingServices>();

            services.AddDbContext<ChallengesContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("ChallengesConnectionString"));
            });

            
            services.AddScoped<IMathsRepository,MathsRepository>();
            services.AddScoped<IStringRepository, StringRepository>();
            services.AddScoped<ISortingRepository, SortingRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
             {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
