namespace StudentSystem
{
    using System;

    using StudentSystem.Types;
    using System.Collections.Generic;
    internal class Test
    {
        internal static void Main(string[] args)
        {
            #region student instances
            var pesho = new Student("Pesho", "Goshov", "Peshov", "111-345-567", "Planet Mars, Curiosity", "+359 885", "pesho@nasa.gov", 4, Speciality.Physicist, University.SofiaUniversity, Faculty.Physics);

            var gosho = new Student("Gosho", "Peshov", "Goshov", "111-342-765", "Planet Earth, Chukotka, Russia", "+3592 82185", "gosho@chuk.ru", 3, Speciality.IT, University.SofiaUniversity, Faculty.Mathematics);
            #endregion

            #region toString
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ToString test: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(pesho);

            Console.Write(Environment.NewLine);

            Console.WriteLine(gosho);

            Console.WriteLine(new string('-', 50));
            #endregion

            #region equals
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Equals test: ");

            Console.ForegroundColor = ConsoleColor.White;
            var areEqual = object.Equals(pesho, gosho);

            Console.WriteLine(areEqual);

            Console.WriteLine(new string('-', 50));
            #endregion

            #region ==
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("== test: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(pesho == gosho);

            Console.WriteLine(new string('-', 50));
            #endregion

            #region !=
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!= test: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(pesho != gosho);

            Console.WriteLine(new string('-', 50));
            #endregion

            #region getHashCode
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("getHashCode test: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(pesho.GetHashCode() + " " + gosho.GetHashCode());

            Console.WriteLine(new string('-', 50));

            #endregion

            #region clone
            //clone
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Clone test: ");

            Console.ForegroundColor = ConsoleColor.White;

            pesho.TestRefProp = new List<int>() { 1, 2, 3 };

            var clone = pesho.Clone() as Student;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Clone toString: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(clone);

            // changed props
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Changing props: ");

            Console.ForegroundColor = ConsoleColor.White;

            clone.Address = "new address";

            Console.WriteLine(clone.Address);
            Console.WriteLine(pesho.Address);

            // test prop
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Changing the testing refference prop: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Join(", ", clone.TestRefProp));
            Console.WriteLine(string.Join(", ", pesho.TestRefProp));

            pesho.TestRefProp = new List<int>() { 1, 4, 532532 };

            Console.WriteLine(string.Join(", ", clone.TestRefProp));
            Console.WriteLine(string.Join(", ", pesho.TestRefProp));

            Console.WriteLine(new string('-', 50));
            #endregion
        }
    }
}
