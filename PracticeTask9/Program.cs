using System;

namespace PracticeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива А: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите элемент массива А: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите размер массива В: ");
            N = int.Parse(Console.ReadLine());
            int[] B = new int[N];
            for (int j = 0; j < N; j++)
            {
                Console.Write("Введите элемент массива В: ");
                B[j] = int.Parse(Console.ReadLine());
            }
            int k = 0;
            int count=0;
            while (k < A.Length)
            {
                if (k % 2 != 0)
                {
                    bool flag = false;
                    foreach (int element in B)
                    {
                        if (A[k] == element)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        count++;
                    }
                }
                k++;
            }
            int[] C = new int[count];
            count = 0;
            k = 0; 
            while (k < A.Length)
            {
                if (k % 2 != 0)
                {
                    bool flag = false;
                    foreach (int element in B)
                    {
                        if (A[k] == element)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        C[count] = A[k];
                        count++;
                    }
                }
                k++;
            }
            int proz = 1;
            count = 0;
            foreach (int element in C)
            {
                if (element % 3 == 0)
                {
                    proz *= element;
                    count++;
                }
                Console.Write(element);
            }
            Console.WriteLine();
            Console.WriteLine("Средне геометрическое {0}", Math.Pow(proz, 1/count));
        }
    }
}
