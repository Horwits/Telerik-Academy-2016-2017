namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AnimalHierarchy.Models;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cats test:");

            Console.ForegroundColor = ConsoleColor.White;

            Animal kitten = new Kitten("Lady Gaga", 1);
            Console.WriteLine("{0} is {1}", kitten.Name, kitten.Sex);

            // kitten.Sex = Sex.Male;           //
            //// Console.WriteLine(kitten.Sex); //    uncomment to see

            Cat tomCat = new TomCat("Tom", 2);
            Console.WriteLine("{0} is {1}", tomCat.Name, tomCat.Sex);

            // tomCat.Sex = Sex.FeMale;         //
            //// Console.WriteLine(tomCat.Sex); //    uncomment to see

            var animals = new List<Animal>()
            {
                new Dog("Rex", 5, Sex.Male),

                new Frog("Froggy", 2, Sex.Other)
            };

            animals.Add(tomCat);
            animals.Add(kitten);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Animals test: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Average years:");

            Console.ForegroundColor = ConsoleColor.White;

            var averageAge = animals.Average(x => x.Age);
            Console.WriteLine(averageAge);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Produce sound:");

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
