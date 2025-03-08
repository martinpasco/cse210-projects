using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is ypur avegaje in percent");
        int answer = int.Parse(Console.ReadLine());

        if (answer <= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (answer > 90)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (answer <= 80)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (answer > 80)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else if (answer <= 70)
        {
            Console.WriteLine("Your letter grade is F");
        }
        else
        {
            Console.WriteLine("Wrong Number");
        }

        Console.WriteLine($"Your grade is : {answer}");
        if (answer >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You need More dedication, not passed!");
        }
    }
}