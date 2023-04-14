using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgDelegates
{
    class Program
    {
        delegate double AverageDelegate(int x, int y, int z);

        static void Main(string[] args)
        {
            AverageDelegate average = delegate (int x, int y, int z)
            {
                int sum = x + y + z;

                return (double)sum / 3;
            };

            Console.WriteLine("Enter three numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Average: {0}", average(a, b, c));
        }
    }
}
