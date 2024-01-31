using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        await MyAsyncMethod();
        Console.WriteLine("End");
    }
    static async Task MyAsyncMethod()
    {
        Console.WriteLine("Async Method Start");
        await Task.Delay(2000); // Simulate an asynchronous operation
        Console.WriteLine("Async Method End");
    }
}
