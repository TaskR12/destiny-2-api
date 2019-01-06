using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyDestinationDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long PlaceHash { get; set; }
        public long DefaultFreeroamActivityHash { get; set; }
        public IEnumerable<DestinyActivityGraphListEntryDefinition> ActivityGraphEntries { get; set; }
        public IEnumerable<DestinyBubbleDefinition> Bubbles { get; set; }
    }
}
