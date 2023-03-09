using System;
using System.IO;

public class OverGoal
{
    public void addGoal()
    {
        Console.WriteLine("What type of goal would you like to add?");
        string add = Console.ReadLine();

        if (add == "1"){
            Console.WriteLine("Please enter your new goal here: ");
            string newGoal1 = Console.ReadLine();
        }
    }
    
    public void RecordEvent()
    {

    }

    public void IsComplete()
    {
        Console.WriteLine("Congratulations!  You did it!  Keep going!");
    }
}

public class SimpleGoal : OverGoal
{

}

public class CheckGoal : OverGoal
{

}

public class EternalGoal : OverGoal
{

}

public class user
{
    public string username;

    public void score()
    {

    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your goal game!");
        Console.WriteLine("");
        Console.WriteLine("Your current score is: {score}");
        Console.WriteLine("");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Goal List");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int menuChoice = Convert.ToInt32(Console.ReadLine());

        if (menuChoice == 1){
            Console.WriteLine("The types of goals you can create are:");
            Thread.Sleep(1000);
            Console.WriteLine("1. Simple Goals");
            Thread.Sleep(1000);
            Console.WriteLine("2. Eternal Goals");
            Thread.Sleep(1000);
            Console.WriteLine("3. Checklist Goals");
        }
    }
}