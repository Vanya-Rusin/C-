using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=");
            int y = Convert.ToInt32(Console.ReadLine());
            
            double s =  0.5 * a * b * Math.Sin(y) ;
            Console.WriteLine(s);


        }
    }
}
