using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyTalentNodeDefinition
    {
        public int NodeIndex { get; set; }
        public long NodeHash { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public IEnumerable<int> PrerequisiteNodeIndexes { get; set; }
        public int BinaryPairNodeIndex { get; set; }
        public bool AutoUnlocks { get; set; }
        public bool LastStepRepeats { get; set; }
        public bool IsRandom { get; set; }
        public DestinyNodeActivationRequirement RandomActivationRequirement { get; set; }
        public bool IsRandomRepurchasable { get; set; }
        public IEnumerable<DestinyNodeStepDefinition> Steps { get; set; }
        public IEnumerable<long> ExclusiveWithNodeHashes { get; set; }
        public string LayoutIdentifier { get; set; }
        public long? GroupHash { get; set; }
        public long? LoreHash { get; set; }
        public string NodeStyleIdentifier { get; set; }
        public bool IgnoreForCompletion { get; set; }



    }
}
