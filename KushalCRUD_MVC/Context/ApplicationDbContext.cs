using Microsoft.EntityFrameworkCore;
using KushalCRUD_MVC.Models;

namespace KushalCRUD_MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}