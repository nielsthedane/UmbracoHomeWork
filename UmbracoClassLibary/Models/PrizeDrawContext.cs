using System;
using Microsoft.EntityFrameworkCore;

namespace UmbracoClassLibary.Models
{
    public class PrizeDrawContext : DbContext
    {
        public PrizeDrawContext(DbContextOptions<PrizeDrawContext> options)
            : base(options)
        { }

        public DbSet<SerialNumber> SerialNumbers { get; set; }
        
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 0; i <= 100; i++)
            {
                modelBuilder.Entity<SerialNumber>().HasData(new SerialNumber(Guid.NewGuid()));
            }
        }
    }

}