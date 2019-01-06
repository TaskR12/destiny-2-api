using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Components.Milestones
{
    public class DestinyMilestoneRewardCategory
    {
        public long RewardCategoryHash { get; set; }
        public IEnumerable<DestinyMilestoneRewardEntry> Entries { get; set; }
    }
}
