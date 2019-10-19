using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] nowaTablica = new int[tablica.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                nowaTablica[i] = tablica[i];
            }
            nowaTablica[3] = 10;

            foreach (var liczba in tablica)
            {
                Console.WriteLine(liczba + " ");
            }

            foreach (var liczba in nowaTablica)
            {
                Console.WriteLine(liczba + " ");
            }

        }
    }
}
