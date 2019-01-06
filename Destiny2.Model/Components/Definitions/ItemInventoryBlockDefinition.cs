using Destiny2.Api.Model.Items;

namespace Destiny2.Api.Model.Definitions
{
    public enum ETierType
    {
        Unknown = 0,
        Currency = 1,
        Basic = 2, 
        Common = 3, 
        Rare = 4,
        Superior = 5, 
        Exotic = 6,
    }

    public class ItemInventoryBlockDefinition
    {
        public string StackUniqueLabel { get; set; }
        public int MaxStackSize { get; set; }
        public long BucketTypeHash { get; set; }
        public long RecoveryBucketTypeHash { get; set; }
        public long TierTypeHash { get; set; }
        public bool IsInstanceItem { get; set; }
        public string TierTypeName { get; set; }
        public ETierType TierType { get; set; }
        public string ExpirationTooltip { get; set; }
        public string ExpiredInActivityMessage { get; set; }
        public string ExpiredInOrbitMessage { get; set; }
        public bool SuppressExpirationWhenObjectivesComplete { get; set; }

    }
}
