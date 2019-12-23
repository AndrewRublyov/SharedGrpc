using System;
using Grpc.Net.Client;
using GrpcService;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Workaround of untrusted calls from
            // https://github.com/grpc/grpc-dotnet/issues/626#issuecomment-549450396
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client =  new Greeter.GreeterClient(channel);
            var reply = client.SayHello(
                new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}