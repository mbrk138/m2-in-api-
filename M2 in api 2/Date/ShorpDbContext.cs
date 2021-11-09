using M2_in_api_2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Date
{
    public class ShorpDbContext : DbContext
    {
        public ShorpDbContext(DbContextOptions  options) : base(options)
        {

        }

        public ShorpDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("team power");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Create_a_user_account_login> useraccont { get; set; }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }



    }
}
