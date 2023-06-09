using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Winnie", Type = "Cat", Weight = 8, Description = "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.", IntakeDate = new DateTime(2023, 05, 14), AvailabilityStatus = true },
        new Animal { AnimalId = 2, Name = "Tucker", Type = "Dog", Weight = 8, Description = "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.", IntakeDate = new DateTime(2023, 05, 14), AvailabilityStatus = true },
        new Animal { AnimalId = 3, Name = "Mittens", Type = "Cat", Weight = 6, Description = "Fluffy and independent Maine Coon. Prefers a calm environment without other pets.", IntakeDate = new DateTime(2023, 05, 15), AvailabilityStatus = true },
        new Animal { AnimalId = 4, Name = "Buddy", Type = "Dog", Weight = 12, Description = "Energetic and loyal Labrador Retriever. Great with kids and loves to play fetch.", IntakeDate = new DateTime(2023, 05, 16), AvailabilityStatus = true },
        new Animal { AnimalId = 5, Name = "Luna", Type = "Cat", Weight = 7, Description = "Playful and affectionate Siamese. Enjoys being the center of attention.", IntakeDate = new DateTime(2023, 05, 17), AvailabilityStatus = true },
        new Animal { AnimalId = 6, Name = "Max", Type = "Dog", Weight = 10, Description = "Gentle and well-behaved Boxer. Gets along with other dogs and children.", IntakeDate = new DateTime(2023, 05, 18), AvailabilityStatus = false },
        new Animal { AnimalId = 7, Name = "Simba", Type = "Cat", Weight = 9, Description = "Curious and playful Bengal. Requires mental stimulation and active playtime.", IntakeDate = new DateTime(2023, 05, 19), AvailabilityStatus = false },
        new Animal { AnimalId = 8, Name = "Bailey", Type = "Dog", Weight = 6, Description = "Cheerful and obedient Beagle. Enjoys long walks and exploring new scents.", IntakeDate = new DateTime(2023, 05, 20), AvailabilityStatus = true },
        new Animal { AnimalId = 9, Name = "Oscar", Type = "Cat", Weight = 5, Description = "Laid-back and affectionate Ragdoll. Loves being held and cuddled.", IntakeDate = new DateTime(2023, 05, 21), AvailabilityStatus = true },
        new Animal { AnimalId = 10, Name = "Rocky", Type = "Dog", Weight = 14, Description = "Strong and protective Rottweiler. Needs an experienced owner and plenty of exercise.", IntakeDate = new DateTime(2023, 05, 22), AvailabilityStatus = true },
        new Animal { AnimalId = 11, Name = "Coco", Type = "Cat", Weight = 7, Description = "Sweet and friendly Tabby. Gets along well with other cats and loves to explore.", IntakeDate = new DateTime(2023, 05, 23), AvailabilityStatus = true },
        new Animal { AnimalId = 12, Name = "Charlie", Type = "Dog", Weight = 9, Description = "Active and playful Jack Russell Terrier. Requires mental stimulation and regular exercise.", IntakeDate = new DateTime(2023, 05, 24), AvailabilityStatus = true },
        new Animal { AnimalId = 13, Name = "Lily", Type = "Cat", Weight = 6, Description = "Independent and graceful Persian. Prefers a calm and quiet environment.", IntakeDate = new DateTime(2023, 05, 25), AvailabilityStatus = true },
        new Animal { AnimalId = 14, Name = "Cooper", Type = "Dog", Weight = 11, Description = "Friendly and outgoing Border Collie. Excels at agility training and learning new tricks.", IntakeDate = new DateTime(2023, 05, 26), AvailabilityStatus = true },
        new Animal { AnimalId = 15, Name = "Milo", Type = "Cat", Weight = 8, Description = "Playful and mischievous Sphynx. Enjoys interactive toys and warm laps.", IntakeDate = new DateTime(2023, 05, 27), AvailabilityStatus = true },
        new Animal { AnimalId = 16, Name = "Daisy", Type = "Dog", Weight = 7, Description = "Gentle and affectionate Cavalier King Charles Spaniel. Great with families and seniors.", IntakeDate = new DateTime(2023, 05, 28), AvailabilityStatus = false },
        new Animal { AnimalId = 17, Name = "Nala", Type = "Cat", Weight = 7, Description = "Curious and playful Abyssinian. Loves interactive toys and climbing.", IntakeDate = new DateTime(2023, 05, 29), AvailabilityStatus = true },
        new Animal { AnimalId = 18, Name = "Milo", Type = "Dog", Weight = 13, Description = "Loyal and protective German Shepherd. Requires an experienced owner and consistent training.", IntakeDate = new DateTime(2023, 05, 30), AvailabilityStatus = true },
        new Animal { AnimalId = 19, Name = "Sophie", Type = "Cat", Weight = 6, Description = "Affectionate and gentle Himalayan. Enjoys a calm and peaceful environment.", IntakeDate = new DateTime(2023, 05, 31), AvailabilityStatus = true },
        new Animal { AnimalId = 20, Name = "Bentley", Type = "Dog", Weight = 10, Description = "Energetic and friendly Australian Shepherd. Loves outdoor activities and playing fetch.", IntakeDate = new DateTime(2023, 06, 01), AvailabilityStatus = true }
      );
    }
  }

}