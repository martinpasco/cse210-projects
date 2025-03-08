using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Name?  ");
        string name = Console.ReadLine();
        Console.WriteLine("What is your Lastname?");
        string Lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {name}, {name} {Lastname}");
    }
}