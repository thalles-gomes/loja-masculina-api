using Loja.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja.Api.Data;

public class LojaDbContext : DbContext
{
    public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options) { }

    public DbSet<Produto> Produtos => Set<Produto>();
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Cor> Cores => Set<Cor>();
    public DbSet<Tamanho> Tamanhos => Set<Tamanho>();
    public DbSet<Variacao> Variacoes => Set<Variacao>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>(e =>
        {
            e.Property(p => p.Codigo).HasMaxLength(20);
            e.HasIndex(p => p.Codigo).IsUnique();

            e.HasOne(p => p.Categoria)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Variacao>(e =>
        {
            e.Property(v => v.Preco).HasPrecision(10, 2);
            e.HasIndex(v => v.CodigoSku).IsUnique();
            e.HasIndex("ProdutoId", "CorId", "TamanhoId").IsUnique();

            e.HasOne(v => v.Cor)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            
            e.HasOne(v => v.Tamanho)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Cor>(e =>
        {
            e.HasIndex(c => c.Codigo).IsUnique();
        });

        modelBuilder.Entity<Categoria>(e =>
        {
            e.HasIndex(c => c.Codigo).IsUnique();
        });
    }

}