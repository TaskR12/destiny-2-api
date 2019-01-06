using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyNodeActivationRequirement
    {
        public int GridLevel { get; set; }
        public IEnumerable<long> MaterialRequirementHashes { get; set; }
    }
}
