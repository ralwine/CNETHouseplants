using System;
using System.Collections.Generic;
using System.Linq;

public class PlantScheduler
{
    // List to store plants
    private List<Plant> plants;

    // Constructor to initialize the scheduler
    public PlantScheduler()
    {
        plants = new List<Plant>();
    }

    // Method to add a new plant to the schedule
    public void AddPlant(string name, DateTime wateringDate, string location)
    {
        var plant = new Plant(name, wateringDate, location);
        plants.Add(plant);
    }

    // Method to get the watering date for a specific plant and location
    public DateTime? GetWateringDate(string name, string location)
    {
        // Try to get the watering date for the specified plant and location
        var plant = plants.FirstOrDefault(p => p.Name == name && p.Location == location);
        return plant?.WateringDate;
    }

    // Method to display the entire watering schedule
    public void DisplaySchedule()
    {
        // Iterate through each plant in the schedule and display its name, location, and watering date
        Console.WriteLine("Plant Watering Schedule:");
        foreach (var plant in plants)
        {
            Console.WriteLine($"{plant.Name} in {plant.Location}: {plant.WateringDate.ToShortDateString()}");
        }
    }
}