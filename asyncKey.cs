
using System;
using System.Threading.Tasks;

public class HelloWorld
{
    public static async Task Main(string[] args)
    {
        var task = Task.Run(async () => await CreateTicket());
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%");
        await task; // Wait for the task to complete
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%");
        Console.ReadLine();
    }

    public static async Task CreateTicket()
    {
        // Simulate an asynchronous operation
        Console.WriteLine("Creating ticket...");
        await Task.Delay(2000);
        Console.WriteLine("Ticket created.");
    }
}
