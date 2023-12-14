using LMSWebAPIProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace LMSWebAPIProject.Context
{
    public class LMSContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public LMSContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("LMSDb");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Overdue> Overdues { get; set; }
    }
}
