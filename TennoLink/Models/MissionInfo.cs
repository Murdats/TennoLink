using TennoLink.Models.Enums;
using TennoLink.Utils;
using Newtonsoft.Json;

namespace TennoLink.Models
{
    public class MissionInfo
    {
        [JsonProperty("descText")]
        public LocalisationString Description { get; set; }

        public Node Location { get; set; }

        public MissionType MissionType { get; set; }

        public Faction Faction { get; set; }

        public double Difficulty { get; set; }

        public MissionReward Reward { get; set; }

        public LocalisationString LevelOverride { get; set; }

        public LocalisationString EnemyType { get; set; }

        public LocalisationString Boss { get; set; }

        public int MinEnemyLevel { get; set; }

        public int MaxEnemyLevel { get; set; }

        public int MaxWaveNum { get; set; }

        public bool Nightmare { get; set; }

        public int Seed { get; set; }

        public MissionReward MissionReward { get; set; }

        public LocalisationString EnemySpec { get; set; }

        public LocalisationString VipAgent { get; set; }
    }
}