using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Ex2
{
    class Program
    {

        static void Main(string[] args,)
        {
            Console.Write("count of elements:   ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];




            for (int i = 1; i < a.Length; i++)
            {
                a[i] = (2 * i) * Math.Cos(i) / Math.Pow(i, 2);
            }

            Console.WriteLine("вивід масиву: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
           

            for (int i = 1; i < a.Length; i++)
            {
                
                if (a[i] < 0)
                {
                    int sumv += Math.Pow(a[i], 2);
                }
                else
                { int sumd += Math.Pow(a[i], 2); }
                int z = 0;
               
                if (sumv < sumd)
                {
                    Console.WriteLine(z = -1);
                }
                else
                {
                    Console.WriteLine(z = 1);
                }
            }







        } 
    }
}
  
    

