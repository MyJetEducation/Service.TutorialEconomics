using Service.Education.Structure;

namespace Service.TutorialEconomics.Helper
{
	public static class TutorialHelper
	{
		public static readonly EducationTutorial Tutorial = EducationTutorial.Economics;

		public static readonly EducationStructureTutorial StructureTutorial = EducationStructure.Tutorials[Tutorial];
	}
}