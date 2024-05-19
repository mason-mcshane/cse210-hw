using System;

public class Landing
{
    public void Main()
    {
        string userResponse = "";

        while (userResponse != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Begin Breathing activity");
            Console.WriteLine("2. Begin Reflecting activity");
            Console.WriteLine("3. Begin Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Type in a number to start a mindful activity: ");
            userResponse = Console.ReadLine();
            
            if (userResponse == "1")
            {
                // Begin Breathing Activity
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);
                breathingActivity.run();
            }

            else if(userResponse == "2")
            {
                // Begin Reflecting Activity
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10);
                reflectingActivity.run();
            }

            else if(userResponse == "3")
            {
               // Begin Listing Activity
               ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10);
               listingActivity.Run();
            }

            else if(userResponse == "4")
            {
                // End the file
                Console.WriteLine("\nThanks for using the program! ");
            }

            else
            {
                //handle errors
                Console.WriteLine("\nInvalid option entered. Please try again. ");
            }
        }
    }
}