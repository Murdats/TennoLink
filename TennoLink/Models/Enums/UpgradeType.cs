using System;
using System.Linq;
using TennoLink.Utils;

namespace TennoLink.Models.Enums
{
    public enum UpgradeType
    {
        [Identifier("GAMEPLAY_PICKUP_AMOUNT")]
        GameplayPickupAmount,
        [Identifier("GAMEPLAY_PICKUP_RATE")]
        GameplayPickupRate,
    }
}