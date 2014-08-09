using System;
using TennoLink.Models.Enums;

namespace TennoLink.Models
{
    public class Invasion
    {
        public DateTime Activation { get; set; }

        public MissionInfo AttackerMissionInfo { get; set; }

        public MissionReward AttackerReward { get; set; }

        public bool Completed { get; set; }

        public int Count { get; set; }

        public MissionInfo DefenderMissionInfo { get; set; }

        public MissionReward DefenderReward { get; set; }

        public Faction Faction { get; set; }

        public int Goal { get; set; }

        public string LocTag { get; set; }

        public Node Node { get; set; }

        public string Id { get; set; }
    }
}