using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayz.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seventeen(10,2);
            Console.ReadKey();
        }
        static void One(int N)
        {
            int s = 0;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100,100);
                if(arr[i] > 0)
                {
                    s++;
                }
            }
            Console.WriteLine($"Количество положительных элементов: {s}");
        }
        static void Two(int N)
        {
            int s = 0;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100, 100);
                if (arr[i] < 0)
                {
                    s++;
                }
            }
            Console.WriteLine($"Количество отрицательных элементов: {s}");
        }
        static void Three(int N)
        {
            int s = 0;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100, 100);
                if (arr[i] % 2 == 0)
                {
                    s++;
                }
            }
            Console.WriteLine($"Количество четных элементов: {s}");
        }
        static void Four(int N)
        {
            int s = 0;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100, 100);
                if (arr[i] % 2 != 0)
                {
                    s++;
                }
            }
            Console.WriteLine($"Количество нечетных элементов: {s}");
        }
        static void Five(int S)
        {
            int[] arr = new int[S];
            int[] arrRes = new int[S];
            for (int i = 0; i < S; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < S; i++)
            {
                arrRes[i] = arr[i] % S;
                Console.WriteLine($"{i} элемент = {arrRes[i]}");
            }
        }
        static void Six(int S)
        {
            int[] arr = new int[S];
            int res = 0;
            for (int i = 0; i < S; i++)
            {
                arr[i] = i + 1;
                if(arr[i] % S != 0)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }
        static void Seven(int N)
        {
            int[] A = new int[N];
            int[] B = new int[N - 1];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Массив B: ");
            for(int i = 0; i < N - 1; i++)
            {
                B[i] = A[i];
                Console.WriteLine(B[i]);
            }
        }
        static void Eight(int N)
        {
            int[] A = new int[N];
            int[] B = new int[N - 3];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < N - 3; i++)
            {
                B[i] = A[i];
                Console.WriteLine(B[i]);
            }
        }
        static void Nine(int N, int n)
        {
            if(n > N)
            {
                Console.WriteLine("Ошибка! n не может быть больше N");
                return;
            }
            int[] A = new int[N];
            int[] B = new int[N - n];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < N - n; i++)
            {
                B[i] = A[i];
                Console.WriteLine(B[i]);
            }
        }
        static void Ten(int N)
        {
            Random random = new Random();
            int n = random.Next(1, N);
            int[] A = new int[N];
            int[] B = new int[N - n];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < N - n; i++)
            {
                B[i] = A[i];
                Console.WriteLine(B[i]);
            }
        }
        static void Eleven(int N)
        {
            Random random = new Random();
            double h = N / 2;
            double[] A = new double[N];
            double[] R = new double[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Массив R: ");
            for (int i = 0; i < N; i++)
            {
                R[i] = A[i] / h;
                Console.WriteLine(R[i]);
            }
        }
        static void Twelve(int N)
        {
            Random random = new Random();
            int[] arr = new int[N];
            int slave;
            Console.WriteLine("Первоначальный массив: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            for(int i = 0; i < N - 1; i += 2)
            {
                slave = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = slave;
            }
            Console.WriteLine("Полученный массив: ");
            for(int i = 0; i < N ; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Thirteen(int N)
        {
            Random random = new Random();
            int[] arr = new int[N];
            Console.WriteLine("Первоначальный массив: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            for(int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Fourteen(int N)
        {
            Random random = new Random();
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Array.Reverse(A);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
        static void Fifteen()
        {
            int[] A = new int[] { 1, 2, 3, 6, 3, 4 };
            int IndexOfX = Array.IndexOf(A, 6);
            int[] A_One = new int[IndexOfX];
            for(int i = 0; i < IndexOfX; i++)
            {
                A_One[i] = A[i];
                Console.WriteLine(A_One[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int[] A_Two = new int[A.Length - IndexOfX];
            for (int i = IndexOfX + 1, j = 0 ; i < A.Length; i++, j++)
            {
                A_Two[j] = A[i];
                Console.WriteLine(A_Two[j]);
            }
        }
        static void Sixteen()
        {
            int[] A = new int[] { 1, 3, 2, 4, 5, 6, 2, 7 };
            int IndexOfFirstNumber = Array.IndexOf(A, 2) + 1;
            int IndexOfSecondNumber = Array.LastIndexOf(A, 2);
            int[] FirstA = new int[IndexOfFirstNumber];
            for(int i = 0; i < IndexOfFirstNumber; i++)
            {
                FirstA[i] = A[i];
                Console.WriteLine(FirstA[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int[] SecondA = new int[A.Length - ((A.Length - IndexOfSecondNumber) + IndexOfFirstNumber)];
            for(int i = 0, j = IndexOfFirstNumber; i < SecondA.Length; i++, j++)
            {
                SecondA[i] = A[j];
                Console.WriteLine(SecondA[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int[] ThirdA = new int[A.Length - (IndexOfSecondNumber + 1)];
            for (int i = 0, j = IndexOfSecondNumber + 1; i < ThirdA.Length; i++, j++)
            {
                ThirdA[i] = A[j];
                Console.WriteLine(ThirdA[i]);
            }
        }
        static void Seventeen(int N, int x)
        {
            Random random = new Random();
            int[] A = new int[N];
            List<int[]> listOfArrays = new List<int[]>();
            for(int i = 0; i < N; i++)
            {
                A[i] = random.Next(1, 5);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            int index = -1;
            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int val = A[i];
                if(val != x)
                {
                    counter++;
                    if(i == A.Length - 1)
                    {
                        if(index < 0)
                        {
                            index = 0;
                        }
                        var a = new int[counter];
                        int k = index;
                        for (int j = 0; j < a.Length; j++)
                        {
                            a[j] = A[k];
                            k++;
                        }
                        listOfArrays.Add(a);
                    }
                }
                else
                {
                    if(counter == 0)
                    {
                        if(index < 0)
                        {
                            index += 2;
                        }
                        else
                        {
                            index++;
                        }
                        continue;
                    }
                    if(index < 0)
                    {
                        index = i - counter;
                    }
                    var a = new int[counter];
                    int t = index;
                    for (int j = 0; j < a.Length; j++)
                    {
                        a[j] = A[t];
                        t++;
                    }
                    listOfArrays.Add(a);
                    counter = 0;
                    index = i + 1;
                }
            }

            foreach(var arr in listOfArrays)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
        /*  bool flag = true;
            int indexOfX = 0;
            int m = 0;
            int arrayLength = 0;
            while (flag)
            {
                int[] arr;
                m = indexOfX;
                indexOfX = Array.IndexOf(A, x);
                if(indexOfX == -1)
                {
                    flag = false;
                    arrayLength = A.Length - m;
                    arr = new int[arrayLength];
                    for (int i = 0, j = m; i < arrayLength; i++, j++) 
                    {
                        arr[i] = A[j];
                    }
                    listOfArrays.Add(arr);
                }
                else
                {
                    arrayLength = A.Length - ((A.Length - indexOfX) + m) + 1;
                    arr = new int[arrayLength];
                    for(int i = 0, j = m; i < arrayLength; i++, j++)
                    {
                        arr[i] = A[j];
                    }
                    listOfArrays.Add(arr);
                    Array.Clear(A, m, indexOfX);
                }
            }
        */
    }
}
