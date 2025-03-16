using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\n Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n📝 {prompt}");
                    Console.Write("Your answer: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    Console.WriteLine("Saving.");
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Name file: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Name file : ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    Console.WriteLine("See you soon!");
                    return;

                default:
                    Console.WriteLine(" Wrong option, Try again.");
                    break;
            }
        }
    }
}