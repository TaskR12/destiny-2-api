using Destiny2.Api.Model.Components.Milestones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Milestones
{
    public class DestinyMilestone
    {
        public long MilestoneHash { get; set; }
        public IEnumerable<DestinyMilestoneQuest> AvailableQuests { get; set; }
        public IEnumerable<DestinyMilestoneRewardCategory> Rewards { get; set; }
        public IEnumerable<DestinyMilestoneChallengeActivity> Activities { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Order { get; set; }
    }
}
