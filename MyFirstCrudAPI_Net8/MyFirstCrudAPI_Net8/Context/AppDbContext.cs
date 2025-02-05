using Microsoft.EntityFrameworkCore;
using MyFirstCrudAPI_Net8.Models;

namespace MyFirstCrudAPI_Net8.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }

    public DbSet<Conta> Products { get; set; }
}