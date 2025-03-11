namespace practice_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Query QueryObj = new();
            // without linq
            QueryObj.WithoutLINQ();
            // there are 2 methods to write queries in LINQ/to use LINQ
            // 1. Query Syntax (SQL-like)
            QueryObj.WithLINQQuerySyntax();
            // 2. Method Syntax (Fluent API)
            QueryObj.WithLINQMethodSyntax();
        }
    }
}