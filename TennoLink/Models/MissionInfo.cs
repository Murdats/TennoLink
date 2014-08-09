using TennoLink.Models.Enums;

namespace TennoLink.Models
{
    public class MissionInfo
    {
        public string Description { get; set; }

        public Node Location { get; set; }

        public MissionType MissionType { get; set; }

        public Faction Faction { get; set; }

        public double Difficulty { get; set; }

        public MissionReward Reward { get; set; }

        public string LevelOverride { get; set; }

        public string EnemyType { get; set; }

        public string Boss { get; set; }

        public int MinEnemyLevel { get; set; }

        public int MaxEnemyLevel { get; set; }

        public int MaxWaveNum { get; set; }

        public bool Nightmare { get; set; }

        public int Seed { get; set; }

        public MissionReward MissionReward { get; set; }

        public string EnemySpec { get; set; }

        public string VipAgent { get; set; }
    }
}