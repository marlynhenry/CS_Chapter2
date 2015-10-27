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
            double length = 1;
            double width = 1;
            double area = (length * width);
            double price = 2.25;
            double cost = area * price/9;
            Console.WriteLine("The price of the carpeting is {0}", (cost.ToString("C"))); 
        }
    }
}
