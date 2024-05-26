using System;
using System.Net.Mail;

class Program
// Not sure if this counts as excceing the core requirements, but I simplified the code with the case function as opposed to if else.
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        bool isDone = false;

        while (!isDone)
        {

            Console.WriteLine("Please Select from the list of choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display your entry");
            Console.WriteLine("3. Save your entry");
            Console.WriteLine("4. Load entries");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            
            string Userinput = Console.ReadLine();

            switch(Userinput)
            {
                case "1":
                    Entry entry = new Entry();
                    theJournal.AddEntry(entry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    theJournal.SaveToFile();
                    break;
                case "4":
                    theJournal.LoadFromFile();
                    break;
                case "5":
                    isDone = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }    
        }
    }
}