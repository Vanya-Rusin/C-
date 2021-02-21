using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 456;
            int k;

            k = X % 10;
            X = X / 10;



            while (X > 0)
            {
                k = Math.Min(k, X % 10);
                X = X / 10;

            }
            Console.WriteLine(k);











        }
    }
}
