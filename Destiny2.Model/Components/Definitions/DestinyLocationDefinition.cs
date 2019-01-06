using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyLocationDefinition : Definition
    {
        public long VendorHash { get; set; }
        public IEnumerable<DestinyLocationReleaseDefinition> LocationReleases { get; set; }
    }
}
