using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneRewardCategoryDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long CategoryHash { get; set; }
        public string CategoryIdentifier { get; set; }
        public Dictionary<long, DestinyMilestoneRewardEntryDefinition> RewardEntries { get; set; }
        public int Order { get; set; }
    }
}
