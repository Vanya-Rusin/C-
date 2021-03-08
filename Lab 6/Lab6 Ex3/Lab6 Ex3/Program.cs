using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Ex3
{
    class Program
    {
        static void Generate(double[] vector)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                Console.Write("{0}-ше значення вектора=  ", i + 1);
                vector[i] = double.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args )
        {
           // Console.Write("N = ");
            //int n = int.Parse(Console.ReadLine());
            double[] x = new double[3], y = new double[3];
            Console.WriteLine("Перший вектор");
            Generate(x);
            Console.WriteLine("Другий вектор");
            Generate(y);
            double result = 0;
            for (int i = 0; i < 3; ++i)
                result += (x[1] * y[2] - x[2] * y[1]) - (x[0] * y[2] - x[2] * y[0]) + (x[0] * y[1] - x[1] * y[0]);
            Console.WriteLine("Векторний добуток= {0}", result);




        }
    } 
}




        


       
    

