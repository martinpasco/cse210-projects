using System;

public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine($" Date: {Date}");
        Console.WriteLine($" Question: {Prompt}");
        Console.WriteLine($" Answer: {Response}");
        Console.WriteLine("--------------------------------");
    }
}
