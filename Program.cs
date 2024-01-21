// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create an instance of the PlantScheduler class
        var plantScheduler = new PlantScheduler();

        // Add plants and their watering dates to the schedule
        plantScheduler.AddPlant("Spider Plant", new DateTime(2024, 01, 15));
        plantScheduler.AddPlant("Hibiscus", new DateTime(2024, 01, 20));

        // Display the watering date for specific plants
        Console.WriteLine($"Watering date for Spider Plant: {plantScheduler.GetWateringDate("Spider Plant")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Hibiscus: {plantScheduler.GetWateringDate("Hibiscus")?.ToShortDateString()}");

        // Display the entire watering schedule
        plantScheduler.DisplaySchedule();
    }
}