using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models;

public class InventoryItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nama wajib diisi")]
    [StringLength(100, ErrorMessage = "Nama maksimal 100 karakter")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Quantity wajib diisi")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity harus positif")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Harga wajib diisi")]
    [Range(0, double.MaxValue, ErrorMessage = "Harga harus positif")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    // Foreign key ke Category
    [Required(ErrorMessage = "Kategori wajib dipilih")]
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
}
