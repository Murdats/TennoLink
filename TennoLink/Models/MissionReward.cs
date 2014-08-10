using System.Collections.Generic;

namespace TennoLink.Models
{
    public class MissionReward
    {
        public int Credits1 { get; set; }

        public int Xp { get; set; }

        public List<object> Items { get; set; }

        public List<CountedItem> CountedItems { get; set; }

        public int Credits { get; set; }

        public string RandomizedItems { get; set; }
    }
}