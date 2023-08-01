using IdentityCoreSetup.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreSetup.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Rent> rents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=sql.bsite.net\\MSSQL2016;Integrated Security=False;initial catalog=rentsystem_db;User ID=rentsystem_db;Password=Mubix$2929;Connect Timeout=90;Encrypt=False;Packet Size=4096");
            base.OnConfiguring(optionsBuilder);
        }
    }
}