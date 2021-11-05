using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework21
{
    class Program
    {
        const int N = 10;
        static int[,] array = new int[N, N];
        static void Main(string[] args)
        {

            ThreadStart threadStart = new ThreadStart(Sadovnic1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Sadovnic2();

            void Sadovnic1()
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (array[i, j] == 0)
                        {
                            array[i, j] = 1;
                        }
                        else
                            break;
                    }
                    Thread.Sleep(100);
                }
            }
            void Sadovnic2()
            {
                int P = N - 1;
                for (int i = P; i >= 0; i--)
                {
                    for (int j = P; j >= 0; j--)
                    {
                        if (array[j, i] == 0)
                        {
                            array[j, i] = 2;
                        }
                        else
                            break;
                    }
                    Thread.Sleep(100);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
