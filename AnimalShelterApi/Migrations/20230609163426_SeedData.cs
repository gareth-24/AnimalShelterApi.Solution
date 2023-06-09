using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailablilityStatus",
                table: "Animals",
                newName: "AvailabilityStatus");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AvailabilityStatus", "Description", "IntakeDate", "Name", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, true, "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winnie", "Cat", 8 },
                    { 2, true, "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tucker", "Dog", 8 },
                    { 3, true, "Fluffy and independent Maine Coon. Prefers a calm environment without other pets.", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittens", "Cat", 6 },
                    { 4, true, "Energetic and loyal Labrador Retriever. Great with kids and loves to play fetch.", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", "Dog", 12 },
                    { 5, true, "Playful and affectionate Siamese. Enjoys being the center of attention.", new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luna", "Cat", 7 },
                    { 6, false, "Gentle and well-behaved Boxer. Gets along with other dogs and children.", new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Dog", 10 },
                    { 7, false, "Curious and playful Bengal. Requires mental stimulation and active playtime.", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simba", "Cat", 9 },
                    { 8, true, "Cheerful and obedient Beagle. Enjoys long walks and exploring new scents.", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", "Dog", 6 },
                    { 9, true, "Laid-back and affectionate Ragdoll. Loves being held and cuddled.", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", "Cat", 5 },
                    { 10, true, "Strong and protective Rottweiler. Needs an experienced owner and plenty of exercise.", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", "Dog", 14 },
                    { 11, true, "Sweet and friendly Tabby. Gets along well with other cats and loves to explore.", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco", "Cat", 7 },
                    { 12, true, "Active and playful Jack Russell Terrier. Requires mental stimulation and regular exercise.", new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", "Dog", 9 },
                    { 13, true, "Independent and graceful Persian. Prefers a calm and quiet environment.", new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lily", "Cat", 6 },
                    { 14, true, "Friendly and outgoing Border Collie. Excels at agility training and learning new tricks.", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooper", "Dog", 11 },
                    { 15, true, "Playful and mischievous Sphynx. Enjoys interactive toys and warm laps.", new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", "Cat", 8 },
                    { 16, false, "Gentle and affectionate Cavalier King Charles Spaniel. Great with families and seniors.", new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy", "Dog", 7 },
                    { 17, true, "Curious and playful Abyssinian. Loves interactive toys and climbing.", new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nala", "Cat", 7 },
                    { 18, true, "Loyal and protective German Shepherd. Requires an experienced owner and consistent training.", new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", "Dog", 13 },
                    { 19, true, "Affectionate and gentle Himalayan. Enjoys a calm and peaceful environment.", new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophie", "Cat", 6 },
                    { 20, true, "Energetic and friendly Australian Shepherd. Loves outdoor activities and playing fetch.", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bentley", "Dog", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.RenameColumn(
                name: "AvailabilityStatus",
                table: "Animals",
                newName: "AvailablilityStatus");
        }
    }
}
