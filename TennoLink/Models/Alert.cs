using System;

namespace TennoLink.Models
{
    public class Alert
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public int AllowReplay { get; set; }

        public DateTime Expiry { get; set; }

        public bool ForceUnlock { get; set; }

        public MissionInfo MissionInfo { get; set; }

        public int Twitter { get; set; }
    }
}