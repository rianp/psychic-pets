using System.ComponentModel.DataAnnotations;

namespace PsychicPets.Pets;

public class Pet
{
  public int Id { get; set; }
  [Required]
  public string Name { get; set; }
} 



