using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public enum EItemLocation
    {
        Unknown = 0,
        Inventory = 1,
        Vault = 2,
        Vendor = 3, 
        Postmaster = 4,
    }

    public enum EBucketScope
    {
        Character = 0,
        Account = 1,
    }

    public enum EBucketCategory
    {
        Invisible = 0,
        Item = 1,
        Currency = 2, 
        Equippable = 3,
        Ignored = 4,
    }

    public class DestinyInventoryBucketDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EBucketScope Scope { get; set; }
        public EBucketCategory Category { get; set; }
        public int BucketOrder { get; set; }
        public int ItemCount { get; set; }
        public EItemLocation Location { get; set; }
        public bool HasTransferDestination { get; set; }
        public bool Enabled { get; set; }
        public bool Fifo { get; set; }

    }
}
