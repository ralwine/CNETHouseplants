using System;

class Program
{
    static void Main()
    {
        // Create an instance of the PlantScheduler class
        var plantScheduler = new PlantScheduler();

        // Add plants with names, watering dates, and locations to the schedule
        plantScheduler.AddPlant("Jade Plant", new DateTime(2024,01,28), "Kitchen");
        plantScheduler.AddPlant("Rubber Plant", new DateTime(2024,01,27), "Kitchen");
        plantScheduler.AddPlant("Little Aloe", new DateTime(2024,01,27), "Kitchen");
        plantScheduler.AddPlant("Spider Plant", new DateTime(2024, 01, 15), "Pantry");
        plantScheduler.AddPlant("Hibiscus", new DateTime(2024, 01, 20), "Living Room");

        // Display the watering date for specific plants and locations
        Console.WriteLine($"Watering date for Jade Plant in the Kitchen: {plantScheduler.GetWateringDate("Jade Plant", "Kitchen")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Rubber Plant in the Kitchen: {plantScheduler.GetWateringDate("Rubber Plant", "Kitchen")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Little Aloe in the Kitchen: {plantScheduler.GetWateringDate("Little Aloe", "Kitchen")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Spider Plant in the Pantry: {plantScheduler.GetWateringDate("Spider Plant", "Pantry")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Hibiscus in the Living Room: {plantScheduler.GetWateringDate("Hibiscus", "Living Room")?.ToShortDateString()}");
        
        // Display the entire watering schedule
        plantScheduler.DisplaySchedule();
    }
}