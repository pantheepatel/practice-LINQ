namespace practice_LINQ
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class O_Ordering
    {
        List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
        List<Person> people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Age = 30 },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 25 },
                new Person { FirstName = "Joe", LastName = "Bloggs", Age = 30 },
            };
        public void OrderingUsingMethodSyntax()
        {
            var Q1 = intList.OrderBy(i => i);
            var Q2=people.OrderBy(p => p.LastName).ToList();
            var Q3 = people
                    .OrderBy(p => p.LastName)
                    .ThenBy(p => p.FirstName)
                    .ThenByDescending(p => p.Age);
            var Q4=people.OrderBy(p => p.LastName).Reverse().ToList();
        }
        public void OrderingUsingQuerySyntax()
        {
            var Q1 = (from i in intList orderby i select i).ToList();
            //var Q1 = (from i in intList orderby i ascending select i).ToList();
            var Q2 = (from p in people orderby p.LastName select p).ToList();
            var Q3 = (from p in people orderby p.LastName ascending, p.FirstName, p.Age descending select p).ToList();
            var Q4 = (from p in people orderby p.LastName select p).Reverse().ToList();
        }
    }
}
