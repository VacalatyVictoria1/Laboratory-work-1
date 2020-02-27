using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первая_попытка_С1
    // Реализовать функцию вычисления произведения двух целых чисел.
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber, Result;
            Console.WriteLine("Enter the first number: " );
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            Result = (FirstNumber * SecondNumber);
            Console.WriteLine("Result - " + Result);
        }
    }
}
