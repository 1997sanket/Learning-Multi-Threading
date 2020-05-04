using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void MyThreadFunction()
        {
            int local = 0;

            for(local =0; local < 10; local++)
            {
                Conosle.WriteLine($"local = {local}");
                Thread.Sleep(500);
            }

        }

        public static void main()   // Main thread (ZERO)
        {
            int local = 0;

            Conosle.WriteLine("Hello, multithreading");
            

            // Create thread (ONE)
            Thread dhaaga  = new Thread(MyThreadFunction);
            dhaaga.Name = "dhaaga";
            
            // Start execution
            dhaaga.Start();

            Thread.Sleep(3000);     //Making main thread sleep for a lil bit, while thread 'dhaaga' is executing to give 'dhaaga' a little head start over 'taar' :D

            
            // Create another thread(TWO)
            Thread taar = new Thread(MyThreadFunction);
            taar.Name = "taar";
            taar.Start();


            Conosle.WriteLine("I am back");
        }

        
    }


}