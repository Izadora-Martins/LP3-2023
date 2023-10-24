using Microsoft.EntityFrameworkCore;

namespace SP3066169MVCDBREC.Models;

public class MvcDBContext : DbContext
{
    public DbSet<Livro> Livro{ get; set; }
    public DbSet<Editora> Editora{ get; set; }

    public MvcDBContext(DbContextOptions<MvcDBContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>()
            .HasKey(c => c.IdLivro); // Assuming ClienteId is the primary key property

        modelBuilder.Entity<Editora>()
            .HasKey(c => c.IdEditora); // Assuming ClienteId is the primary key property
    }
    
}