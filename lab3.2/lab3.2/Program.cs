using System;

namespace lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int b = 1; b <= 20; b++)
            {
                Decimal g = Convert.ToDecimal(b);
                if (b == 1)
                {
                    continue;
                }

                Console.WriteLine("Цена за " + b + " товара(ов) -\t" + b * 20.4 + "грн");
                
            }




        }
    }
}
