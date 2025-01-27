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
            Console.WriteLine("вариант a");
            for (int x = 0; x <= 3; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            
        }
        static void var_b()
        {
            Console.WriteLine("вариант б");
            int i = 40;
            for (int x = 0 ; x <= 3; x++)
            {
                for  (int y = 0 ; y <= 9; y++)
                {
                    i++;
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

        }
        static void var_v()
        {
            Console.WriteLine("вариант в");
            for (int x = 0; x <= 4; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write($"5 ");
                }
                Console.WriteLine();
            }

        }
        static void var_g()
        {
            Console.WriteLine("вариант г");
            for (int x = 4; x >= 0; x--)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write($"1 ");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Задание 1. Напечатать числа в виде следующей таблицы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var_a();
            var_b();
            var_v();
            var_g();


            Console.Read();

        }
    }
}
