using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    [Range(0, 200, ErrorMessage = "Weight must be a positive, round number (in lbs).")]
    public int Weight { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime IntakeDate { get; set; }
    [Required]
    public bool AvailablilityStatus { get; set; }
  }
}