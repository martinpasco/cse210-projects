using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal(string type, string name, string description, int points, int targetCount = 0, int bonus = 0)
    {
        switch (type.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"¡Evento registrado! Has ganado {points} puntos.");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\n===== Tus Metas =====");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nPuntaje actual: {_score} puntos");
    }

    public void SaveGoals(string filename = "goals.txt")
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Metas guardadas exitosamente.");
    }

    public void LoadGoals(string filename = "goals.txt")
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Archivo no encontrado.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }
        Console.WriteLine("Metas cargadas exitosamente.");
    }
}
