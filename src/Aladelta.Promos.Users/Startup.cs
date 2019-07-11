using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aladelta.Promos.Users.Core.Data;
using Aladelta.Promos.Users.Models;
using Aladelta.Promos.Users.Helpers;
using Aladeta.Promos.Users.Data;
using Aladeta.Promos.Users.Data.Repositories;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Aladelta.Promos.Users.Types;

namespace Aladelta.Promos.User
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddHttpContextAccessor();
            services.AddSingleton<ContextServiceLocator>();
            services.AddDbContext<PromoUserContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:NHLStatsDb"]));
            services.AddTransient<IPromoRepository, PromoRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<Queries>();
            services.AddSingleton<Mutations>();
            services.AddSingleton<PromoType>();
            services.AddSingleton<DiscountPromoType>();
            services.AddSingleton<SpecialPrizePromoType>();
            //services.AddSingleton<PromoInputType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new GraphQLSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
        }
    }
}
