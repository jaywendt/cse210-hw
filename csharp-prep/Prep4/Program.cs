using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Please enter your numbers here. Type 0 once finished.  ");

            string enter = Console.ReadLine();
            number = int.Parse(enter);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int listnumber in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of this list is {sum}.");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}.");

        int max = numbers[0];

        foreach (int listnumber in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}.");

    }
}