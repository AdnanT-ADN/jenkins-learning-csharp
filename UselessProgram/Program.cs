using System;


namespace UsefulProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"5 + 3 = {MathsOperations.MathFunctions.Add(5, 3)}");
            Console.WriteLine($"5 - 3 = {MathsOperations.MathFunctions.Subtract(5, 3)}");
            Console.WriteLine($"5 * 3 = {MathsOperations.MathFunctions.Multiply(5, 3)}");
            Console.WriteLine($"5 / 3 = {MathsOperations.MathFunctions.Divide(5, 3)}");
        }
    }

}