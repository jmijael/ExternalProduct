using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BL.Models;
namespace EF
{
    public class ApplicationEFContext : DbContext
    {
        public ApplicationEFContext(DbContextOptions<ApplicationEFContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<stbLocaleDTO> stbLocales { get;set;}
        public DbSet<stbEntryDTO> stbEntrys { get; set; }
        public DbSet<stbProductDTO> stbProducts { get; set; }
        public DbSet<stbProductDetailDTO> stbProductDetails { get; set; }
        public DbSet<stbURLDocumentDTO> stbURLDocuments { get; set; }
        public DbSet<stbURLTypeDTO> stbURLTypes { get; set; }

    }
}
