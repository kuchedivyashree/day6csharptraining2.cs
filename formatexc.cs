using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class formatexc
    {
        public static void Main()
        {
            decimal price = 169.32m;
            Console.WriteLine("the cost is {0:Q2}.", price);
        }
    }
}
