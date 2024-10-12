using Microsoft.EntityFrameworkCore;

namespace HomeWork6_2_2;

public class MyDatabaseContext : DbContext{

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Error> Errors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Homework622;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Product>()
            .HasKey(p => new { p.Id, p.AlterId });

        // EF doen't allow dbset with ignored entity
        //modelBuilder
        //    .Ignore<Error>();
    }
}
