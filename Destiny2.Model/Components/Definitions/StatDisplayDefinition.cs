using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Interpolation;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyStatDisplayDefinition
    {
        public long StatHash { get; set; }
        public int MaximumValue { get; set; }
        public bool DisplayAsNumeric { get; set; }
        public IEnumerable<InterpolationPoint> DisplayInterpolation { get; set; }
    }
}
