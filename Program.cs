using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            int a = 3;
            int b = 7;
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int c = 7;
            int d = 3;
            int diff = c - d;
            Console.WriteLine(diff);

            //Multiplication
            int e = 3;
            int f = 7;
            int prod = e * f;
            Console.WriteLine(prod);

            //Division
            int g = 17;
            int h = 4;
            double quotient = g / h;
            int remainder = g % h;
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            Console.WriteLine($"{g} / {h} is {quotient} remainder {remainder}");


            Console.ReadLine();

        }
    }
}
