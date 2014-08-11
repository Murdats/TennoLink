using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TennoLink.Models.Enums;
using TennoLink.Utils;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class DarkSectorNode
    {
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public DarkSectorFaction AttackerInfo { get; set; }

        public DateTime ConflictExpiration { get; set; }

        public DarkSectorFaction DefenderInfo { get; set; }

        public List<History> History { get; set; }

        public DateTime LastNameCacheTime { get; set; }

        public Node Node { get; set; }

        public string NodeDisplayName { get; set; }

        public LocalisationString NodeRegionName { get; set; }

        public DateTime PostConflictCooldown { get; set; }

        public double? TotalAllianceScore { get; set; }

        public double? TotalGuildScore { get; set; }
    }
}