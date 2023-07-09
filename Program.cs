using System;
using System.Threading;

class Program
{
    public static void Foo(object arg)
    {
        Console.WriteLine($"Foo:{arg}, {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
    }

    public static void Main()
    {
        ThreadPool.QueueUserWorkItem(Foo, "Hello World");
        ThreadPool.QueueUserWorkItem(Foo); // arg에 null 전달
        Console.ReadLine();
    }
}
