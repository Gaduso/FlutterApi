using Microsoft.EntityFrameworkCore;

namespace Model.Configuration;

public class FlutterDbContext : DbContext{
    public FlutterDbContext(DbContextOptions<FlutterDbContext> options) : base(options){
    }

    public DbSet<Item> Items{ get; set; }
}