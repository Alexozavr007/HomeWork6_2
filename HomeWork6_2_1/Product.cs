using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork6_2_1;

public class Product {

    [Column("ProductId")]
    public Guid Id { get; set; }

    [MaxLength(30)]
    public string Name { get; set; }
    public double Cost { get; set; }

    [MaxLength(255)]
    public string Description {  get; set; }
    public int Quantity {  get; set; }

    [Column(TypeName = "date")]
    public DateTime RecordDate { get; set; }

    public override string ToString() {
        return $"{Id} - {Name} - {Cost} - {Description} - {Quantity}";
    }
}
