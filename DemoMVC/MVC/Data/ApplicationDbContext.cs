using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base (options)
        {

        }
        public DbSet<Person>Person{get;set;}
        public DbSet<MVC.Models.Student> Student { get; set; } = default!;
    }
}