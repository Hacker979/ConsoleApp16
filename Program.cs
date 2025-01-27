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
            for (int x = 0; x <= 7; x++)
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.Write($" ");
                }
                Console.Write($"#");
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Задание 4. Вывести на экран наклонную линию (\) из 8 символов.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var_a();
            Console.Read();

        }
    }
}
