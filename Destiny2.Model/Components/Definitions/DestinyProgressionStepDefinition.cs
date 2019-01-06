using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyProgressionStepDefinition
    {
        public string StepName { get; set; }
        public EDestinyProgressionStepDisplayEffect DisplayEffectType { get; set; }
        public int ProgressTotal { get; set; }
        public IEnumerable<DestinyItemQuantity> RewardItems { get; set; }
        public string Icon { get; set; }
    }
}
