﻿using Service.Core.Client.Constants;
using Service.TutorialEconomics.Grpc.Models.State;
using Service.TutorialEconomics.Models;

namespace Service.TutorialEconomics.Mappers
{
    public static class ProgressInfoMapper
    {
        public static FinishStateGrpcResponse ToGrpcModel(this TaskTypeProgressInfo info, UserAchievement[] achievements) => new()
        {
            Case = info.Case,
            TrueFalse = info.TrueFalse,
            Game = info.Game,
            Test = info.Test,
            Text = info.Text,
            Video = info.Video,
            Achievements = achievements
        };
    }
}
