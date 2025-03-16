namespace practice_LINQ
{
    class O_Elements
    {
        public void ElementMethod()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int first = numbers.First();
            int last = numbers.Last();
            int firstEven = numbers.First(n => n % 2 == 0);
            int lastEven = numbers.Last(n => n % 2 == 0);
            int single = numbers.Single(n => n == 5);
            int singleEven = numbers.Single(n => n % 2 == 0);
            int elementAt = numbers.ElementAt(3);
            int elementAtOrDefault = numbers.ElementAtOrDefault(10);
            int defaultElement = numbers.DefaultIfEmpty().FirstOrDefault();
            int defaultElement2 = numbers.DefaultIfEmpty(0).FirstOrDefault();
        }
        public void ElementQuery()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int first = (from n in numbers select n).First();
            int last = (from n in numbers select n).Last();
            int firstEven = (from n in numbers where n % 2 == 0 select n).First();
            int lastEven = (from n in numbers where n % 2 == 0 select n).Last();
            int single = (from n in numbers where n == 5 select n).Single();
            int singleEven = (from n in numbers where n % 2 == 0 select n).Single();
            int elementAt = (from n in numbers select n).ElementAt(3);
            int elementAtOrDefault = (from n in numbers select n).ElementAtOrDefault(10);
            int defaultElement = (from n in numbers select n).DefaultIfEmpty().FirstOrDefault();
            int defaultElement2 = (from n in numbers select n).DefaultIfEmpty(0).FirstOrDefault();
        }
    }
}
