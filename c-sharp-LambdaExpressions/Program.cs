using c_sharp_LambdaExpressions;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {1, 2, 3,
                             4, 5, 6, 7, 8, 9, 10};
        //  square(numbers);

        ////////
        ///

        /*
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
        */
        /////
        ///
       
            List < Person > list = new List<Person>() {
            new Person("salim", 22, "Male", "sohar"),
            new Person("khalid", 23, "Male", "sohar"),
            new Person("mnar", 27, "female", "sohar"),
            new Person("ali", 20, "Male", "muscat"),
            new Person("shagufta", 25, "Female", "muscat"),
            new Person("Aliya", 19, "Female", "sohar"),
            new Person("Fariha", 30, "Female", "muscat"),
            new Person("Farzana", 35, "Female", "salalah"),
            new Person("Muqeet", 20, "Male", "sohar"),
            new Person("Sehar", 18, "Female", "muscat")};

        List<Person> Persons = list.Where(x => x.Age > 25).ToList();
        PrintPersonsData(Persons);


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

    static void PrintPersonsData(List<Person> persons)
    {
        foreach (Person person in persons)
        {
            Console.WriteLine(person.Name);
        }
        
    }


}