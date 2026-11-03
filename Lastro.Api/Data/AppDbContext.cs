using Microsoft.EntityFrameworkCore;
using Lastro.Api.Models;

namespace Lastro.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoas => Set<Pessoa>();
    public DbSet<Investimento> Investimentos => Set<Investimento>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pessoa>().HasData(
            new Pessoa { Id = 1, Nome = "Matheus Santos", Cpf = "123.456.789-00" },
            new Pessoa { Id = 2, Nome = "Célia Rodrigues", Cpf = "987.654.321-11" }
        );
    }
}