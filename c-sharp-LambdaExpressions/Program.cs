internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {1, 2, 3,
                             4, 5, 6, 7, 8, 9, 10};

        var square = numbers.Select(x => x * x);

        // foreach loop to display squares
        Console.Write("Squares : ");
        foreach (var value in square)
        {
            Console.Write( value+" ");
        }
        Console.WriteLine();
    }
}