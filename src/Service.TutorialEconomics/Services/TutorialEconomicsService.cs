using System;
using System.Threading.Tasks;
using Service.TutorialEconomics.Grpc;
using Service.TutorialEconomics.Grpc.Models.State;
using Service.TutorialEconomics.Mappers;
using Service.TutorialEconomics.Models;
using Service.UserReward.Grpc;
using Service.UserReward.Grpc.Models;

namespace Service.TutorialEconomics.Services
{
	public partial class TutorialEconomicsService : ITutorialEconomicsService
	{
		private readonly ITaskProgressService _taskProgressService;
		private readonly IUserRewardService _userRewardService;

		public TutorialEconomicsService(ITaskProgressService taskProgressService, IUserRewardService userRewardService)
		{
			_taskProgressService = taskProgressService;
			_userRewardService = userRewardService;
		}

		public async ValueTask<FinishStateGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request)
		{
			Guid? userId = request.UserId;
			int? unit = request.Unit;

			TaskTypeProgressInfo typeProgressInfo = await _taskProgressService.GetTotalProgressAsync(userId, unit);

			UserAchievementsGrpcResponse achievements = await _userRewardService.GetUserNewAchievementsAsync(new GetUserAchievementsGrpcRequest
			{
				UserId = userId,
				Unit = unit
			});

			return typeProgressInfo.ToGrpcModel(achievements?.Items);
		}
	}
}
