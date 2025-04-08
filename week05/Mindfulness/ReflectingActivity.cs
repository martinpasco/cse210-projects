public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() 
        : base("Reflection Activity", "This activity helps you reflect on strength and resilience.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new();
        Console.WriteLine("\n" + _prompts[rnd.Next(_prompts.Count)]);
        ShowSpinner(4);

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("\n" + _questions[rnd.Next(_questions.Count)]);
            ShowSpinner(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }
}
