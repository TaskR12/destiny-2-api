using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorInventoryFlyoutDefinition
    {
        public string LockedDescription { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public IEnumerable<DestinyVendorInventoryFlyoutBucketDefinition> Buckets { get; set; }
        public long FlyoutId { get; set; }
        public bool SuppressNewness { get; set; }
        public long EquipmentSlotHash { get; set; }
    }
}
