using System;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    public List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
    public void run()
    {
        DisplayStartingMessage();

        ShowCountDown(5);

        
        DisplayPrompt();

        ShowSpinner(10);
        Console.WriteLine("");

        for(int a = 0; a < GetDuration(); a+= 5)
        {
            DisplayQuestion();

            ShowSpinner(5);

        }
           
        
        Console.WriteLine("");
        DisplayEndingMessage();

        Thread.Sleep(5000);

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
         _prompts.Add("Think of a time when you stood up on behalf of someone else.");
         _prompts.Add("Think of a time when you did something hard.");
         _prompts.Add("Think of a time when you helped someone.");
         _prompts.Add("Think of a time when you did something truly selfless.");
         _prompts.Add("Think of a time when you were really proud of yourself.");
        

         //get a random prompt
         Random prompt = new Random();
         int randomIndex = prompt.Next(_prompts.Count);

         string randomPrompt = _prompts[randomIndex];

         return randomPrompt;

    }
    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        

        //get a random prompt
        Random question = new Random();
        int randomIndex = question.Next(_questions.Count);

        string randomquestion = _questions[randomIndex];

        return randomquestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}