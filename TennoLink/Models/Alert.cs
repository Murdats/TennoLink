using System;
using Newtonsoft.Json;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class Alert
    {
        [JsonProperty(PropertyName ="_id")]
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public int AllowReplay { get; set; }

        public DateTime Expiry { get; set; }

        public bool ForceUnlock { get; set; }

        public MissionInfo MissionInfo { get; set; }

        public int Twitter { get; set; }
    }
}