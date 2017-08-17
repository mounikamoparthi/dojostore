using Microsoft.EntityFrameworkCore;

namespace dojostore.Models
{
    public class dojoStoreContext: DbContext
    {
        public dojoStoreContext(DbContextOptions<dojoStoreContext> options) : base(options) { }

        public DbSet<User> users {get;set;}

        public DbSet<Product> products {get; set;}
        public DbSet<Order> orders {get; set;}
    }

}