using Microsoft.EntityFrameworkCore;

namespace HomeWork6_2_3;

public class MyDatabaseContext : DbContext{

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Error> Errors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Homework623;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        //[Column("ProductId")]
        modelBuilder
            .Entity<Product>()
            .Property(x => x.Id)
            .HasColumnName("ProductId");

        //[MaxLength(30)]
        modelBuilder
            .Entity<Product>()
            .Property(x => x.Name)
            .HasMaxLength(30);

        //[MaxLength(255)]
        modelBuilder
            .Entity<Product>()
            .Property(x => x.Description)
            .HasMaxLength(255);

        //[Column(TypeName = "date")]
        modelBuilder
            .Entity<Product>()
            .Property(x => x.RecordDate)
            .HasColumnType("date");

        modelBuilder
            .Entity<Product>()
            .HasKey(p => new { p.Id, p.AlterId });
            



        // EF doen't allow dbset with ignored entity
        //modelBuilder
        //    .Ignore<Error>();
    }
}
