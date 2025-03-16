using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry(prompt, response));
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n📜 Reading...:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($" Journal saving in  '{filename}'.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2]));
                }
            }
            Console.WriteLine($" Loading '{filename}'.");
        }
        else
        {
            Console.WriteLine("File not find.");
        }
    }
}
