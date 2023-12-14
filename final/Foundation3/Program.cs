using System;
class Program
{
    static void Main()
    {
        Lecture lectureEvent = new Lecture(
            "C# Lecture",
            "Come learn how to program with classes in C#!",
            "2023-12-15",
            "18:00",
            new Address("555 Mikan Drive", "Rexburg", "ID", "83440"),
            "John Allen",
            50
        );

        Reception receptionEvent = new Reception(
            "Networking Reception",
            "Networking for Networkers - Come make friends in the same industry you're in.",
            "2023-12-20",
            "19:30",
            new Address("556 Mikan Drive", "Rexburg", "ID", "83440"),
            "rsvp@byui.edu"
        );

        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Summer BBQ",
            "Casual barbecue event, bring your family!",
            "2023-12-25",
            "15:00",
            new Address("557 Mikan Drive", "Rexburg", "ID", "83440"),
            "Sunny with a high of 75°F"
        );

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine(outdoorEvent.ShortDescription());
    }
}
