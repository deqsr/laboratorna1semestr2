using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Randomizer.NumberGenerator;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            Random rnd = new Random();
            NumGen[] arr = new NumGen[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new NumGen((r) => numberGenerator.GenerateNum(rnd));
            }

            int[] values = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                values[i] = arr[i](rnd);
            }

            ArrayDelegate arrayDelegate = a =>
            {
                double sum = values.Sum();

                return sum / a.Length;
            };

            Console.WriteLine("Generated numbers:");
            Array.ForEach(values, Console.WriteLine);
            Console.WriteLine("Average: {0}", arrayDelegate(arr));
            Console.ReadKey();
        }
    }
}