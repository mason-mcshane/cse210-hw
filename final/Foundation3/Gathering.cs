using System;

public class Gathering : Event
{
    private string _weatherForecast; 
    private string _eventType = "Picnic Gathering";    

    public Gathering(string weatherForecast, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

   public override void GetFullDetails()
    {
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"Title: {_title}");  
        Console.WriteLine($"Description: {_description}");  
        Console.WriteLine($"Date: {_date}");  
        Console.WriteLine($"Time: {_time}");  
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"The weather is {_weatherForecast}");
    }

      public override void GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}