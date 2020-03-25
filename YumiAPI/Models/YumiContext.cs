using Microsoft.EntityFrameworkCore;

namespace YumiAPI.Models{

    public class YumiContext : DbContext{
        
        public YumiContext(DbContextOptions<YumiContext> options):base(options){}

        public DbSet<MenuItem> MenuItem { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Order> Order { get; set; }

    }

}