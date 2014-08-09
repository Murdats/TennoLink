using TennoLink.Models.Enums;

namespace TennoLink.Models
{
    public class NodeOverride
    {
        public string Id { get; set; }

        public Node Node { get; set; }

        public Faction Faction { get; set; }

        public string LevelOverride { get; set; }

        public string EnemySpec { get; set; }

        public string VipAgent { get; set; }
    }
}