using System;
using System.Collections.Generic;

namespace TennoLink.Models
{
    public class DarkSectorNode
    {
        public DarkSectorFaction AttackerInfo { get; set; }

        public DateTime ConflictExpiration { get; set; }

        public DarkSectorFaction DefenderInfo { get; set; }

        public List<History> History { get; set; }

        public DateTime LastNameCacheTime { get; set; }

        public string Node { get; set; }

        public string NodeDisplayName { get; set; }

        public string NodeRegionName { get; set; }

        public DateTime PostConflictCooldown { get; set; }

        public string Id { get; set; }

        public double? TotalAllianceScore { get; set; }

        public double? TotalGuildScore { get; set; }
    }
}