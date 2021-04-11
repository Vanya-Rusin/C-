using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// клас з методами розширення
static class MatrixExt
{
    // метод розширення для отримання кількості рядків матриці
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }

    // метод розширення для отримання кількості стовпців матриці
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }
}

class Program
{
    // метод для отримання матриці з консолі
    static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Кількість рядків матриці {0}: ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Кількість стовпців матриці {0}: ", name);
        var m = int.Parse(Console.ReadLine());

        var matrix = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    // метод для виводу матриці 
    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    // метод для множення матриць
    static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        if (matrixA.ColumnsCount() != matrixB.RowsCount())
        {
            throw new Exception("Множення не можливе! Кількість стовпців першої матриці не рівно кількості рядків другої матриці.");
        }

        var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

        for (var i = 0; i < matrixA.RowsCount(); i++)
        {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.ColumnsCount(); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Програма для знаходження добутку двох матриць");

        var a = GetMatrixFromConsole("A");
        var b = GetMatrixFromConsole("B");

        Console.WriteLine("Матриця A:");
        PrintMatrix(a);

        Console.WriteLine("Матриця B:");
        PrintMatrix(b);

        var result = MatrixMultiplication(a, b);
        Console.WriteLine("Добуток матриць:");
        PrintMatrix(result);

        Console.ReadLine();
    }
}



