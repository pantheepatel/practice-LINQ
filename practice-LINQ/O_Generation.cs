namespace practice_LINQ
{
    class O_Generation
    {
        public void RangeMethod()
        {
            var range = Enumerable.Range(1, 10);
            var repeat = Enumerable.Repeat("Hello", 5);
            var empty = Enumerable.Empty<int>();
        }
        public void RangeQuery()
        {
            var range = from n in Enumerable.Range(1, 10) select n;
            var repeat = from r in Enumerable.Repeat("Hello", 5) select r;
        }
    }
}
