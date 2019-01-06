using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyPlugSetDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public IEnumerable<DestinyItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; set; }
    }
}
