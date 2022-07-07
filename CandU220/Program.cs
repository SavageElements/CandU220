using System;

namespace CandU220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            int X = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter another number");

            int Y = Convert.ToInt16(Console.ReadLine());

            Class220A.OperationONE(X, Y);


        }
    }
}
