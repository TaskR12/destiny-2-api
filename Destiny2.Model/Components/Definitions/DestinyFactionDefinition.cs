using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyFactionDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long ProgressionHash { get; set; }
        public Dictionary<long,long> TokenValues { get; set; }
        public long RewardItemHash { get; set; }
        public long RewardVendorHash { get; set; }
        public IEnumerable<DestinyFactionVendorDefinition> Vendors { get; set; }
    }
}
