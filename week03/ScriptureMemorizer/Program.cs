using System;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Juan", 3, 16);
        Scripture scripture = new Scripture(reference, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo unigénito");

        Console.WriteLine("Texto original:");
        Console.WriteLine(scripture.GetDisplayText());

        scripture.HideRandomWords(3);
        Console.WriteLine("\nDespués de ocultar palabras:");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("\n¿Está completamente oculto?: " + scripture.IsCompletelyHidden());
    }
}