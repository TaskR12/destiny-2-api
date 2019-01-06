using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyBubbleDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long Hash { get; set; }
    }
}
