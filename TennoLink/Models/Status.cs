using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennoLink.Models.Enums;

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

public class Sale
{
}

public class News //Events
{
    public string Id {get;set;}
    public string Msg { get; set; }
    public string Prop { get; set; }
    public DateTime Date { get; set; }
}

public class MissionReward
{
    public int credits { get; set; }
    public int xp { get; set; }
    public List<object> items { get; set; }
    public List<object> countedItems { get; set; }
}

public class MissionInfo
{
    public string Description { get; set; }
    public Node Location { get; set; }
    public MissionType MissionType { get; set; }
    public Faction Faction { get; set; }
    public double Difficulty { get; set; }
    public MissionReward Reward { get; set; }
    public string LevelOverride { get; set; }
    public string EnemyType { get; set; }
    public string Boss { get; set; }
    public int MinEnemyLevel { get; set; }
    public int MaxEnemyLevel { get; set; }
    public int MaxWaveNum { get; set; }
    public bool Nightmare { get; set; }
}

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

public class GlobalUpgrade
{
    public string Id { get; set; }
    public DateTime Activation { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string LocalizeDescTag { get; set; }
    public string LocalizeTag { get; set; }
    public OperationType OperationType { get; set; }
    public UpgradeType UpgradeType { get; set; }
    public int Value { get; set; }
    public string ValidType { get; set; }
}

public class MissionReward
{
    public int Credits { get; set; }
    public string RandomizedItems { get; set; }
    public List<CountedItem> countedItems { get; set; }
}

public class MissionInfo
{
    public MissionType MissionType { get; set; }
    public Faction Faction { get; set; }
    public int Seed { get; set; }
    public int Difficulty { get; set; }
    public MissionReward MissionReward { get; set; }
    public string LevelOverride { get; set; }
    public string EnemySpec { get; set; }
    public int MinEnemyLevel { get; set; }
    public int MaxEnemyLevel { get; set; }
    public string VipAgent { get; set; }
}

public class CountedItem
{
    public string ItemType { get; set; }
    public int ItemCount { get; set; }
}

public class Invasion
{
    public DateTime Activation { get; set; }
    public MissionInfo AttackerMissionInfo { get; set; }
    public MissionReward AttackerReward { get; set; }
    public bool Completed { get; set; }
    public int Count { get; set; }
    public MissionInfo DefenderMissionInfo { get; set; }
    public MissionReward DefenderReward { get; set; }
    public Faction Faction { get; set; }
    public int Goal { get; set; }
    public string LocTag { get; set; }
    public Node Node { get; set; }
    public string Id { get; set; }
}

public class NodeOverride
{
    public string Id { get; set; }
    public Node Node { get; set; }
    public Faction Faction { get; set; }
    public string LevelOverride { get; set; }
    public string EnemySpec { get; set; }
    public string VipAgent { get; set; }
}

public class Spectre
{
    public string Suits { get; set; }
    public string LongGuns { get; set; }
    public string Pistols { get; set; }
    public string Melee { get; set; }
    public string Name { get; set; }
}

public class DarkSectorMission
{
    public List<Spectre> badlandSpectres { get; set; }
    public string badlandWarlordName { get; set; }
    public string badlandWarlordSuit { get; set; }
    public List<object> customAllySpectres { get; set; }
    public List<object> customEnemySpectres { get; set; }
    public int difficulty { get; set; }
    public string enemySpec { get; set; }
    public string faction { get; set; }
    public string gameRules { get; set; }
    public string levelOverride { get; set; }
    public string missionType { get; set; }
}

public class DarkSectorFaction
{
    public int CreditsTaxRate { get; set; }
    public int DamagePerMission { get; set; }
    public string DeployerClan { get; set; }
    public string DeployerName { get; set; }
    public DateTime DeploymentActivationTime { get; set; }
    public int HealCost { get; set; }
    public double HealRate { get; set; }
    public string Id { get; set; }
    public bool IsAlliance { get; set; }
    public int ItemsTaxRate { get; set; }
    public DateTime LastHealTime { get; set; }
    public string MOTD { get; set; }
    public int MaxStrength { get; set; }
    public int MemberCreditsTaxRate { get; set; }
    public int MemberItemsTaxRate { get; set; }
    public DarkSectorMission MissionInfo { get; set; }
    public string Name { get; set; }
    public int RailHealReserve { get; set; }
    public string RailType { get; set; }
    public int StrengthRemaining { get; set; }
    public DateTime TaxChangeAllowedTime { get; set; }
    public int? BattlePayReserve { get; set; }
    public string BattlePaySetBy { get; set; }
    public string MOTDAuthor { get; set; }
    public int? MissionBattlePay { get; set; }
    public string TaxLastChangedBy { get; set; }
    public string BattlePaySetByClan { get; set; }
    public string TaxLastChangedByClan { get; set; }
}

public class History
{
    public string Def { get; set; }
    public string DefId { get; set; }
    public bool DefAli { get; set; }
    public string Att { get; set; }
    public string AttId { get; set; }
    public bool AttAli { get; set; }
    public string WinId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}

public class DarkSectorNode
{
    public DarkSectorFaction AttackerInfo { get; set; }
    public DateTime ConflictExpiration { get; set; }
    public DarkSectorFaction DefenderInfo { get; set; }
    public List<History> History { get; set; }
    public DateTime LastNameCacheTime { get; set; }
    public string Node { get; set; }
    public string NodeDisplayName { get; set; }
    public string NodeRegionName { get; set; }
    public DateTime PostConflictCooldown { get; set; }
    public string _id { get; set; }
    public double? TotalAllianceScore { get; set; }
    public double? TotalGuildScore { get; set; }
}
