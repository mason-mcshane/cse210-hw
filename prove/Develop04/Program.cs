using System;
// Gave the program a cleaner organization by adding in a Landing page that essentially
// acts as the new program.cs file for the assignment.
class Program
{
    static void Main(string[] args)
    {
        Landing landing = new Landing();

        landing.Main();
    }
}