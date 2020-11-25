using Microsoft.EntityFrameworkCore;
using DNP_API.Model;
using DNP_API.Login;
namespace DNP_API.Context{
    public class AdultContext:DbContext{
        public DbSet<Adult> Adults{get;set;}
        public DbSet<User> users{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source = Adults.db");
        }
    }
}