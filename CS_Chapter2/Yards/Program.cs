using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 25;
            double width = 42;
            double area = (length * width);
            double cost = 116.66;
            Console.WriteLine("The price of the carpeting is {0}", (cost.ToString("C"))); 
        }
    }
}
