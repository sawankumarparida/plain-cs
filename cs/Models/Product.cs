namespace cs.Models;
using System.ComponentModel.DataAnnotations.Schema; // Add this using

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")] // 18 total digits, 2 after the decimal
    public decimal Price { get; set; }
}