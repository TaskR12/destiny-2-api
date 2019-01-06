using System.Collections.Generic;

namespace Destiny2.Api.Model.Definitions
{
    public enum EEquippingItemBlockAttributes
    {
        None = 0,
        EquipOnAcquire = 1,
    }

    public enum EAmmunitionType
    {
        None = 0,
        Primary = 1,
        Special = 2,
        Heavy = 3,
        Unknown = 4,
    }

    public class EquippingBlockDefinition
    {
        public long? GearsetItemHash { get; set; }
        public string UniqueLabel { get; set; }
        public long UniqueLabelHash { get; set; }
        public long EquipmentSlotTypeHash { get; set; }
        public EEquippingItemBlockAttributes Attributes { get; set; }
        public EAmmunitionType AmmoType { get; set; }
        public IEnumerable<string> DisplayStrings { get; set; }
    }
}
