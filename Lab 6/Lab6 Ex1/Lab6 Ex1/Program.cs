using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Ex1
{
    class Program
    {
      
            public static void Main(string[] args)
            {
                Random rand = new Random();
                Console.Write("Введіть n: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                int min = int.MinValue;
                for (int x = 0; x < arr.Length; x++)
                {

                    arr[x] = rand.Next(-5, 15);
                    Console.Write(arr[x] + ",");

                     min = arr.Min();
                    
                }
                Console.WriteLine("min = " + min);



        }
        }


}
    

