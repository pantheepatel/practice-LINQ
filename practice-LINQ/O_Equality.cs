namespace practice_LINQ
{
    class O_Equality
    {
        List<string> names = new List<string> { "John", "Jane", "Jack", "Jill" };
        List<string> names2 = new List<string> { "John", "Jane", "Jack", "Jill" };
        public void SequenceEqual()
        {
            bool isEqualMethod = names.SequenceEqual(new List<string> { "John", "Jane", "Jack", "Jill" });
            bool isEqualQuery = (from name in names2 select name).SequenceEqual(names2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(isEqualMethod);

        }
    }
}
