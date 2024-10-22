using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Counter(string threadname)
        {
            for (int i = 0; i <= 100 ; i++)
            {
                Console.WriteLine($"{threadname}: {i}");
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => Counter("Thread 1"));
            thread1.Start();
            Thread thread2 = new Thread(() => Counter("Thread 2"));
            thread2.Start();
            Thread thread3 = new Thread(() => Counter("Thread 3"));
            thread3.Start();
            Console.ReadKey();
        }
    }
}
