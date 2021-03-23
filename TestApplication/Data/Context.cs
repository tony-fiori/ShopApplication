using Microsoft.EntityFrameworkCore;
using Models;
using TestApplication.Models;

namespace TestApplication.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}
        public DbSet<Book> Book {get; set;}
        public DbSet<Book_description> Book_Description {get; set;}
        public DbSet<Students> Students {get; set;}
        public DbSet<Students_Description> students_Description {get; set;}
        public DbSet<Library> Library {get; set;}
        public DbSet<User> User {get; set;}
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}