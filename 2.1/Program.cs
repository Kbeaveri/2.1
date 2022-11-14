using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Строчек");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            int min = 0, max= 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] lol = str.Split(' ');
                if (i == 0)
                {
                    min = Convert.ToInt32(lol[0]);
                    max = Convert.ToInt32(lol[0]);
                }
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(lol[j]);
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            int[,] b = new int[n, m];
            for (int i = 0;i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if ((i+j)%2 == 1)
                    {
                        b[i, j] = arr[i, j]*max;
                    }
                    else
                    {
                        b[i,j] = arr[i, j]*min;   
                    }
                }
            }
            Console.WriteLine("Посде преобразований у на получилась такая матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
