using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinySandboxPerkDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string PerkIdentifier { get; set; }
        public bool IsDisplayable { get; set; }
        public EDamageType DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public DestinyTalentNodeStepGroups PerkGroups { get; set; }
    }
}
