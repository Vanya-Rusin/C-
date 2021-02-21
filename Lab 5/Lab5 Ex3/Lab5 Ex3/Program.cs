using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double x, e, a;
            Console.Write("Введіть x: ");
            str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.Write("Введіть точність e: ");
            str = Console.ReadLine();
            e = Convert.ToDouble(str);
            Console.Write("Введіть a: ");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);

            double n = 1;
            double sum = 0;
            double y = Math.Abs(Math.Pow((x * Math.Log(a)),n));

            while (y > e)
            {
                sum = Math.Abs(Math.Pow((x * Math.Log(a)), n));
                n += 1;

                if (n == x)
                {
                    break;
                }
            }
            sum += 2;

            Console.WriteLine(sum);




        }
    }
}
