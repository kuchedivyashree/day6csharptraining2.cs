using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class entrypoint
    {
        
        public static extern int GetMyNumber();
        public static void Main()
        {
            try
            {
                int number = GetMyNumber();
            }
            catch(EntryPointNotFoundException e)
            {
                Console.WriteLine("{ 0}:\n { 1}", e.GetType().Name, e.Message);
                Console.ReadLine();
            }
        }
    }
}
