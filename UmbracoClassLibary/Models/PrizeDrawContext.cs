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
    }

}