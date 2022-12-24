using Microsoft.EntityFrameworkCore;
using MvcBook.Models;

namespace MvcWorkspace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

       
        //DbSets Area
    }
}