using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Interfaces;
using EF;
using EF.Repository;
using ExternalProduct.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ExternalProduct
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
            string connstr = Configuration.GetConnectionString("EFConnectionString");
            services.AddDbContext<ApplicationEFContext>(options => options.UseSqlServer(connstr));
            //Inject Repositories
            services.AddTransient<IstbLocaleRepository, stbLocaleEFRepository>();
            services.AddTransient<IstbEntryRepository, stbEntryEFRepository>();
            services.AddTransient<IstbProductDetailRepository, stbProductDetailEFRepository>();
            services.AddTransient<IstbProductRepository, stbProductEFRepository>();
            services.AddTransient<IstbURLDocumentRepository, stbURLDocumentEFRepository>();
            services.AddTransient<IstbURLTypeRepository, stbURLTypeEFRepository>();
            //Inject Services
            services.AddTransient<IProductDocumentationService, ProductDocumentationService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
