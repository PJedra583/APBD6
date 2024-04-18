namespace Tutorial5.Models.DTOs;
using System.ComponentModel.DataAnnotations;

public class EditAnimal
{
    
    [Required]
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(200)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(200)]
    public string Category { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(200)]
    public string Area { get; set; }
}