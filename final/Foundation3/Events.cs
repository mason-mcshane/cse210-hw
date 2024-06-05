 using System;

    public class Event
    {
        protected string _title; 
        protected string _description;
        protected string _time;
        protected string _date;
        protected Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _time = time;
            _date = date; 
            _address = address;
        }

        public virtual void GetStandardDetails()
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Descrition: {_description}");
            Console.WriteLine($"Time: {_time}  Date: {_date}");
            Console.WriteLine($"Address: {_address.GetAddress()}");
        }

        public virtual void GetFullDetails()
        {
            Console.WriteLine("FULL DETAILS");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Descrition: {_description}");
            Console.WriteLine($"Time: {_time}  Date: {_date}");
            Console.WriteLine($"Address: {_address.GetAddress()}");
        }

        public virtual void GetShortDescription()
        {
            Console.WriteLine("Event Type: ");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Date: {_date}");
        }
    }