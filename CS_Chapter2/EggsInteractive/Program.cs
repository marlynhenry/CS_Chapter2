using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double me1 = Convert.ToDouble(Console.ReadLine());
            double me2 = Convert.ToDouble(Console.ReadLine());
            double me3 = Convert.ToDouble(Console.ReadLine());
            double me4 = Convert.ToDouble(Console.ReadLine());
            double total = me1 + me2 + me3 + me4;
            double dozen = total / 12;
            double eggs = total % 12;
            Console.WriteLine(" A total of {0} eggs is equal {1} dozen and {2} eggs", total, dozen, eggs);
        }
    }
}
