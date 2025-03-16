namespace practice_LINQ
{
    public class Employee_Projection
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public static List<Employee_Projection> GetEmployee_Projections()
        {
            List<Employee_Projection> Employee_Projections = new List<Employee_Projection>
            {
                new Employee_Projection {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee_Projection {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee_Projection {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee_Projection {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee_Projection {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee_Projection {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };

            return Employee_Projections;
        }

        public void QueryProjectionSelect()
        {
            // Select
            List<Employee_Projection> Q1 = (from emp in Employee_Projection.GetEmployee_Projections() select emp).ToList();
            List<int> Q2 = (from emp in Employee_Projection.GetEmployee_Projections() select emp.ID).ToList();
            // anonymous type, use var instead of List<ClassName> and blank after new instead of specifying ClassName()
            // can perform calculations on fields
            var Q3 = (from emp in Employee_Projection.GetEmployee_Projections()
                      select new
                      {
                          FirstName = emp.FirstName,
                          LastName = emp.LastName,
                          Annual_Salary = emp.Salary * 12
                      }).ToList();
            // to select data with Index Value
            var Q4 = (from emp in Employee_Projection.GetEmployee_Projections().Select((value, index) => new { value, index })
                      select new
                      {
                          indexPosition = emp.index,
                          fullName = emp.value.FirstName + " " + emp.value.LastName
                      }).ToList();

            // SelectMany
            List<string> names = new List<string>() { "panthee", "patel" };
            IEnumerable<char> Q5 = from s in names from ch in s select ch;
            IEnumerable<char> Q6 = from emp in Employee_Projection.GetEmployee_Projections() from fname in emp.FirstName select fname;
            //Console.WriteLine(Q1.Select(emp => emp.ToString()));
        }
        public void MethodProjectionSelect()
        {
            // Select
            IEnumerable<Employee_Projection> Q1 = Employee_Projection.GetEmployee_Projections().ToList();
            IEnumerable<int> Q2 = Employee_Projection.GetEmployee_Projections().Select(emp => emp.ID);
            IEnumerable<Employee_Projection> Q3 = Employee_Projection.GetEmployee_Projections().
                Select(emp => new Employee_Projection()
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary
                });
            var Q4 = Employee_Projection.GetEmployee_Projections().Select((emp, index) => new
            {
                indexPosition = index,
                fullName = emp.FirstName + " " + emp.LastName
            }).ToList();

            // SelectMany
            List<string> names = new List<string>() { "Panthee", "patel" };
            IEnumerable<char> Q5 = names.SelectMany(c => c);
            List<char> Q6 = Employee_Projection.GetEmployee_Projections().SelectMany(emp => emp.FirstName).ToList();
            //Console.WriteLine(Q1.Select(emp => emp.ToString()));
        }
    }
}
