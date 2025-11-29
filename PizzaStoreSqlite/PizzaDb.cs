// PizzaDb.cs
using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore.Models;

public class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions<PizzaDb> options) : base(options) { }

    public DbSet<Pizza> Pizzas => Set<Pizza>();
}