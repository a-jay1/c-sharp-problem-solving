using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Async/Await Example
        Console.WriteLine("Async/Await Example");
        AsyncMethod();
        Console.WriteLine("iMHere");

        // Multithreading Example
        Console.WriteLine("Multithreading Example");
        Thread thread = new Thread(ThreadMethod);
        thread.Start();
        Console.WriteLine("Last@Line :) ");
        thread.Join();
        
        Console.ReadLine();
    }

    static async Task AsyncMethod()
    {
        Console.WriteLine("AsyncMethod - Before Await");
        meth();
        await Task.Delay(2000); // Simulate an asynchronous operation
        Console.WriteLine("AsyncMethod - After Await");
    }

    static void ThreadMethod()
    {
        meth();
        Console.WriteLine("ThreadMethod - Before Sleep");
        Thread.Sleep(2000); // Simulate a long-running operation
        meth();
        Console.WriteLine("ThreadMethod - After Sleep");
    }
    
    static void meth()
    {
        Console.WriteLine("*********");
        Thread.Sleep(1000);
        Console.WriteLine("*********");
        Thread.Sleep(1000);
        Console.WriteLine("*********");
        Thread.Sleep(1000);
        Console.WriteLine("*********");
    }
}
