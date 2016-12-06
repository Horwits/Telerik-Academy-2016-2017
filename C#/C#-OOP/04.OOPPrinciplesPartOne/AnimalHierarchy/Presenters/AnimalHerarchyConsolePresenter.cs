namespace AnimalHierarchy.Presenters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AnimalHierarchy.Models;
    using AnimalHierarchy.Types;
    using AnimalHierarchy.Interfaces;

    public class AnimalHerarchyConsolePresenter : IAnimalHerarchyConsolePresenter
    {
        private static IAnimalHerarchyConsolePresenter presenter;

        private readonly IConsoleInputOutputProvider consoleInputOutputProvider;
        private readonly ICollection<IAnimal> animals;
        private AnimalHerarchyConsolePresenter()
        {
            this.animals = new List<IAnimal>();
            this.consoleInputOutputProvider = new ConsoleInputOutputProvider();
        }

        public static IAnimalHerarchyConsolePresenter Instance
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new AnimalHerarchyConsolePresenter();
                }

                return presenter;
            }
        }

        public void ShowAnimalsAbstraction(IAnimalFactory factory)
        {
            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.Yellow;
            this.consoleInputOutputProvider.WriteOutput("Cats test:");

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.White;

            var kitten = factory.GetKittyAnimal("Lady Gaga", 1);
            this.consoleInputOutputProvider.WriteOutput($"{kitten.Name} is {kitten.Sex}");

            // kitten.Sex = Sex.Male;           //
            //// this.consoleInputOutputProvider.WriteOutput(kitten.Sex); //    uncomment to see

            var tomCat = factory.GetTomCatAnimal("Tom", 2);
            this.consoleInputOutputProvider.WriteOutput($"{tomCat.Name} is  {tomCat.Sex}");

            // tomCat.Sex = Sex.FeMale;         //
            //// this.consoleInputOutputProvider.WriteOutput(tomCat.Sex); //    uncomment to see

            this.AddAnimals(kitten);
            this.AddAnimals(tomCat);

            var dog = factory.GetDogAnimal("Rex", 5, Sex.Male);
            this.AddAnimals(dog);

            var frog = factory.GetFrogAnimal("Froggy", 2, Sex.Other);
            this.AddAnimals(frog);

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.Yellow;
            this.consoleInputOutputProvider.WriteOutput("Animals test: ");

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.Cyan;
            this.consoleInputOutputProvider.WriteOutput("Average years:");

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.White;

            var averageAge = animals.Average(x => x.Age);
            this.consoleInputOutputProvider.WriteOutput(averageAge.ToString());

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.Cyan;
            this.consoleInputOutputProvider.WriteOutput("Produce sound:");

            this.consoleInputOutputProvider.ForegroundColor = ConsoleColor.White;

            foreach (var animal in animals)
            {
                this.consoleInputOutputProvider.WriteOutput(animal.ProduceSound());
            }
        }

        private void AddAnimals(IAnimal animal)
        {
            this.animals.Add(animal);
        }
    }
}