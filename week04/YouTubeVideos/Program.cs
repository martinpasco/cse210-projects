using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1.Title = "POO en C#";
        video1.Author = "Shack Dev";
        video1.Length = 600;
        video1.AddComment(new Comment("Ana", "Muy buen video, gracias!"));
        video1.AddComment(new Comment("Luis", "¿Puedes hacer uno de herencia?"));
        video1.AddComment(new Comment("Marta", "Claro y conciso."));

        // Video 2
        Video video2 = new Video();
        video2.Title = "Interfaces en C#";
        video2.Author = "Shack Dev";
        video2.Length = 720;
        video2.AddComment(new Comment("Pedro", "Justo lo que necesitaba."));
        video2.AddComment(new Comment("Lucía", "Excelente explicación."));
        video2.AddComment(new Comment("Tomás", "Muy útil."));

        // Video 3
        Video video3 = new Video();
        video3.Title = "Encapsulación fácil";
        video3.Author = "Shack Dev";
        video3.Length = 500;
        video3.AddComment(new Comment("Sofía", "Me quedó clarísimo."));
        video3.AddComment(new Comment("Carlos", "Ahora sí entendí encapsulación."));
        video3.AddComment(new Comment("Vale", "Buen ritmo y ejemplos."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Mostrar todo
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
