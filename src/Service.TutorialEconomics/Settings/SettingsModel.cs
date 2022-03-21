using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialEconomics.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialEconomics.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialEconomics.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialEconomics.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialEconomics.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialEconomics.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialEconomics.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialEconomics.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}