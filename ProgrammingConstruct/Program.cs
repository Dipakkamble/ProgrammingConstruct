using ProgrammingConstruct.IfandElseStatement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the programming construct");
            Console.WriteLine("Checking two numbers equality");
            IfElseProblem1.Equalnum();
            Console.WriteLine("Checking number is even or odd");
            IfElseProblem2.EvenOdd();
            Console.ReadLine();
        }
    }
}
