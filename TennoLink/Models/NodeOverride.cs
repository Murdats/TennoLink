using Newtonsoft.Json;
using TennoLink.Models.Enums;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class NodeOverride
    {
        [JsonProperty(PropertyName = "_id")]
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public Node Node { get; set; }

        public Faction Faction { get; set; }

        public string LevelOverride { get; set; }

        public string EnemySpec { get; set; }

        public string VipAgent { get; set; }
    }
}