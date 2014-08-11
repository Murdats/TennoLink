using System.Collections.Generic;
using TennoLink.Models.Enums;
using TennoLink.Utils;

namespace TennoLink.Models
{
    public class DarkSectorMission
    {
        public List<Spectre> BadlandSpectres { get; set; }

        public string BadlandWarlordName { get; set; }

        public LocalisationString BadlandWarlordSuit { get; set; }

        public List<string> BadlandMemberNames { get; set; }

        public List<LocalisationString> BadlandMemberSuits { get; set; }

        public List<Spectre> CustomAllySpectres { get; set; }

        public List<Spectre> CustomEnemySpectres { get; set; }

        public int Difficulty { get; set; }

        public string EnemySpec { get; set; }

        public string Faction { get; set; }

        public LocalisationString GameRules { get; set; }

        public LocalisationString LevelOverride { get; set; }

        public MissionType MissionType { get; set; }
    }
}