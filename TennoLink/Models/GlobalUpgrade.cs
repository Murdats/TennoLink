using System;
using TennoLink.Models.Enums;

namespace TennoLink.Models
{
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
}