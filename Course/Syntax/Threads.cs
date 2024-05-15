using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class Threads
    {

        static int Calculate(int a, int b)
        {
            Thread.Sleep(1000);
            return a + b;
        }

        async static Task<int> CalculateAsync(int a, int b)
        {
            Task<int> ti=Task.Run(() => Calculate(a, b));
            int ret = await ti;
            return ret;
        }

        async static void CalculateTester()
        {
            Console.WriteLine("Säie alku " + Thread.CurrentThread.GetHashCode());
            int sum = await CalculateAsync(4, 5);
            Console.WriteLine("Säie loppu " + Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Tester : " + sum);
        }

        static public void TheadMain()
        {
            CalculateTester();
            Console.WriteLine("Mainikin laskee");
            int s = Calculate(4, 5);
            Console.WriteLine("Summa "+s);
        }


        static void ThreadFunc()
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Thread " + i + ", ID " + Thread.CurrentThread.GetHashCode());
            }
        }

        static public void xTheadMain()
        {
            Console.WriteLine("Säikeitä");
            Thread t=new Thread(ThreadFunc);
            Task t2 = new Task(ThreadFunc);
            t2.Start();
            t.IsBackground = true;
            t.Start();
            for(int i=0;i<100; i++)
            {
                Console.WriteLine("Main " + i + ", ID" + Thread.CurrentThread.GetHashCode());
            }
            t.Join();
            t2.Wait();
        }
    }
}
