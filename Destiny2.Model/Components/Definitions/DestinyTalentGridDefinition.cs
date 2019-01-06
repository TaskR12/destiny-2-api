using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyTalentGridDefinition : Definition
    {
        public int MaxGridLevel { get; set; }
        public int GridLevelPerColumn { get; set; }
        public long ProgressionHash { get; set; }
        public IEnumerable<DestinyTalentNodeDefinition> Nodes { get; set; }
        public IEnumerable<DestinyTalentNodeExclusiveSetDefinition> ExclusiveSets { get; set; }
        public IEnumerable<int> IndependentNodeIndexes { get; set; }
        public Dictionary<long, DestinyTalentExclusiveGroup> Groups { get; set; }
        public IEnumerable<DestinyTalentNodeCategory> NodeCategories { get; set; }
    }
}
