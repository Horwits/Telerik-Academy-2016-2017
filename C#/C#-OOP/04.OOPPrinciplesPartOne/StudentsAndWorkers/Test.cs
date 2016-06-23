namespace StudentsAndWorkers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Ivaylo", "Avramov", 6),
                new Student("Nikolay", "Georgiev", 6),
                new Student("Ivan", "Minkov", 3),
                new Student("Peter", "Stoqnov", 4),
                new Student("Daniel", "Petrov", 6),
                new Student("Alexander", "Nikolov", 6),
                new Student("Peter", "Petrov", 6),
                new Student("Iva", "Ivanova", 6),
                new Student("Elena", "Petrova", 2),
                new Student("Stoqn", "Kenov", 5),
            };

            var sortedStudents = students
                                    .OrderBy(x => x.Grade);

            PrintCollectionToConsole(sortedStudents, "Sorted by grade.");

            Console.WriteLine(new string('-', 50));

            var workers = new List<Worker>()
            {
                new Worker("Peter", "Georgiev", 600M, 8),
                new Worker("Nikolay", "Avramov", 1600M, 10),
                new Worker("Ivan", "Minkov", 620M, 8),
                new Worker("Ivaylo", "Stoqnov", 800M, 8),
                new Worker("Daniel", "Alexandrov", 1200M, 8),
                new Worker("Alexander", "Petrov", 2600M, 10),
                new Worker("Georgi", "Petrov", 420M, 8),
                new Worker("Neli", "Ivanova", 600M, 8),
                new Worker("Elena", "Zafirova", 600M, 8),
                new Worker("Kristian", "Tanev", 200M, 4),
            };

            var sortedWorkers = workers
                                    .OrderByDescending(x => x.MoneyPerHour());

            PrintCollectionToConsole(sortedWorkers, "Sorted by money per hour.");

            Console.WriteLine(new string('-', 50));

            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            var orderedMerge = merged
                                .OrderBy(x => x.FirstName)
                                .ThenBy(x => x.LastName);

            PrintCollectionToConsole(orderedMerge, "Ordered by first and last name.");
        }

        private static void PrintCollectionToConsole(IEnumerable collection, string taskName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(taskName);

            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.Write(Environment.NewLine);
            }
        }
    }
}
