internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {1, 2, 3,
                             4, 5, 6, 7, 8, 9, 10};
      //  square(numbers);

        ////////
        ///
        Func<int,int> func = (x) => x * x;
        foreach (int x in numbers)
        {
            Console.Write(func(x)+" ");
        }
        Console.WriteLine();
        ////////
        ///
        MathOperation add1 = Add;
        Console.WriteLine(Add(2,4));

        MathOperation multiply1 = multiply;
        Console.WriteLine(multiply(2, 4));


    }

    static void square(List<int> numbers)
    {
         

        var square = numbers.Select(x => x * x);

        // foreach loop to display squares
        Console.Write("Squares : ");
        foreach (var value in square)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
    public delegate int MathOperation(int a,int b);

    static int Add(int a, int b) => a + b;
   static int multiply(int a,int b) => a *b;
     
    
}