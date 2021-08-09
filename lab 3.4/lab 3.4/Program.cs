using System;

namespace lab_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы вычислить у = cos x + cos x^2 + cos x^3 + ... + cos x^n");            Console.WriteLine();
            Console.WriteLine("Введите предельное значение степени от 4(четырёх). (n):");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите значени (x):");
            uint x = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();

            double y = 0;
            for (uint i = 1; i < n; i++)
            {
                y = y + Math.Cos(x ^ i);
               
            }

            Console.WriteLine("cos x + cos x^2 + cos x^3 + ... + cos x^" + n + " = " + y);



        }
    }
}
