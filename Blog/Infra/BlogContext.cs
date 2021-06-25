using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infra
{
    public class BlogContext : DbContext 
    {
        // Class to mapping for table at database
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Acess AppSettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            // Recovery connection string
            IConfiguration configuration = builder.Build();
            string stringConnection = configuration.GetConnectionString("Blog");

            optionsBuilder.UseSqlServer(stringConnection);
        }
    }
}
