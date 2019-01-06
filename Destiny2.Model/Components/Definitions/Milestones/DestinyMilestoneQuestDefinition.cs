using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneQuestDefinition
    {
        public long QuestItemHash { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string OverrideImage { get; set; }
        public DestinyMilestoneQuestRewardsDefinition QuestRewards { get; set; }
        public Dictionary<long, DestinyMilestoneActivityDefinition> Activities { get; set; }
        public long DestinationHash { get; set; }
    }
}
