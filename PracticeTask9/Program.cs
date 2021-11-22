using System;

namespace PracticeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Введите размер массива А");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите размер массива В");
            N = int.Parse(Console.ReadLine());
            int[] B = new int[N];
            for (int j = 0; j < N; j++)
            {
                B[j] = int.Parse(Console.ReadLine());
            }
            int[] C;
            int k = 0;
            while (k < N)
            {

            }
        }
    }
}
