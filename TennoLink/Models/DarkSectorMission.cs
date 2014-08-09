using System.Collections.Generic;

namespace TennoLink.Models
{
    public class DarkSectorMission
    {
        public List<Spectre> BadlandSpectres { get; set; }

        public string BadlandWarlordName { get; set; }

        public string BadlandWarlordSuit { get; set; }

        public List<object> CustomAllySpectres { get; set; }

        public List<object> CustomEnemySpectres { get; set; }

        public int Difficulty { get; set; }

        public string EnemySpec { get; set; }

        public string Faction { get; set; }

        public string GameRules { get; set; }

        public string LevelOverride { get; set; }

        public string MissionType { get; set; }
    }
}