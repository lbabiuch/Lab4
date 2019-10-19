using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica =
                {
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 }
                };


            int[,] nowaTablica = new int[tablica.GetLength(0), tablica.GetLength(1)];

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                nowaTablica[i,j] = tablica[i,j];
                }
            }
            nowaTablica[3,3] = 10;

            foreach (var liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
            foreach (var liczba in nowaTablica)
            {
                Console.Write(liczba + " ");
            }

        }
    }
}
