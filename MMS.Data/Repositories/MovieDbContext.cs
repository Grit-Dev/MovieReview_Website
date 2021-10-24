using System;
using MMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MMS.Data.Repositories
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
      
        // Could use SqlServer using connection below if installed
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder               
                /** use simple logging to log the sql commands issued by entityframework **/ 
                //.LogTo(Console.WriteLine, LogLevel.Information)
                //.EnableSensitiveDataLogging()
                .UseSqlite("Filename=movies.db");
        }
    
        public void Initialise() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}