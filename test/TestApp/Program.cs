using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialEconomics.Client;
using Service.TutorialEconomics.Grpc;
using GrpcClientFactory = ProtoBuf.Grpc.Client.GrpcClientFactory;

namespace TestApp
{
	public class Program
	{
		private static async Task Main(string[] args)
		{
			GrpcClientFactory.AllowUnencryptedHttp2 = true;
			ILogger<Program> logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<Program>();

			Console.Write("Press enter to start");
			Console.ReadLine();

			var factory = new TutorialEconomicsClientFactory("http://localhost:5001", logger);
			IGrpcServiceProxy<ITutorialEconomicsService> serviceProxy = factory.GetTutorialEconomicsService();
			ITutorialEconomicsService client = serviceProxy.Service;

			//var resp = await  client.SayHelloAsync(new HelloGrpcRequest(){Name = "Alex"});
			//Console.WriteLine(resp?.Message);

			Console.WriteLine("End");
			Console.ReadLine();
		}
	}
}