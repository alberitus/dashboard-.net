using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nama kategori wajib diisi")]
    [StringLength(100, ErrorMessage = "Nama kategori maksimal 100 karakter")]
    public string Name { get; set; } = string.Empty;

    // Relasi ke InventoryItem
    public ICollection<InventoryItem>? InventoryItems { get; set; }
}
