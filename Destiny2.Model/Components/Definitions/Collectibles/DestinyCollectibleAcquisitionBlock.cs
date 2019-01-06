using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions.Collectibles
{
    public class DestinyCollectibleAcquisitionBlock
    {
        public long? AcquireMaterialRequirementHash { get; set; }
        public long? AcquireTimestampUnlockValueHash { get; set; }
    }
}
