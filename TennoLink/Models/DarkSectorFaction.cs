using System;
using Newtonsoft.Json;
using TennoLink.Utils;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Models
{
    public class DarkSectorFaction
    {
        [JsonConverter(typeof(MongoIdConverter))]
        public string Id { get; set; }

        public int CreditsTaxRate { get; set; }

        public int DamagePerMission { get; set; }

        public string DeployerClan { get; set; }

        public string DeployerName { get; set; }

        public DateTime DeploymentActivationTime { get; set; }

        public int HealCost { get; set; }

        public double HealRate { get; set; }

        public bool IsAlliance { get; set; }

        public int ItemsTaxRate { get; set; }

        public DateTime LastHealTime { get; set; }

        public string Motd { get; set; }

        public int MaxStrength { get; set; }

        public int MemberCreditsTaxRate { get; set; }

        public int MemberItemsTaxRate { get; set; }

        public DarkSectorMission MissionInfo { get; set; }

        public string Name { get; set; }

        public float RailHealReserve { get; set; }

        public LocalisationString RailType { get; set; }

        public int StrengthRemaining { get; set; }

        public DateTime TaxChangeAllowedTime { get; set; }

        public int? BattlePayReserve { get; set; }

        public string BattlePaySetBy { get; set; }

        public string MotdAuthor { get; set; }

        public int? MissionBattlePay { get; set; }

        public string TaxLastChangedBy { get; set; }

        public string BattlePaySetByClan { get; set; }

        public string TaxLastChangedByClan { get; set; }
    }
}