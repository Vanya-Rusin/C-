using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("номер n-го елемента =");
            int n = Convert.ToInt32(Console.ReadLine());
            double x = 0;
            double x1 = 9;
            double y;
            for (int i = 2; i < n;)
            {
                i++;
                y = x;
                x = 2*y + 3 * i-2;
            }
            Console.WriteLine(x);

        }
    }
}
