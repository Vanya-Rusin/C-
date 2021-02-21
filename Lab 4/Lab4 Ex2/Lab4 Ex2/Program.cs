using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= 3 && a <= 9 && a >= b && a <= c)
            {
                Console.WriteLine("Належить");
            }
            else
            {
                Console.WriteLine("Не Належить");
            }
        }

    }
}

