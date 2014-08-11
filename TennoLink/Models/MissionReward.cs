using System.Collections.Generic;
using TennoLink.Utils;

namespace TennoLink.Models
{
    public class MissionReward
    {
        public int Xp { get; set; }

        public List<LocalisationString> Items { get; set; }

        public List<CountedItem> CountedItems { get; set; }

        public int Credits { get; set; }

        public LocalisationString RandomizedItems { get; set; }
    }
}