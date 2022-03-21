using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialEconomics.Grpc;

namespace Service.TutorialEconomics.Client
{
	[UsedImplicitly]
	public class TutorialEconomicsClientFactory : GrpcClientFactory
	{
		public TutorialEconomicsClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialEconomicsService> GetTutorialEconomicsService() => CreateGrpcService<ITutorialEconomicsService>();
	}
}