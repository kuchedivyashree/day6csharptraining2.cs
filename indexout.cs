using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class indexout
    {
        public static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= ar.Length; i++)
                Console.WriteLine(ar[i]);
            Console.ReadLine();

        }
    }
}
