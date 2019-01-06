using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions;

namespace Destiny2.Api.Model
{
    public enum EDestinyTalentNodeState
    {
        Invalid= 0,
        CanUpgrade= 1,
        NoPoints= 2,
        NoPrerequisites= 3,
        NoSteps= 4,
        NoUnlock= 5,
        NoMaterial= 6,
        NoGridLevel= 7,
        SwappingLocked= 8,
        MustSwap= 9,
        Complete= 10,
        Unknown= 11,
        CreationOnly= 12,
        Hidden= 13,
    }

    public class DestinyTalentNode
    {
        public int NodeIndex { get; set; }
        public long NodeHash { get; set; }
        public EDestinyTalentNodeState State { get; set; }
        public bool IsActivated { get; set; }
        public int StepIndex { get; set; }
        public IEnumerable<DestinyMaterialRequirement> MaterialsToUpgrade { get; set; }
        public int ActivationGridLevel { get; set; }
        public float ProgressPercent { get; set; }
        public bool Hidden { get; set; }
        public DestinyTalentNodeStatBlock NodeStatsBlock { get; set; }


    }
}
