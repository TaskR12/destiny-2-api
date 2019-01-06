using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyNodeStepDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public int StepIndex { get; set; }
        public long NodeStepHash { get; set; }
        public string InteractionDescription { get; set; }
        public EDamageType DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public DestinyNodeActivationRequirement ActivationRequirement { get; set; }
        public bool CanActivateNextStep { get; set; }
        public int NextStepIndex { get; set; }
        public bool IsNextStepRandom { get; set; }
        public IEnumerable<long> PerkHashes { get; set; }
        public int StartProgressionBarAtProgress { get; set; }
        public IEnumerable<long> StatHashes { get; set; }
        public bool AffectsQuality { get; set; }
        public DestinyTalentNodeStepGroups StepGroups { get; set; } 
        public bool AffectsLevel { get; set; }
        public IEnumerable<DestinyNodeSocketReplaceResponse> SocketReplacements { get; set; }


    }
}
