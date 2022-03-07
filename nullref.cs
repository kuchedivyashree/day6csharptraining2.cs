using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class nullref
    {
        public static void Main(string[] args) 
        {
            int value = Int32.Parse(args[0]);
            List<String> names;
            if (value > 0)
                names = new List<string>();
            names.Add("major major major");
            Console.ReadLine();
        }

    }
}
