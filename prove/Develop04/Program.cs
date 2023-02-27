using System;

class Base
{
    public string activity;

    public void welcome()
    {
        Console.WriteLine("Welcome to your " + activity);
    }

    public void getReady()
    {
        Console.WriteLine("Excellent!  Get ready!");

        Thread.Sleep(5000);
    }

    public void finish()
    {
        Console.WriteLine("Well done!  You've successfully finished this exercise.");
    }
}

class Breathing : Base
{
    public void introBreath()
    {
        Console.WriteLine("This activity is here to aid in your relaxation by helping you control your in and out breathing.");
    }


}

class Reflection : Base
{
    public void introReflect()
    {
        Console.WriteLine("This activity is here to help you reflect on times when you have shown great strength and resilience.  This exercise will help you see the power you have and how apply it.");
    }

    public void randomPrompt()
    {
        Random rnd = new Random();
        
        string[] prompts = {"Think of a time when you pushed yourself beyond your limits.", "Think of a time when someone needed you and you came through", "Think of a time when you did something truly selfless", "Think of a time when you were the answer to someone's prayers", "Think of a time when you made someone else smile", "Think of a time when you gave true service to someone in need", "Think of a time when you tried something new and liked it"};
        int index = rnd.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }

    public void randomQuestion()
    {
        Random rnd = new Random();

        string[] quest = {"How did you feel after that?", "How was this experience meaningful for you?", "What made this situation occur?", "Have you ever done anything like this before?", "What made this experience different than other times when maybe you weren't as successful?", "How did you feel when it was over?", "What did you learn from this experience that you could apply to other situations?", "What did you learn about yourself from all of this?", "How can you keep this experience in mind for the future?"};
        int index = rnd.Next(quest.Length);
        Console.WriteLine(quest[index]);
    }

}

class Listing : Base
{
    public void introList()
    {
        Console.WriteLine("This activity is here to help you reflect on the many good things in your life by having you list as many things as you can in a certain area of your life.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your wellness app!  Please select one of the following:");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");
        Console.WriteLine("4. Quit");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1){
            Base act1 = new Base();
            act1.activity = "Breathing Activity!";

            act1.welcome();

            Thread.Sleep(3000);

            Breathing breathe1 = new Breathing();
            breathe1.introBreath();

            Thread.Sleep(3000);

            act1.getReady();

        }
        else if (choice == 2){
            Base act2 = new Base();
            act2.activity = "Reflection Activity!";

            act2.welcome();

            Thread.Sleep(3000);

            Reflection reflec1 = new Reflection();
            reflec1.introReflect();

            Thread.Sleep(3000);

            Console.WriteLine("How long would you like this session to last?");
            int refTimer = Convert.ToInt32(Console.ReadLine());

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(refTimer);

            act2.getReady();

            Thread.Sleep(5000);

            reflec1.randomPrompt();

            Thread.Sleep(6000);

            reflec1.randomQuestion();

            Thread.Sleep(refTimer);

            Console.WriteLine("Time's up!");

            Thread.Sleep(4000);

            act2.finish();

        }
        else if (choice == 3){
            Base act3 = new Base();
            act3.activity = "Listing Activity!";

            act3.welcome();

            Thread.Sleep(3000);

        }
        else if (choice == 4){
            Console.WriteLine("Thank you for joining us!");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("That's not an acceptable command.  Please try again.");
        }
    }
}