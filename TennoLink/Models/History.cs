using System;
using Newtonsoft.Json;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class History
    {
        public string Def { get; set; }

        [JsonConverter(typeof(MongoIdConverter))]
        public string DefId { get; set; }

        public bool DefAli { get; set; }

        public string Att { get; set; }

        [JsonConverter(typeof(MongoIdConverter))]
        public string AttId { get; set; }

        public bool AttAli { get; set; }

        [JsonConverter(typeof(MongoIdConverter))]
        public string WinId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}