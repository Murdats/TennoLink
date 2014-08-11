using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TennoLink.Models
{
    public class Status
    {
        public string BuildLabel { get; set; }

        [JsonProperty("Events")]
        public List<News> News { get; set; }

        public List<object> Goals { get; set; }

        public List<Alert> Alerts { get; set; }

        public List<GlobalUpgrade> GlobalUpgrades { get; set; }

        public List<Sale> FlashSales { get; set; }

        public List<Invasion> Invasions { get; set; }

        //Uninteresting
        //public List<NodeOverride> NodeOverrides { get; set; }

        [JsonProperty("BadlandNodes")]
        public List<DarkSectorNode> DarkSectors { get; set; }
    }
}