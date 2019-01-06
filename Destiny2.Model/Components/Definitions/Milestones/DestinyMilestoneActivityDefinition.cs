using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneActivityDefinition
    {
        public long ConceptualActivityHash { get; set; }
        public Dictionary<long,DestinyMilestoneActivityVariantDefinition> Variants { get; set; }
    }
}
