using System.ComponentModel.DataAnnotations;

namespace PsychicPets.Models;

public class Pet
{
  public int Id { get; set; }
  [Required]
  public string Name { get; set; }
}