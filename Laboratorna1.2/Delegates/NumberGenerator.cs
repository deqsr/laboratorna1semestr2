using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public class NumberGenerator
    {
        public delegate int NumGen(Random rnd);
        public delegate double ArrayDelegate(NumGen[] arr);

        public int GenerateNum(Random rnd)
        {
            return rnd.Next(1, 101);
        }
    }
}