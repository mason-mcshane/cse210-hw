using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string scripture = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        string[] words = scripture.Split(' ');

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Press Enter to reveal a few random words or type 'quit' to exit.");

        while (true)
        {
            Console.ReadLine(); // Wait for user input

            // Randomly select a few words to hide
            int numWordsToHide = 3; // You can adjust this number
            Random random = new Random();
            var hiddenIndices = Enumerable.Range(0, words.Length)
                .OrderBy(x => random.Next())
                .Take(numWordsToHide);

            // Replace selected words with empty lines
            for (int i = 0; i < words.Length; i++)
            {
                if (hiddenIndices.Contains(i))
                    words[i] = new string(' ', words[i].Length);
            }

            // Display the modified scripture
            Console.Clear();
            Console.WriteLine(string.Join(" ", words));

            // Check if all words are hidden
            if (words.All(w => string.IsNullOrWhiteSpace(w)))
            {
                Console.WriteLine("\nCongratulations! You've hidden all the words.");
                break;
            }
        }
    }
}
