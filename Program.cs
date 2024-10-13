using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк и столбцов двумерного массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < m; b++)
                {
                    if (i <= b + 1)
                    {
                        mas[i, b] = 1;
                    }
                    else
                    {
                        mas[i, b] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < m; b++)
                {
                    Console.Write(mas[i, b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
