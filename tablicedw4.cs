using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablicedwuwymiarowe4
{

    class tablicedw4

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy (liczba nieparzysta):");
            int size = int.Parse(Console.ReadLine());

            int[,] array = new int[size, size];

            Console.WriteLine("Podaj liczbę początkową dla liczb nieparzystych:");
            int startOdd = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę początkową dla liczb parzystych:");
            int startEven = int.Parse(Console.ReadLine());

            int middle = size / 2;
            int numOdd = startOdd;
            int numEven = startEven;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int distanceFromMiddle = Math.Abs(i - middle) + Math.Abs(j - middle);

                    if (distanceFromMiddle == 0)
                    {
                        array[i, j] = 0;
                    }
                    else if (distanceFromMiddle % 2 == 1)
                    {
                        array[i, j] = numOdd;
                        numOdd += 2;
                    }
                    else
                    {
                        array[i, j] = numEven;
                        numEven += 2;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j],-3} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}