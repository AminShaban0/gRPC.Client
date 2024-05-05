using Grpc.Net.Client;

namespace GrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter Any Key To Cont");
            Console.ReadLine();
            using var channel1 = GrpcChannel.ForAddress("https://localhost:7194");
            var client = new Greeter.GreeterClient(channel1);
            var replay =await client.SayHelloAsync(new HelloRequest { Name = "Greeter Client" });
            Console.WriteLine($"Greetings : {replay.Message}");
            Console.WriteLine("Enter Any Key To Exit");
            Console.ReadLine();
        }
    }
}