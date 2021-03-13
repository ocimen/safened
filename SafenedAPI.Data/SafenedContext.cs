using System;
using Microsoft.EntityFrameworkCore;
using SafenedAPI.Domain;

namespace SafenedAPI.Data
{
    public class SafenedContext : DbContext
    {
        public SafenedContext()
        {
        }

        public SafenedContext(DbContextOptions<SafenedContext> options) : base(options)
        {
            FillUsers();
            FillBank();
            FillBankAccount();
            SaveChanges();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Product Version", "1.0.0.0");
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();
            });
        }

        private void FillUsers()
        {
            var users = new[]
            {
                new User
                {
                    Id = Constants.User1,
                    FirstName = "User 1",
                    LastName = "Test",
                    UserName = "user1",
                    Password = "pwd"
                },
                new User
                {
                    Id = Constants.User2,
                    FirstName = "User 2",
                    LastName = "Test 2",
                    UserName = "user2",
                    Password = "pwd"
                },
                new User
                {
                    Id = Constants.User3,
                    FirstName = "User 3",
                    LastName = "Test 3",
                    UserName = "user3",
                    Password = "pwd"
                }
            };

            User.AddRange(users);
        }

        private void FillBank()
        {
            var banks = new[]
            {
                new Bank
                {
                    Id = Constants.ING,
                    Name = "ING"
                },

                new Bank
                {
                    Id = Constants.ABN,
                    Name = "ABN"
                },
                new Bank
                {
                    Id = Constants.Rabobank,
                    Name = "Rabobank"
                }
            };

            Bank.AddRange(banks);
        }

        private void FillBankAccount()
        {
            var accounts = new[]
            {
                new BankAccount
                {
                    Id = Constants.User_1_ING_Account,
                    BankId = Constants.ING,
                    UserId = Constants.User1,
                    Balance = 250M
                },
                new BankAccount
                {
                    Id = Constants.User_1_ABN_Account,
                    BankId = Constants.ABN,
                    UserId = Constants.User1,
                    Balance = 100M
                },
                new BankAccount
                {
                    Id = Constants.User2_Rabobank_Account,
                    BankId = Constants.Rabobank,
                    UserId = Constants.User2,
                    Balance = 500M
                }
            };

            BankAccount.AddRange(accounts);
        }
    }
}