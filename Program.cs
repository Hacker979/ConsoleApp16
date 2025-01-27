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
        /// <summary>
        /// Задание 2. Вывести на экран 4 горизонтальные строки,
        /// каждая из которых состоит из 7 символов,
        /// отделенных друг от друга пустыми строками.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var_a();
            Console.Read();

        }
    }
}
