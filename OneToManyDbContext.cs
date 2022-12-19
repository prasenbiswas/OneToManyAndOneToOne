using Microsoft.EntityFrameworkCore;
using OneToManyRelCore.Models;

namespace OneToManyRelCore.Data
{
    public class OneToManyDbContext : DbContext
    {
        public OneToManyDbContext(DbContextOptions<OneToManyDbContext> options) : base(options)
        {

        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
