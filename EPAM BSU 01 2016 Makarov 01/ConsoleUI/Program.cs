using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewtonMethod.Logic.SqrtN(125, -3, 00.1));
            Console.WriteLine(Math.Pow(125 , (double) -1/3));
            Console.WriteLine(NewtonMethod.Logic.SqrtN(0, 100, 00.1));
            Console.WriteLine(Math.Pow(0, (double)1 / 100));
            Console.WriteLine(NewtonMethod.Logic.SqrtN(-125, 3, 00.1));
            Console.WriteLine(NewtonMethod.Logic.SqrtN(100, 5, 0.0001));
            Console.WriteLine(Math.Pow(100, (double) 1/5));
            Console.ReadKey();
        }
    }
}
