using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyTalentNodeStepGroups
    {
        public EDestinyTalentNodeStepWeaponPerformances WeaponPerformance { get; set; }
        public EDestinyTalentNodeStepImpactEffects ImpactEffects { get; set; }
        public EDestinyTalentNodeStepGuardianAttributes GuardianAttributes { get; set; }
        public EDestinyTalentNodeStepLightAbilities LightAbilities { get; set; }
        public EDestinyTalentNodeStepDamageTypes DamageTypes { get; set; }
    }
}
