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
            Eleven(10);
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
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("Массив R: ");
            for (int i = 0; i < N; i++)
            {
                if (A[i] % h == 0)
                {
                    R[i] = A[i];
                }
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
            for(int i = 0; i < N - 1; i++)
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
            int[] I = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            for(int i = N - 1, j = 0; j < N && i >= 0; i--, j++)
            {
                I[j] = A[i];
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(I[i]);
            }
        }
        static void Fifteen()
        {
            int[] A = new int[] { 1, 2, 3, 6, 3, 4 };
            int IndexOfX = 0;
            const int x = 6;
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i] == x)
                {
                    IndexOfX = i;
                    break;
                }
            }
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
            int IndexOfFirstNumber = 0;
            const int x = 2;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                {
                    IndexOfFirstNumber = i;
                    break;
                }
            }
            int IndexOfSecondNumber = 0;
            for(int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == x)
                {
                    IndexOfSecondNumber = i;
                    break;
                }
            }
            int[] FirstA = new int[IndexOfFirstNumber];
            for(int i = 0; i < IndexOfFirstNumber; i++)
            {
                FirstA[i] = A[i];
                Console.WriteLine(FirstA[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int[] SecondA = new int[A.Length - ((A.Length - IndexOfSecondNumber) + IndexOfFirstNumber)];
            for(int i = 0, j = IndexOfFirstNumber + 1; i < SecondA.Length - 1; i++, j++)
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
        static void ProOne(int N)
        {
            var A = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-N, N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - 1];
            for(int i = 0; i < N - 1; i++)
            {
                B[i] = A[i + 1];
                Console.WriteLine(B[i]);
            }
        }
        static void ProTwo(int N)
        {
            var A = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-N, N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - 3];
            for (int i = 0; i < N - 3; i++)
            {
                B[i] = A[i + 3];
                Console.WriteLine(B[i]);
            }
        }
        static void ProThree(int N, int n)
        {
            if(N < n)
            {
                Console.WriteLine("Ошибка!");
                return;
            }
            var A = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(-N, N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - n];
            for (int i = 0; i < N - n; i++)
            {
                B[i] = A[i + n];
                Console.WriteLine(B[i]);
            }
        }
        static void ProFour(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for(int i = 0;i < A.Length; i++)
            {
                A[i] = random.Next(-N, N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - 2];
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = A[i + 1];
                Console.WriteLine(B[i]);
            }
        }
        static void ProFive(int N)
        {
            if(N % 2 != 0)
            {
                Console.WriteLine("Ошибка!");
                return;
            }
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(-N, N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N];
            int j = 0;
            for (int i = N / 2; i < N; i++) 
            {
                B[j] = A[i];
                j++;
            }
            for (int i = 0; i < N / 2; i++) 
            {
                B[j] = A[i];
                j++;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(B[i]);
            }
        }
        static void ProSix(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - 1];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                if (i == N / 2)
                {
                    continue;
                }
                else
                {
                    B[j] = A[i];
                    Console.WriteLine(B[j]);
                    j++;
                }
            }
        }
        static void ProSeven(int N, int index)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var B = new int[N - 1];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    B[j] = A[i];
                    Console.WriteLine(B[j]);
                    j++;
                }
            }
        }
        static void ProEight(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int index = 0;
            bool flag = true;
            int count = 0;
            for(int i = 0; i < N; i++)
            {
                if(flag == true)
                {
                    count = A[i];
                    for(int k = 0; k < A.Length; k++)
                    {
                        if(count < A[k])
                        {
                            count = A[k];
                        }
                    }
                    flag = false;
                }
                if (A[i] == count)
                {
                    index = i;
                    break;
                }
            }
            var B = new int[N - 1];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    B[j] = A[i];
                    Console.WriteLine(B[j]);
                    j++;
                }
            }
        }
        static void ProNine(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int index = 0;
            bool flag = true;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (flag == true)
                {
                    count = A[i];
                    for (int k = 0; k < A.Length; k++)
                    {
                        if (count > A[k])
                        {
                            count = A[k];
                        }
                    }
                    flag = false;
                }
                if (A[i] == count)
                {
                    index = i;
                    break;
                }
            }
            var B = new int[N - 1];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    B[j] = A[i];
                    Console.WriteLine(B[j]);
                    j++;
                }
            }
        }
        static void ProTen(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int counter = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 < N && A[i] > A[i + 1])
                {
                    counter = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = counter;
                }
                Console.Write(A[i] + " ");
            }
        }
        static void ProEleven(int N)
        {
            Random random = new Random();
            var A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(N);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            var counter = 0;
            for(int i = 0; i < N - 1; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    if(A[i] > A[j])
                    {
                        counter = A[i];
                        A[i] = A[j];
                        A[j] = counter;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
