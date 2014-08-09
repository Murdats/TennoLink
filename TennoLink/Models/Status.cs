using System;
using System.Collections.Generic;
using System.Linq;

namespace TennoLink.Models
{
    public class Status
    {
        public string BuildLabel { get; set; }

        public List<News> News { get; set; }

        public List<object> Goals { get; set; }

        public List<Alert> Alerts { get; set; }

        public List<GlobalUpgrade> GlobalUpgrades { get; set; }

        public List<Sale> FlashSales { get; set; }

        public List<Invasion> Invasions { get; set; }

        public List<NodeOverride> NodeOverrides { get; set; }

        public List<DarkSectorNode> BadlandNodes { get; set; }
    }
}