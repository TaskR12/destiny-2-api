using Destiny2.Api.Model.Challenges;
using Destiny2.Api.Model.Milestones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Components.Milestones
{
    public class DestinyMilestoneChallengeActivity
    {
        public long ActivityHash { get; set; }
        public IEnumerable<DestinyChallengeStatus> Challenges { get; set; }
        public IEnumerable<long> ModifierHashes { get; set; }
        public Dictionary<long,bool> BooleanActivityOptions { get; set; }
        public int LoadoutRequirementIndex { get; set; }
        public IEnumerable<DestinyMilestoneActivityPhase> Phases { get; set; }

    }
}
