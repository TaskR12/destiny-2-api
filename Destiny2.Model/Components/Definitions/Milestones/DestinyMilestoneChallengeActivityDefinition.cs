using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneChallengeActivityDefinition
    {
        public long ActivityHash { get; set; }
        public IEnumerable<DestinyMilestoneChallengeDefinition> Challenges { get; set; }
        public IEnumerable<DestinyMilestoneChallengeActivityGraphNodeEntry> ActivityGraphNodes { get; set; }
        public IEnumerable<DestinyMilestoneChallengeActivityPhase> Phases { get; set; }
    }
}
