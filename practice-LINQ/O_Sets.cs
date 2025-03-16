using System.Linq;
namespace practice_LINQ
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class O_Sets
    {

        int[] sequence1 = { 1, 2, 3, 4, 5 };
        int[] sequence2 = { 4, 5, 6, 7, 8 };
        string[] str1 = { "Panthee", "Patel" };
        string[] str2 = { "patel" };

        List<Student> AllStudents = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
                new Student {ID = 106, Name = "Santosh"},
            };
        List<Student> Class6Students = new List<Student>()
            {
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 105, Name = "Pranaya"},
            };

        public void setsExampleMethod()
        {
            var distinct = sequence1.Distinct();
            Console.WriteLine("Distinct: " + string.Join(", ", distinct));
            var union = sequence1.Union(sequence2);
            Console.WriteLine("Union: " + string.Join(", ", union));
            var intersect = sequence1.Intersect(sequence2);
            Console.WriteLine("Intersect: " + string.Join(", ", intersect));
            var except = str1.Except(str2, StringComparer.OrdinalIgnoreCase).ToList(); // to ignorecase and compare without it
            Console.WriteLine("Except: " + string.Join(", ", except));
            var concatenated = sequence1.Concat(sequence2);
            Console.WriteLine("Concat: " + string.Join(", ", concatenated));
            bool areEqual = sequence1.SequenceEqual(sequence2);
            Console.WriteLine($"SequenceEqual: {areEqual}");

            var Q1 = AllStudents.Select(stu => stu.Name).Except(Class6Students.Select(stu => stu.Name)).ToList();
        }
        public void setsExampleQuery()
        {
            var distinct = (from n1 in sequence1 select n1).Distinct();
            Console.WriteLine("Distinct: " + string.Join(", ", distinct));
            var except = (from n1 in sequence1 select n1).Except(sequence2).ToList();
            Console.WriteLine("Except: " + string.Join(", ", except));
            var intersect = (from n1 in sequence1 select n1).Intersect(sequence2).ToList();
            var concat = (from n1 in sequence1 select n1).Concat(sequence2).ToList();

            var Q1 = (from stu in AllStudents select stu.Name).Except(Class6Students.Select(stu => stu.Name)).ToList();

        }
    }
}
