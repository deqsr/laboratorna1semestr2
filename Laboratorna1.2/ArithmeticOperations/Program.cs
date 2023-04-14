using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticOperations
{
    class Program
    {
        delegate void ArithmeticOperation(int a, int b);

        static void Main(string[] args)
        {
            ArithmeticOperation Add = (a, b) => Console.WriteLine("Result: {0}", a + b);
            ArithmeticOperation Sub = (a, b) => Console.WriteLine("Result: {0}", a - b);
            ArithmeticOperation Mul = (a, b) => Console.WriteLine("Result: {0}", a * b);
            ArithmeticOperation Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: division by zero");
                }
                else
                {
                    Console.WriteLine("Result: {0}", (double)a / b);
                }
            };

            Console.WriteLine("Enter the first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an arithmetic operation (+, -, *, /):");
            string aithmeticoperation = Console.ReadLine();

            switch (aithmeticoperation)
            {
                case "+":
                    Add(x, y);
                    break;

                case "-":
                    Sub(x, y);
                    break;

                case "*":
                    Mul(x, y);
                    break;

                case "/":
                    Div(x, y);
                    break;

            }
        }
    }
}