using System;

namespace lab3._6
{
    class Program
    {
        public static int Main()
        {
            Console.Write("Для того, чтобы выяснить n! = введите значение n: \t\t НЕ БОЛЬШЕ 10!");
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                
                factorial *= i;
                if (i == n)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                }
            }

            Console.Write(" = {0}", factorial);
            Console.ReadKey();
            return 0;
        }
    }    }
