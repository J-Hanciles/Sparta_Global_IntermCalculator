using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'm' for math calculator, otherwise type 'a' for area calculator");
            char choice1 = (char)Console.Read();
            if (choice1 == (char)'m')
            {

                int num1 = 0;
                int num2 = 0;
               
            }
            else if (choice1 == (char)'a')
            {
                Console.WriteLine('a');
            }
            else
            {
                Console.WriteLine("Help me, help you, pick an option");
            }
        }
    }
}
