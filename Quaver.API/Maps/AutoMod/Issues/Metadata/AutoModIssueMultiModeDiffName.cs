﻿using Quaver.API.Helpers;

namespace Quaver.API.Maps.AutoMod.Issues.Metadata
{
    public class AutoModIssueMultiModeDiffName : AutoModIssue
    {
        public Qua Map { get; }

        public AutoModIssueMultiModeDiffName(Qua map) : base(AutoModIssueLevel.Ranking)
        {
            Map = map;

            Text = $"The difficulty '{Map.DifficultyName}' should be named: " +
                   $"'{ModeHelper.ToShortHand(Map.Mode)} {Map.DifficultyName}'";
        }
    }
}