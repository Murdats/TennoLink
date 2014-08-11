using System;
using Newtonsoft.Json;
using TennoLink.Models.Enums;
using TennoLink.Utils;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class GlobalUpgrade
    {
        [JsonProperty(PropertyName = "_id")]
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string LocalizeDescTag { get; set; }

        public string LocalizeTag { get; set; }

        public OperationType OperationType { get; set; }

        public UpgradeType UpgradeType { get; set; }

        public int Value { get; set; }

        public LocalisationString ValidType { get; set; }
    }
}