using BC.Complaints.Application.Common.Interfaces;
using BC.Complaints.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BC.Complaints.Persistence.Context
{
    public class BankruptcyDbContext : DbContext, IBankruptcyDbContext
    {
        public BankruptcyDbContext(DbContextOptions<BankruptcyDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");
            builder.ApplyConfigurationsFromAssembly(typeof(BankruptcyDbContext).Assembly);
        }
    }
}
