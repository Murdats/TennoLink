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

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Prop")]
        public string Url { get; set; }

        public DateTime Date { get; set; }
    }
}