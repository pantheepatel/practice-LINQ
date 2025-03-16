using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_LINQ
{
    class O_Quantifiers
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public void QuantifiersMethod()
        {
            bool Q1 = numbers.All(i => i > 5);
            bool Q2 = numbers.Any(i => i > 5);
            bool Q21 = numbers.Any(); // list contains any element, if blank then false
            bool Q3 = numbers.Contains(5);
            bool Q4 = numbers.Contains(15);
        }
        public void QuantifiersQuery()
        {
            bool Q1 = (from i in numbers select i).All(i => i > 5);
            bool Q2 = (from i in numbers select i).Any(i => i > 5);
            bool Q3 = (from i in numbers select i).Contains(5);
            bool Q4 = (from i in numbers select i).Contains(15);
        }
    }
}
