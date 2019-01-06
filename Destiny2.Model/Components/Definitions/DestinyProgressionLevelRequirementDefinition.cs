using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Interpolation;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyProgressionLevelRequirementDefinition : Definition
    {
        public IEnumerable<InterpolationPointFloat> RequirementCurve { get; set; }
        public long ProgressionHash { get; set; }
    }
}
