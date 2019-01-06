using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Components.Milestones
{
    public class DestinyMilestoneRewardEntry
    {
        public long RewardEntryHash { get; set; }
        public bool Earned { get; set; }
        public bool Redeemed { get; set; }
    }
}
