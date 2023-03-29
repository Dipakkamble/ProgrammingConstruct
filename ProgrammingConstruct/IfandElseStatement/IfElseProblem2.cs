using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct.IfandElseStatement
{
    internal class IfElseProblem2
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
