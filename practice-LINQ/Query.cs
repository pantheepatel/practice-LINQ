using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practice_LINQ
{
    class Query
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> evenNumbers = new List<int>();

        public void WithoutLINQ()
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
        public void WithLINQQuerySyntax()
        {
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            Console.WriteLine(evenNumbers);
        }
        public void WithLINQMethodSyntax()
        {
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            Console.WriteLine(evenNumbers);
        }
        public void DeferredExecution()
        {
            var query = numbers.Where(n => n > 2); // Query is not executed yet
            numbers.Add(6); // Modifying source collection
            foreach (var n in query) // Now, query executes
            {
                Console.WriteLine(n);
            }
        }
        public void ImmediateExecution()
        {
            var results = numbers.Where(n => n > 2).ToList(); // Query executes immediately
            numbers.Add(6); // Modifying source won't affect `results`
            Console.WriteLine(string.Join(", ", results)); // Output: 3, 4, 5
        }
        public void LambdaExp()
        {
            Func<int, int> square = x => x * x;  // Single parameter, single expression
            Func<int, int, int> add = (a, b) => a + b;  // Multiple parameters

            Console.WriteLine("Square: " + square(2));
            Console.WriteLine("Add: " + add(2, 3));
        }
        public void ExpressionLINQ()
        {
            Expression<Func<int, bool>> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven);
        }
        public void ParallelLINQ()
        {
            List<int> numbers = Enumerable.Range(1, 1000000).ToList();
            var evenNumbers = numbers.AsParallel().Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Total Evens: " + evenNumbers.Count);
        }
    }
}
