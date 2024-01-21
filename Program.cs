using System;

class Program
{
    static void Main()
    {
        // Create an instance of the PlantScheduler class
        var plantScheduler = new PlantScheduler();

        // Add plants with names, watering dates, and locations to the schedule
        plantScheduler.AddPlant("Little Aloe", new DateTime(2024,01,27), "Kitchen");
        plantScheduler.AddPlant("Spider Plant", new DateTime(2024, 01, 15), "Pantry");
        plantScheduler.AddPlant("Hibiscus", new DateTime(2024, 01, 20), "Living Room");

        // Display the watering date for specific plants and locations
        Console.WriteLine($"Watering date for Spider Plant in the Living Room: {plantScheduler.GetWateringDate("Spider Plant", "Living Room")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Hibiscus in the Kitchen: {plantScheduler.GetWateringDate("Hibiscus", "Kitchen")?.ToShortDateString()}");

        // Display the entire watering schedule
        plantScheduler.DisplaySchedule();
    }
}