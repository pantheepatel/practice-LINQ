using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_LINQ
{
    public class Student2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public static List<Student2> GetStudentList()
        {
            return new List<Student2>()
            {
                new Student2 { ID = 1001, Name = "Preety", Gender = "Female", Barnch = "CSE", Age = 20 },
                new Student2 { ID = 1002, Name = "Snurag", Gender = "Male", Barnch = "ETC", Age = 21  },
                new Student2 { ID = 1003, Name = "Pranaya", Gender = "Male", Barnch = "CSE", Age = 21  },
                new Student2 { ID = 1004, Name = "Anurag", Gender = "Male", Barnch = "CSE", Age = 20  },
                new Student2 { ID = 1005, Name = "Hina", Gender = "Female", Barnch = "ETC", Age = 20 },
                new Student2 { ID = 1006, Name = "Priyanka", Gender = "Female", Barnch = "CSE", Age = 21 },
                new Student2 { ID = 1007, Name = "santosh", Gender = "Male", Barnch = "CSE", Age = 22  },
                new Student2 { ID = 1008, Name = "Tina", Gender = "Female", Barnch = "CSE", Age = 20  },
                new Student2 { ID = 1009, Name = "Celina", Gender = "Female", Barnch = "ETC", Age = 22 },
                new Student2 { ID = 1010, Name = "Sambit", Gender = "Male",Barnch = "ETC", Age = 21 }
            };
        }
    }
    class O_Grouping
    {
        public void GroupingMethod()
        {
            var students = Student2.GetStudentList();
            var groupedResult = students.GroupBy(s => s.Barnch);
            foreach (var group in groupedResult)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t" + student.Name);
                }
            }
        }
        public void GroupingQuery()
        {
            var students = Student2.GetStudentList();
            var groupedResult = from s in students
                                group s by s.Barnch into g
                                select new { Branch = g.Key, Students = g };
            foreach (var group in groupedResult)
            {
                Console.WriteLine(group.Branch);
                foreach (var student in group.Students)
                {
                    Console.WriteLine("\t" + student.Name);
                }
            }
        }
        public void TolookUpMethod()
        {
            var students = Student2.GetStudentList();
            var lookupResult = students.ToLookup(s => s.Barnch);
            foreach (var group in lookupResult)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t" + student.Name);
                }
            }
        }
        public void ToLookUpQuery()
        {
            var students = Student2.GetStudentList();
            var lookupResult = (from s in students
                                group s by s.Barnch into g
                                select new { Branch = g.Key, Students = g }).ToLookup(g => g.Branch, g => g.Students);
            foreach (var group in lookupResult)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group.SelectMany(g => g))
                {
                    Console.WriteLine("\t" + student.Name);
                }
            }
        }
    }
}
