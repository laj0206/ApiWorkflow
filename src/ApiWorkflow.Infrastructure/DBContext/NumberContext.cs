using ApiWorkflow.Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ApiWorkflow.Infrastructure.DBContext
{
    public class NumberContext : DbContext
    {
        internal const string DefaultSchema = "Number";
        public NumberContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Account> Accounts { get; set; } = default!;
        public DbSet<Transaction> Transactions { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //If need to apply default schema other than dbo
            //modelBuilder.HasDefaultSchema(DefaultSchema);
        }
    }
}
