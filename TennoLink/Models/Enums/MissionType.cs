using System;
using System.Linq;
using TennoLink.Utils;

namespace TennoLink.Models.Enums
{
    public enum MissionType
    {
        [Identifier("MT_EXTERMINATION")]
        Extermination,
        [Identifier("MT_MOBILE_DEFENSE")]
        MobileDefence,
        [Identifier("MT_SURVIVAL")]
        Survival,
        [Identifier("MT_DEFENSE")]
        Defense,
        [Identifier("MT_ASSASSINATION")]
        Assasination,
    }
}