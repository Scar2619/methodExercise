using System;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your favorite activity.");
            var activity = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("Tell us your favorite music!");
            var music = Console.ReadLine();



            Console.WriteLine($"Hi, my name is {name}! I love {activity} and {music} music. My favorite animal is a {animal}.");
        }
    }
}

