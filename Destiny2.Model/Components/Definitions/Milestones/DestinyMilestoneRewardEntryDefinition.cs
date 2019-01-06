using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneRewardEntryDefinition
    {
        public long RewardEntryHash { get; set; }
        public string RewardEntryIdentifier { get; set; }
        public IEnumerable<DestinyItemQuantity> Items { get; set; }
        public long VendorHash { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public int Order { get; set; }


    }
}
