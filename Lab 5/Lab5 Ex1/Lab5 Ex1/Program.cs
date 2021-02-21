using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n= ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("х= ");
            double x = Convert.ToDouble(Console.ReadLine());

            double Sum = Math.Pow(x+a,2);
            int i = 1;

            for (i = 1; i <= n + 1; i++) ;
                Sum = Math.Pow(Sum + a, 2);   
            
            Console.Write(Sum);
        }
}

    }

