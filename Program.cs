using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void var_a()
        {
            for (int x = 0; x <= 3; x++)
            {
                for (int i = 1; i <= 7; i++)
                {
                    Console.Write($"#");
                }
                Console.WriteLine("\n");
            }
            
        }

        static void Main(string[] args)
        {

            var_a();
            Console.Read();

        }
    }
}
