// PlantScheduler.cs
using System;
using System.Collections.Generic;

public class PlantScheduler
{
    // Dictionary to store plant names and their corresponding watering dates
    private Dictionary<string, DateTime> schedule;

    // Constructor to initialize the scheduler
    public PlantScheduler()
    {
        schedule = new Dictionary<string, DateTime>();
    }

    // Method to add a new plant to the schedule
    public void AddPlant(string name, DateTime wateringDate)
    {
        schedule[name] = wateringDate;
    }

    // Method to get the watering date for a specific plant
    public DateTime? GetWateringDate(string name)
    {
        // Try to get the watering date for the specified plant
        if (schedule.TryGetValue(name, out DateTime date))
        {
            return date;
        }
        // Return null if the plant is not found in the schedule
        return null;
    }

    // Method to display the entire watering schedule
    public void DisplaySchedule()
    {
        // Iterate through each plant in the schedule and display its name and watering date
        Console.WriteLine("Plant Watering Schedule:");
        foreach (var entry in schedule)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value.ToShortDateString()}");
        }
    }
}
