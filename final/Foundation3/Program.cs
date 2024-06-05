using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();
        Address address1 = new Address("No 4 Pop Street", "London", "Brasilia", "Brazil");
        Address address2 = new Address("No 6 Eke Street", "Lagos", "Lagos", "Nigeria");
        Address address3 = new Address("No 2 Pop Street", "London", "Brasilia", "Brazil");
 
        Reception reception = new Reception("m.mcshane@live.com", "Smash Bros Game Night", "Join us for a fun an exciting game night that will stregthen the bonds of friendship with one another!", "July 29, 2024", "6:00 PM", address1);
        Lecture lecture = new Lecture("Python Lecture", 1000, "Programming 101", "Come learn what it is like to code and all about the fun things you can create!.", "Dec 13, 2024", "3:00 PM", address2);
        Gathering gathering = new Gathering("Sunny", "Family Picnic day", "A wonderul time to catch up with our amazing family", "August 14, 2024", "11:00 AM", address3);

        Event[] events = new Event[] {lecture, reception, gathering};

        foreach (var ev in events)
        {
            ev.GetFullDetails();
            Console.WriteLine();
            ev.GetStandardDetails();
            Console.WriteLine();
            ev.GetShortDescription();
            Console.WriteLine("--------------------------------------------");
        }
    }
}