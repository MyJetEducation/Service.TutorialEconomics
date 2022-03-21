using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialEconomics.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialEconomics.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialEconomicsClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialEconomicsClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialEconomicsService()).As<IGrpcServiceProxy<ITutorialEconomicsService>>().SingleInstance();
		}
	}
}
