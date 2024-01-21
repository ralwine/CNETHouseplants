using System;
public class Plant
{
    public string Name { get; set; }
    public DateTime WateringDate { get; set; }
    public string Location { get; set; }

    // Constructor to initialize a plant with a name, watering date, and location
    public Plant(string name, DateTime wateringDate, string location)
    {
        Name = name;
        WateringDate = wateringDate;
        Location = location;
    }
}