using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyActivityLoadoutRequirementSet
    {
        public IEnumerable<DestinyActivityLoadoutRequirement> Requirements { get; set; }
    }
}
