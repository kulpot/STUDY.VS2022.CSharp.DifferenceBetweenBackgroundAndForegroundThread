using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=IVci1IvHThU&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=3
// Threading -

class MainClass
{
    static void Main()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
            var thread = new Thread(DifferentMethod);
            thread.IsBackground = true;
            thread.Start(i);
        }
        Console.WriteLine("Leaving Main");
    }
    static void DifferentMethod(object threadID)
    {
        while (true)
            Console.WriteLine("Hello from different method: " + Thread.CurrentThread.ManagedThreadId);
    }
}