using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tab1 = new int[3, 3];
            int[,] tab2 = new int[3, 3];
            int[,] tab3 = new int[3, 3];

            Random los = new Random();

            Console.WriteLine("Zadanie 5\n\n");

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = los.Next(0, 10);
                    if (i == j)
                        tab2[i, j] = 1;
                    else
                        tab2[i, j] = 0;
                }
            }

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write(tab2[i, j] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {

                    tab3[i, j] = tab1[i, j] + tab2[i, j];
                }
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write(tab3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}
