using System;
using Microsoft.EntityFrameworkCore;

namespace SimplePortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Games> Games { get; set; }
        public DbSet<Programs> Programs { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
