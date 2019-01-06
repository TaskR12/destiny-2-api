using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorInventoryFlyoutBucketDefinition
    {
        public bool Collapsible { get; set; }
        public long InventoryBucketHash { get; set; }
        public EDestinyItemSortType SortItemsBy { get; set; }
    }
}
