
using Microsoft.EntityFrameworkCore;
using WalletManagement.Models;

namespace WalletManagement.Infrastructure
{
    public class WalletManagementContext : DbContext
    {
        public WalletManagementContext(DbContextOptions<WalletManagementContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Account>().Property(acc => acc.AccountName).HasDefaultValue();
            builder.Entity<Account>().Property(acc => acc.CreationDate).HasDefaultValueSql("getdate()");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}
