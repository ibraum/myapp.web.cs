using Microsoft.EntityFrameworkCore;
using MyApp.web.Models;

namespace MyApp.web.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
    }
}
