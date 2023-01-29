using System;
using System.IO;

public class randomPrompt
{
    // only use as a test template, not the final
    private static readonly string[] prompts = {
        "1. What was the most memorable part of my day today?", "2. What emotions did I feel today and why?", "3. Could I have done anything different today to make my day better?", "4. What did I get done today?", "5. What goals did I accomplish or worked towards today?", "6. Did I help anyone today?  How?",
    };

    private static readonly Random promptGen = new Random();

    public static string Generator()
    {
        int index = promptGen.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
        return Console.ReadLine();
    }
}

public class Entry
{
    public string fileName = "Entry";
}
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Your Journal";
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("Welcome to your journal!\nPlease select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");

        Console.ReadLine();
    }
}
