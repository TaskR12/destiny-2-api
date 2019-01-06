using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorAcceptedItemDefinition
    {
        public long AcceptedInventoryBucketHash { get; set; }
        public long DestinationInventoryBucketHash { get; set; }
    }
}
