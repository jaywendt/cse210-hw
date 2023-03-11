using System;
using System.IO;

public class OverGoal
{
    public void addGoal()
    {
        Console.WriteLine("What type of goal would you like to add?");
        string add = Console.ReadLine();

        if (add == "1"){
            Console.WriteLine("Please enter your new Simple Goal here: ");
            string newGoal1 = Console.ReadLine();
            Console.WriteLine("What is the name of your new goal? ");
            string newGoal1Name = Console.ReadLine();
            Console.WriteLine("Please enter a short description of your new goal: ");
            string newGoal1Desc = Console.ReadLine();
            Console.WriteLine("How many points do you want associated with this goal?");
            string newGoal1Points = Console.ReadLine();
        }

        else if (add == "2"){
            Console.WriteLine("Please enter your new Eternal Goal here: ");
            string newgoal2 = Console.ReadLine();
            Console.WriteLine("What is the name of your new goal? ");
            string newGoal2Name = Console.ReadLine();
            Console.WriteLine("Please enter a short description of your new goal: ");
            string newGoal2Desc = Console.ReadLine();
            Console.WriteLine("How many points do you want associated with this goal?");
            string newGoal2Points = Console.ReadLine();
        }

        else if (add == "3"){
            Console.WriteLine("Please enter your new Checklist Goal here: ");
            string newgoal3 = Console.ReadLine();
            Console.WriteLine("What is the name of your new goal? ");
            string newGoal3Name = Console.ReadLine();
            Console.WriteLine("Please enter a short description of your new goal: ");
            string newGoal3Desc = Console.ReadLine();
            Console.WriteLine("How many points do you want associated with this goal?");
            string newGoal3Points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus point score?");
            string newGoal3Times =  Console.ReadLine();
            Console.WriteLine("How many bonus points do you get for accomplishing it that many times?");
            string newGoal3Bonus = Console.ReadLine();
        }

        else {
            Console.WriteLine("That response does not work.  Please enter 1, 2, or 3.");
        }

    }
    

    public void IsComplete()
    {
        Console.WriteLine("Congratulations!  You did it!  Keep going!");
    }
}

public class List : OverGoal
{

}

public class SaveGoal : OverGoal
{

}

public class LoadGoal : OverGoal
{

}

public class RecordEvent : OverGoal
{

}

public class Score
{
    public int score;
}

class Program
{
    static void Main(string[] args)
    {
        Score userScore = new Score();
        
        Console.WriteLine("");
        Console.WriteLine("Welcome to your goal game!");
        Console.WriteLine("");
        Console.WriteLine("Your current score is:" + userScore);
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
            Thread.Sleep(2000);

            OverGoal act1 = new OverGoal();

            act1.addGoal();
        }

        else if (menuChoice == 2){

        }
        
        else if (menuChoice == 3){

        }

        else if (menuChoice == 4){

        }

        else if (menuChoice == 5){

        }

        else if (menuChoice == 6){
            Console.WriteLine("Thank you!");
            Thread.Sleep(3000);
            Console.WriteLine("Goodbye!");
            Console.Clear();
        }

        else {
            Console.WriteLine("That response doesn't work.  Please select again from the menu.");
            Console.Clear();
        }
    }
}