using Microsoft.EntityFrameworkCore;

namespace HomeWork6_2_1;

public class MyDatabaseContext : DbContext{
    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Homework621;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
}
