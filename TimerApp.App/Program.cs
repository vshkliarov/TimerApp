using System;

namespace TimerApp.App;

class Program
{
    static void PrintTime(object state)
    {
        Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("\n***** Working with Timer type *****\n");
        TimerCallback timeCB = new TimerCallback(PrintTime);

        Timer t = new Timer(timeCB, "Param from Main()", 0, 1000);
        Console.WriteLine("Hit key to terminate...");
        Console.ReadLine();
    }
}