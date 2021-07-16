using System;
using System.Threading.Tasks;
using BL.Interfaces;
using EF;
using EF.Repository;
using ExternalProduct.Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExcelImport
{
    class Program
    {
        private readonly IProductDocumentRepository ProdDocRepo;
        public Program(IProductDocumentRepository ProdDocRepo)
        {
            this.ProdDocRepo = ProdDocRepo;
        }
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            
            host.Services.GetRequiredService<Program>().Run();
        }
        public void Run()
        {
            Import("C:\\Users\\Mijael\\Downloads\\ProdDocumentation\\DocLitImport_V5.0.xlsx", 1);
        }
        public void Import(string path, int sheetindex)
        {
            ExcelReader er = new ExcelReader(path, sheetindex);
            foreach (var item in er.result)
            {
                ProdDocRepo.Save(item);
            }
        }
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices(services =>
                {
                    var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);

                    var config = builder.Build();
                    var connstr = config["ConnectionStrings:EFConnectionString"];
                    services.AddTransient<Program>();
                    //string connstr = configuration.GetConnectionString("EFConnectionString");
                    services.AddDbContext<ApplicationEFContext>(options => options.UseSqlServer(connstr));
                    //Inject Repositories
                    services.AddTransient<IProductDocumentRepository, ProductDocumentEFRepository>();
                });
        }
    }
}
