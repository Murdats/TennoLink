using System;
using Newtonsoft.Json;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class News //Events
    {
        [JsonProperty(PropertyName = "_id")]
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public string Msg { get; set; }

        public string Prop { get; set; }

        public DateTime Date { get; set; }
    }
}