using System;
using System.Linq;
using TennoLink.Utils;

namespace TennoLink.Models.Enums
{
    public enum MissionType
    {
        [Identifier("MT_DEFENSE")]
        Defense,
        [Identifier("MT_SPY")]
        Spy,
        [Identifier("MT_DECEPTION")]
        Deception,
        [Identifier("MT_CAPTURE")]
        Capture,
        [Identifier("MT_MOBILE_DEFENSE")]
        MobileDefence,
        [Identifier("MT_SABOTAGE")]
        Sabotage,
        [Identifier("MT_RESCUE")]
        Rescue,
        [Identifier("MT_RAID")]
        Raid,
        [Identifier("MT_HIJACK")]
        Hijack,
        [Identifier("MT_SURVIVAL")]
        Survival,
        [Identifier("MT_EXTERMINATION")]
        Extermination,
        [Identifier("MT_ASSASSINATION")]
        Assasination,
        [Identifier("MT_PVP")]
        Conclave,
        [Identifier("MT_SECTOR")]
        Sector,
        [Identifier("MT_INTEL")]
        Interception,
    }
}