using Microsoft.EntityFrameworkCore;

namespace NordiskLuksusMVC.Models
{

    public class MatContext : DbContext
    {
        public MatContext(DbContextOptions<MatContext> options) : base(options) { }

        public DbSet<NordiskLuksusMVC.Models.Mat> Mat { get; set; }
        public DbSet<NordiskLuksusMVC.Models.User> User { get; set; }
        public DbSet<NordiskLuksusMVC.Models.Comment> Comment { get; set; }

    }
}