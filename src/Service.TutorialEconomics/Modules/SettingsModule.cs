using Autofac;
using Service.Core.Client.Services;
using Service.TutorialEconomics.Services;

namespace Service.TutorialEconomics.Modules
{
	public class SettingsModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterInstance(Program.Settings).AsSelf().SingleInstance();
			builder.RegisterType<TaskProgressService>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<RetryTaskService>().AsImplementedInterfaces().SingleInstance();
		}
	}
}