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
            for (int g = 0; g < 16; g++)
            {
                Console.Write($"#");
            }

            Console.WriteLine();
            for (int x = 0; x <= 13; x++)
            {
                Console.Write($"#");
                for (int i = 1; i <= 14; i++)
                {
                    Console.Write($" ");
                }
                Console.Write($"#");
                Console.WriteLine();
            }


            for (int g = 0; g < 16; g++)
            {
                Console.Write($"#");
            }

        }
        /// <summary>
        /// Задание 3. Вывести на экран прямоугольник вида □,
        /// обрамленный символами (например, 16 на 16) и пустой внутри.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var_a();
            Console.Read();

        }
    }
}
