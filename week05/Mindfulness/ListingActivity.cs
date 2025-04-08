public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on the good things in your life.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new();
        Console.WriteLine("\n" + _prompts[rnd.Next(_prompts.Count)]);
        Console.WriteLine("You may begin listing items in:");
        ShowCountDown(5);

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
