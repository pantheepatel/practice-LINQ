namespace practice_LINQ
{
    class O_
    {
        List<string> names = new List<string> { "John", "Jane", "Jack", "Jill" };
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void ExtraMethods()
        {
            Console.WriteLine(numbers.Append(10));
            Console.WriteLine(numbers.Prepend(0));
            var resultSequence = numbers.Zip(names, (n, name) => n + " - " + name);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
