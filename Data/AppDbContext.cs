using Microsoft.EntityFrameworkCore;
using MvcBook.Models;

namespace MvcWorkspace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }

        //DbSets Area
        public DbSet<Books> Books { get; set; }
        public DbSet<Commentaries> Commentaries { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}