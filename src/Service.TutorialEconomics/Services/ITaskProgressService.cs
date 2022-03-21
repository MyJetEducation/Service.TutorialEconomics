using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialEconomics.Grpc.Models.State;
using Service.TutorialEconomics.Grpc.Models.Task;
using Service.TutorialEconomics.Models;

namespace Service.TutorialEconomics.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(Guid? userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(Guid? userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(Guid? userId, int? unit = null);
	}
}
