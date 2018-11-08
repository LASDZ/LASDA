using DTApp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace DTApp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options) {}
             
        public DbSet<Value> Values { get; set; } 
        public DbSet<User> User { get; set; } 
        }
}