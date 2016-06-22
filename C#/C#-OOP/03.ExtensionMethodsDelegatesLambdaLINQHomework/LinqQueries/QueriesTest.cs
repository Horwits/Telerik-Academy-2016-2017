namespace LinqQueries
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Models.School;

    public static class QueriesTest
    {
        // Problem 3. First before last
        public static IEnumerable FindStudentsWhoseFirstNameIsBeforeItsLastName(IList<Student> students)
        {
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;

            return result;
        }

        // Problem 4. Age range
        public static IEnumerable FindAllStudentsBetween18And24(IList<Student> students)
        {
            var result = from student in students
                         where (student.Age >= 18 && student.Age <= 24)
                         select student.FirstName + " " + student.LastName;

            return result;
        }

        // Problem 5. Order students
        public static IEnumerable OrderStudentsByNameLambda(IList<Student> students)
        {
            var result = students
                            .OrderBy(st => st.FirstName)
                            .ThenBy(st => st.LastName);

            return result;
        }

        public static IEnumerable OrderStudentsByNameLinq(IList<Student> students)
        {
            var result = from student in students
                         orderby student.FirstName, student.LastName
                         select student;

            return result;
        }

        // Problem 6. Divisible by 7 and 3
        public static IEnumerable ExtractAllDivisibleBy7And3(this int[] numbers)
        {
            var result = numbers.Where(n => n % 7 == 0 && n % 3 == 0);

            return result;
        }

        public static IEnumerable ExtractAllDivisibleBy7And3Linq(this int[] numbers)
        {
            var result = from num in numbers
                         where num % 7 == 0 && num % 3 == 0
                         select num;

            return result;
        }

        // Problem 9. Student groups
        public static IEnumerable GetAllStudentsFromSpecificGroupOrdered(IList<Student> students)
        {
            var result = from student in students
                         orderby student.FirstName, student.LastName
                         where student.Group.GroupNumber == 2
                         select student;

            return result;
        }

        // Problem 10. Student groups extensions - implement
        public static IEnumerable GetAllStudentsFromSpecificGroupOrderedEXTENSIONS(IList<Student> students)
        {
            var result = students
                            .OrderBy(st => st.FirstName)
                            .ThenBy(st => st.LastName)
                            .Where(st => st.Group.GroupNumber == 2);

            return result;
        }

        // Problem 11. Extract students by email
        public static IEnumerable ExtractStudentsByEmail(IList<Student> students)
        {
            var result = students
                            .Where(st => st.EMail.Contains("abv.bg"));

            return result;
        }

        // Problem 12. Extract students by phone
        public static IEnumerable ExtractStudentsBySofiaPhoneCode(IList<Student> students)
        {
            var result = students
                            .Where(st => st.Telephone.Contains("02/"));

            return result;
        }

        // Problem 13. Extract students by marks
        public static IEnumerable ExtractStudentsByMark(IList<Student> students)
        {
            var withMark = from stud in students
                           where stud.Marks.Contains(6)
                           select new
                           {
                               StudentName = stud.FirstName + " " + stud.LastName,
                               Marks = stud.Marks
                           };

            var result = new List<string>();

            foreach (var student in withMark)
            {
                result.Add(string.Format("{0}: {1}", student.StudentName, string.Join(", ", student.Marks)));
            }

            return result;
        }

        // Problem 14. Extract students with two marks
        public static IEnumerable ExtractStudentsWithTwoMarks(IList<Student> students, uint mark)
        {
            var result = students
                            .Where(st => st.Marks.Count == mark);
            return result;
        }

        // Problem 15. Extract marks
        public static IEnumerable ExtractStudentMarksByFacultyNumber(IList<Student> students)
        {
            var result = students
                            .Where(st => st.FacultyNumber % 100 == 6)
                            .Select(st => st.Marks)
                            .Select(m => string.Join(" ", m))
                            .ToList();

            return result;
        }

        // Problem 16.* Groups
        public static IEnumerable GroupByDepartment(IList<Student> students)
        {
            var groups = new List<Group>()
            {
                new Group(1 , "Mathematics"),
            };

            var extractByDep = from stud in students
                               join g in groups on stud.Group.GroupNumber equals g.GroupNumber
                               where stud.Group.GroupNumber == 1
                               select new
                               {
                                   FullName = stud.FirstName + " " + stud.LastName,
                                   g.DepartmentName
                               };

            return extractByDep;
        }

        // Problem 17. Longest string
        public static string ExtractMaxLengthOfStringInArray(string[] strings)
        {
            //var max = strings
            //    .OrderByDescending(s => s.Length)
            //    .ToArray()[0]
            //    .Length;

            var max = (from s in strings
                       orderby s.Length descending
                       select s)
                            .ToArray()[0];

            return max;
        }

        // Problem 18. Grouped by GroupNumber
        public static IEnumerable GroupByGroupsLinq(List<Student> students)
        {
            var groups = from stud in students
                         group stud by stud.Group.GroupNumber;

            var result = new List<string>();
            foreach (var group in groups)
            {
                result.Add(string.Format("group {0}:{1}{2}", group.ElementAt(0).Group.GroupNumber, Environment.NewLine, string.Join(", ", group)));
            }

            return result;
        }

        // Problem 19. Grouped by GroupName extensions
        public static IEnumerable GroupByGroupNumberExtensions(List<Student> students)
        {
            var groups = students
                            .GroupBy(x => x.Group.GroupNumber);

            var result = new List<string>();
            foreach (var group in groups)
            {
                result.Add(string.Format("group {0}:{1}{2}", group.ElementAt(0).Group.GroupNumber, Environment.NewLine, string.Join("\n\r", group)));
            }

            return result;
        }

        internal static void Main(string[] args)
        {
            #region working list
            var students = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Pesho",
                    LastName = "Petrov",
                    Age = 21,
                    EMail = "asdf@abv.bg",
                    Telephone = "0722/995-995-559",
                    FacultyNumber = 11406,
                    Group = new Group(1, "Literature"),
                },

                new Student()
                {
                    FirstName = "Strahil",
                    LastName = "Popov",
                    Age = 12,
                    EMail = "strahil@abv.bg",
                    Telephone = "02/559-995-559",
                    FacultyNumber = 11102,
                    Group = new Group(2, "Mathematics"),
                },

                new Student()
                {
                    FirstName = "Avram",
                    LastName = "Popov",
                    Age = 18,
                    EMail = "avram@abv.bg",
                    Telephone = "032/123-455-559",
                    FacultyNumber = 10006,
                    Group = new Group(1, "Mathematics"),
                },

                new Student()
                {
                    FirstName = "Asq",
                    LastName = "Ivanova",
                    Age = 25,
                    EMail = "asdf@hotmail.com",
                    Telephone = "02/132-995-559",
                    FacultyNumber = 12205,
                    Group = new Group(2, "Physics"),
                },

                new Student()
                {
                    FirstName = "Angel",
                    LastName = "Ivanov",
                    Age = 23,
                    EMail = "asdf@mail.bg",
                    Telephone = "02/995-000-559",
                    FacultyNumber = 55406,
                    Group = new Group(1, "Mathematics"),
                },

                new Student()
                {
                    FirstName = "Georgi",
                    LastName = "Angelov",
                    Age = 35,
                    EMail = "lsfc@abv.bg",
                    Telephone = "02/551-005-559",
                    FacultyNumber = 12315,
                    Group = new Group(2, "Programming"),
                }
            };

            var random = new Random();
            var mark = (uint)random.Next(2, 6);
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mark = (uint)random.Next(2, 7);
                    students[i].AddMark(mark);
                }
            }

            students.Add(new Student()
            {
                FirstName = "Mihail",
                LastName = "Angelkov",
                Age = 35,
                EMail = "gg@abv.bg",
                Telephone = "012/051-105-359",
                Group = new Group(2, "Programming"),
            });

            students[students.Count - 1].AddMark(5);
            students[students.Count - 1].AddMark(6);
            #endregion

            #region students
            var firstNameBeforeLast = FindStudentsWhoseFirstNameIsBeforeItsLastName(students);
            PrintCollectionToConsole(firstNameBeforeLast, "Problem 3. First before last");

            Console.WriteLine(new string('-', 50));

            var allBetweenAge = FindAllStudentsBetween18And24(students);
            PrintCollectionToConsole(allBetweenAge, "Problem 4. Age range");

            Console.WriteLine(new string('-', 50));

            var orderStudents = OrderStudentsByNameLambda(students);
            //// var orderStudents = OrderStudentsByNameLinq(students); // comment previous row and decomment this one to see the functionallity
            PrintCollectionToConsole(orderStudents, "Problem 5. Order students");

            Console.WriteLine(new string('-', 50));

            var selectedByGroupNum = GetAllStudentsFromSpecificGroupOrdered(students);
            PrintCollectionToConsole(selectedByGroupNum, "Problem 9. Student groups");

            Console.WriteLine(new string('-', 50));

            var selectedByGroupNumEXTENSIONS = GetAllStudentsFromSpecificGroupOrderedEXTENSIONS(students);
            PrintCollectionToConsole(selectedByGroupNum, "Problem 10. Student groups extensions");

            Console.WriteLine(new string('-', 50));

            var extractedByEmail = ExtractStudentsByEmail(students);
            PrintCollectionToConsole(extractedByEmail, "Problem 11. Extract students by email");

            Console.WriteLine(new string('-', 50));

            var extractedByPhone = ExtractStudentsBySofiaPhoneCode(students);
            PrintCollectionToConsole(extractedByPhone, "Problem 12. Extract students by phone");

            Console.WriteLine(new string('-', 50));

            var extractByMark = ExtractStudentsByMark(students);
            PrintCollectionToConsole(extractByMark, "Problem 13. Extract students by marks");

            Console.WriteLine(new string('-', 50));

            var studentsWithTwoMarks = ExtractStudentsWithTwoMarks(students, 2);
            PrintCollectionToConsole(studentsWithTwoMarks, "Problem 14. Extract students with two marks");

            Console.WriteLine(new string('-', 50));

            var studentsMarks = ExtractStudentMarksByFacultyNumber(students);
            PrintCollectionToConsole(studentsMarks, "Problem 15. Extract marks");

            Console.WriteLine(new string('-', 50));

            var groupedByDepartment = GroupByDepartment(students);
            PrintCollectionToConsole(groupedByDepartment, "Problem 16.* Groups");

            Console.WriteLine(new string('-', 50));

            var groupedByGroupsNumber = GroupByGroupsLinq(students);
            PrintCollectionToConsole(groupedByGroupsNumber, "Problem 18. Grouped by GroupNumber");

            Console.WriteLine(new string('-', 50));

            var groupedByGroupNumber = GroupByGroupNumberExtensions(students);
            PrintCollectionToConsole(groupedByGroupNumber, "Problem 19. Grouped by GroupName extensions");

            Console.WriteLine(new string('-', 50));

            #endregion

            #region strings
            var workingStringsArray = new[]
            {
                "alabala",
                "pesho",
                "adsf",
                "rakiqibiraivodkairom"
            };

            var max = ExtractMaxLengthOfStringInArray(workingStringsArray);
            PrintResultOnConsole(max, "Problem 17. Longest string");

            Console.WriteLine(new string('-', 50));
            #endregion

            #region ints
            var workingIntArray = new[]
            {
                21, 5, 3, 45, 28, 49, 63
            };

            //var divBySevenAndThree = ExtractAllDivisibleBy7And3(workingIntArray);
            ////PrintCollectionToConsole(divBySevenAndThree, "Problem 6. Divisible by 7 and 3");

            var divBySevenAndThree = ExtractAllDivisibleBy7And3Linq(workingIntArray);
            PrintCollectionToConsole(divBySevenAndThree, "Problem 6. Divisible by 7 and 3");

            Console.WriteLine(new string('-', 50));

            // TODO: Problem 20.* Infinite convergent series
            #endregion
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

        private static void PrintResultOnConsole<T>(T result, string taskName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(taskName);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(result);
            Console.Write(Environment.NewLine);
        }
    }
}
