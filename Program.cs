// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create an instance of the PlantScheduler class
        var plantScheduler = new PlantScheduler();

        // Add plants and their watering dates to the schedule
        plantScheduler.AddPlant("Snake Plant", new DateTime(2024, 01, 15));
        plantScheduler.AddPlant("Peace Lily", new DateTime(2024, 01, 20));

        // Display the watering date for specific plants
        Console.WriteLine($"Watering date for Snake Plant: {plantScheduler.GetWateringDate("Snake Plant")?.ToShortDateString()}");
        Console.WriteLine($"Watering date for Peace Lily: {plantScheduler.GetWateringDate("Peace Lily")?.ToShortDateString()}");

        // Display the entire watering schedule
        plantScheduler.DisplaySchedule();
    }
}