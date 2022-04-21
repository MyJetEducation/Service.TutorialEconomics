﻿using System;
using System.Threading.Tasks;
using Service.Education.Contracts.State;
using Service.Education.Contracts.Task;
using Service.Education.Structure;
using Service.TutorialEconomics.Models;

namespace Service.TutorialEconomics.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(string userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(string userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(string userId, int? unit = null);
	}
}
