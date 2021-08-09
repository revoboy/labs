using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("enter pcs in $");
            string exchange = Console.ReadLine();
            exchange = exchange.Replace(".", ",");
            decimal ex = Convert.ToDecimal(exchange);


            for (int pcs = 1; pcs <= 20; pcs++)
            {
               
                Console.WriteLine(pcs + "$" + " =\t" + pcs * ex + " UAH") ;
            }
            
            
        }

    }
}
