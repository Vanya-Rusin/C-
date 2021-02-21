using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b ^ c > b)
                Console.WriteLine("y=1");
            else if (b == a ^ a == c)
                Console.WriteLine("y=2");
            else if (b < a ^ c > a)
                Console.WriteLine("y=3");
            else if (c < a ^ b > a)
                Console.WriteLine("y=4");
            else
                Console.WriteLine("y=0");

        }
    }
}
