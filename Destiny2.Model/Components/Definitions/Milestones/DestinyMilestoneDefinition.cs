using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string Image { get; set; }
        public EDestinyMilestoneType MilestoneType { get; set; }
        public bool Recruitable { get; set; }
        public string FriendlyName { get; set; }
        public bool ShowInExplorer { get; set; }
        public bool ShowInMilestones { get; set; }
        public bool ExplorePrioritizesActivityImage { get; set; }
        public bool HasPredictableDates { get; set; }
        public Dictionary<long, DestinyMilestoneQuestDefinition> Quests { get; set; }
        public Dictionary<long, DestinyMilestoneRewardCategoryDefinition> Rewards { get; set; }
        public string VendorsDisplayTitle { get; set; }
        public IEnumerable<DestinyMilestoneVendorDefinition> Vendors { get; set; }
        public Dictionary<string, DestinyMilestoneValueDefinition> Values { get; set; }
        public bool IsInGameMilestone { get; set; }
        public IEnumerable<DestinyMilestoneChallengeActivityDefinition> Activities { get; set; }
        public int DefaultOrder { get; set; }

        public override string ToString()
        {
            return $"{DisplayProperties.Name} ({MilestoneType}) : {DisplayProperties.Description}";
        }
    }
}
