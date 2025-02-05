using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstCrudAPI_Net8.Models;

public class Deposito
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Conta")]
    public int ContaId { get; set; }

    [Required]
    public decimal Valor { get; set; }

    [Required]
    public DateTime Data { get; set; } = DateTime.UtcNow;
    
    
}