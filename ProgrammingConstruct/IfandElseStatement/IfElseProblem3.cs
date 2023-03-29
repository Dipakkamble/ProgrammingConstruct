using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct.IfandElseStatement
{
    internal class IfElseProblem3
    {
        public static void VotingEligibility()
        {
            Console.WriteLine("Enter the Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are Eligible For Voting");
            }
            else
            {
                Console.WriteLine("You are Not Eligible");
            }
        }
    }
}
