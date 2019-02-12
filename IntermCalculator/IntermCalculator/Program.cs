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
            string choice1 = Console.ReadLine();
            if (choice1 == "m")
            {
            
                double num1 = 0;
                double num2 = 0;
                string operand;
                double ans = 0;

                Console.WriteLine("Please enter the first integer: ");
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();
                Console.WriteLine("Please enter the second integer: ");
                num2 = Double.Parse(Console.ReadLine());
                

                switch (operand)
                {
                    case "-":
                        ans = num1 - num2;
                        break;
                    case "+":
                        ans = num1 + num2;
                        break;
                    case "/":
                        ans = num1 / num2;
                        break;
                    case "*":
                        ans = num1 * num2;
                        break;
                }
                Console.WriteLine(num1 + " " + operand + " " + num2 + " " + "Your Answer is " + ans);
                Console.ReadLine();
            }
            else if (choice1 == "a")
            {

                double height = 0;
                double width = 0;
                double radius = 0;
                double circans = 0;
                double trians = 0;
                double recans = 0;


                Console.WriteLine("Circle, Triangle or Rectangle?");
                string choice2 = Console.ReadLine();

                if (choice2 == "Circle")
                {
                    Console.WriteLine("Enter Circle radius please");
                    radius = Double.Parse(Console.ReadLine());

                    circans = 3.142 * (radius * radius);
                    Console.WriteLine("The area of your Circle is " + circans);
                    Console.ReadLine();

                }
                else if (choice2 == "Triangle")
                {
                    Console.WriteLine("Enter Triangle Height");
                    height = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Triangle Width");
                    width = Double.Parse(Console.ReadLine());

                    trians = 0.5 * height * width;
                    Console.WriteLine("The area of your Triangle is " + trians);
                    Console.ReadLine();

                }
                else if (choice2 == "Rectangle")
                {
                    Console.WriteLine("Enter Rectangle Height");
                    height = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Rectangle Height");
                    width = Double.Parse(Console.ReadLine());

                    recans = height * width;
                    Console.WriteLine("The area of your Rectangle is " + recans);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("You think this is a game");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Help me, help you, pick an option");
                Console.ReadLine();
            }
        }
    }
}
