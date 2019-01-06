using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Lore
{
    public class DestinyLoreDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string Subtitle { get; set; }
    }
}
