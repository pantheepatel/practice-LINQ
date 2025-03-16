namespace practice_LINQ
{
    class O_Filtering
    {
        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
        public void MethodFiltering()
        {
            IEnumerable<int> Q1 = numbersList.Where(num => num > 5);
            var Q2 = Employee_Projection.GetEmployee_Projections().Where(emp => emp.Salary > 50000 && emp.FirstName == "hello").ToList();
            List<string> Q3 = dataSource.OfType<string>().ToList();
        }
        public void QueryFiltering()
        {
            IEnumerable<int> Q1 = from num in numbersList where num > 5 select num;
            var Q2 = from emp in Employee_Projection.GetEmployee_Projections() where emp.Salary > 50000 select emp;
            //var Q2 = from emp in Employee_Projection.GetEmployee_Projections() where emp.Salary > 50000 && emp.FirstName == "hello" select emp;
            var Q3 = (from str in dataSource where str is string select str).ToList();
            //var Q3 = (from str in dataSource.OfType<string>() select str).ToList();

        }
    }
}
