namespace practice_LINQ
{
    class O_Partitioning
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void SkipMethod()
        {
            var skip = numbers.Skip(5);
            var skipWhile = numbers.SkipWhile(n => n < 5);
        }
        public void SkipQuery()
        {
            var skip = (from n in numbers select n).Skip(5);
            var skipWhile = (from n in numbers select n).SkipWhile(n => n < 5);
        }
        public void TakeMethod()
        {
            var take = numbers.Take(5);
            var takeWhile = numbers.TakeWhile(n => n < 5);
        }
        public void TakeQuery()
        {
            var take = (from n in numbers select n).Take(5);
            var takeWhile = (from n in numbers select n).TakeWhile(n => n < 5);
        }
    }
}
