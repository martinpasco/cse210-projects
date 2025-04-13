using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== Eternal Quest Menu =====");
            Console.WriteLine("1. Ver puntuación");
            Console.WriteLine("2. Listar metas");
            Console.WriteLine("3. Crear nueva meta");
            Console.WriteLine("4. Registrar evento");
            Console.WriteLine("5. Guardar metas");
            Console.WriteLine("6. Cargar metas");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    CreateGoalFromInput(goalManager);
                    break;
                case "4":
                    goalManager.ListGoals();
                    Console.Write("Ingrese el número de la meta completada: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        goalManager.RecordEvent(index - 1);
                    }
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void CreateGoalFromInput(GoalManager manager)
    {
        Console.WriteLine("\n¿Qué tipo de meta quieres crear?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eterna");
        Console.WriteLine("3. Checklist");
        Console.Write("Seleccione una opción: ");
        string option = Console.ReadLine();

        Console.Write("Nombre de la meta: ");
        string name = Console.ReadLine();

        Console.Write("Descripción: ");
        string description = Console.ReadLine();

        Console.Write("Puntos por completar: ");
        int points = int.Parse(Console.ReadLine());

        switch (option)
        {
            case "1":
                manager.CreateGoal("simple", name, description, points);
                break;
            case "2":
                manager.CreateGoal("eternal", name, description, points);
                break;
            case "3":
                Console.Write("Cantidad de veces necesarias: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Puntos extra al completar: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.CreateGoal("checklist", name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Tipo no válido.");
                break;
        }
    }
}
