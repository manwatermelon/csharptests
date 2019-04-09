using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TestFibonacci();
            TestDictionaryCollisions();
        }

        private static void TestFibonacci() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int n = 40;
            int [] arr = new int[n+1];
            var c = Fibonacci.fibMemo(n, arr);
            sw.Stop();
            Console.WriteLine("fib memo result for n = " + n + ": " + c);
            Console.WriteLine("time={0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            c = Fibonacci.fibSimple(n);
            sw.Stop();
            Console.WriteLine("fib simple result for n = " + n + ": " + c);
            Console.WriteLine("time={0}", sw.Elapsed);
        }

        private static void TestDictionaryCollisions() {
            long n = 10;

            for (long i = 1; i < 10; i++) {
                n = (long)Math.Pow(10, i);
                Console.WriteLine("collisions for {0} elements = {1}", n, DictionaryCollision.Collisions(n));
            }
            
            
        }

    
    }
}
