using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            double me1 = 45;
            double me2 = 50;
            double me3 = 51;
            double me4 = 66;
            double total = me1 + me2 + me3 + me4;
            double dozen = total / 12;
            double eggs = total % 12;
            Console.WriteLine(" A total of {0} eggs is equal {1} dozen and {2} eggs", total, dozen, eggs);
        }
    }
}
