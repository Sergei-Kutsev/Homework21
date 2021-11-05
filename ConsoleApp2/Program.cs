using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        const int N = 6;
        static void Main(string[] args)
        {
            Action action = new Action(Sadovnic1);
            Task task = new Task(action);
            task.Start();
            //ThreadStart threadStart = new ThreadStart(Sadovnic1);
            //Thread thread = new Thread(threadStart);
            //thread.Start();
            Sadovnic2();

            int[,] array = new int[N, N];
            foreach (int i in array)
            {
                foreach (int j in array)
                { Console.Write("{0} ", array[i, j]); }
            }
            Console.ReadKey();
        }
        static void Sadovnic1()
        {
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] == 0)
                        array[i, j] = 1;
                    else
                        break;
                    Thread.Sleep(300);
                }
            }
        }
        static void Sadovnic2()
        {
            int P = N - 1;
            int[,] array = new int[N, N];
            for (int i = P; i >= 0; i--)
            {
                for (int j = P; j >= 0; j--)
                {
                    if (array[j, i] == 0)
                        array[j, i] = 2;
                    else
                        break;
                    Thread.Sleep(300);
                }
            }
        }
    }
}
