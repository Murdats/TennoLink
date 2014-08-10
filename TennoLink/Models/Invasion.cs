using System;
using Newtonsoft.Json;
using TennoLink.Models.Enums;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class Invasion
    {
        [JsonProperty(PropertyName = "_id")]
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

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
    }
}