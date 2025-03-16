namespace practice_LINQ
{
    class O_Aggregate
    {
        int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };

        public void AggregateUsingMethodSyntax()
        {
            var Q1 = intNumbers.Sum();
            var Q11 = intNumbers.Sum(num =>
            {
                if (num > 50)
                    return num;
                else
                    return 0;
            });
            var Q12 = intNumbers.Where(i => i > 50).Sum();
            var Q13 = Employee_Projection.GetEmployee_Projections().Sum(emp => emp.Salary);
            var Q2 = intNumbers.Min();
            var Q3 = intNumbers.Max();
            var Q4 = intNumbers.Average();
            var Q5 = intNumbers.Count();
            var Q6 = intNumbers.Aggregate((a, b) => a + b);
            var Q7 = intNumbers.Aggregate(10, (a, b) => a + b); // seed value 10; ie. 10 + 10 + 30 + 50 + 40 + 60 + 20 + 70 + 90 + 80 + 100
            var Q71 = Employee_Projection.GetEmployee_Projections().Aggregate<Employee_Projection, int>(0, (totalSalary, emp) => totalSalary += emp.Salary);
        }
        public void AggregateUsingQuerySyntax()
        {
            var Q1 = (from i in intNumbers select i).Sum();
            var Q11 = (from i in intNumbers select i).Sum(num =>
            {
                if (num > 50)
                    return num;
                else
                    return 0;
            });
            var Q12 = (from i in intNumbers where i > 50 select i).Sum();
            var Q13 = (from emp in Employee_Projection.GetEmployee_Projections() select emp.Salary).Sum();
            var Q2 = (from i in intNumbers select i).Min();
            var Q3 = (from i in intNumbers select i).Max();
            var Q4 = (from i in intNumbers select i).Average();
            var Q5 = (from i in intNumbers select i).Count();
            var Q6 = (from i in intNumbers select i).Aggregate((a, b) => a + b);
            var Q7 = (from i in intNumbers select i).Aggregate(10, (a, b) => a + b);
        }
    }
}
