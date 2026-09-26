using Microsoft.EntityFrameworkCore;
using PizzaDemo.Models;

namespace PizzaDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogHeader> BlogsHeader { get; set; }
    }
}
