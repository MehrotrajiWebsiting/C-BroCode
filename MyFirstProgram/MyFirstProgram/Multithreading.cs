using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Multithreading
    {
        static void Main(String[] args)
        {
            Thread myThread=Thread.CurrentThread;
            myThread.Name = "Main thread";
            Console.WriteLine(myThread.Name);

            //WITHOUT PARAMETERS
            //Thread t1 = new Thread(countUp);
            //Thread t2 = new Thread(countDown);

            Thread t1 = new Thread(()=>countUp("Up"));
            Thread t2 = new Thread(()=>countDown("Down"));

            t1.Start();
            t2.Start();

            Console.WriteLine("MAIN THREAD OVER!!!");
        }

        static void countUp(String n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer {n} : {i} seconds");
                Thread.Sleep(2000);
            }
            Console.WriteLine($"Timer {n} OVER!!!");
        }
        static void countDown(String n)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Timer {n} : {i} seconds");
                Thread.Sleep(2000);
            }
            Console.WriteLine($"Timer {n} OVER!!!");
        }

        static void countUp()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer 1 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer 1 OVER!!!");
        }
        static void countDown()
        {
            for (int i = 10; i > 0 ; i--)
            {
                Console.WriteLine($"Timer 2 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer 2 OVER!!!");
        }
    }
}
