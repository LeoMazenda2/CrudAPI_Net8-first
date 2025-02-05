using System.ComponentModel.DataAnnotations;

namespace MyFirstCrudAPI_Net8.Models;

public class Conta
{
    public int Id { get; set; }
    [Display(Name = "Conta")]
    [Required]
    public string NumConta { get; set; }
   
    public ICollection<Deposito> Depositos { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}