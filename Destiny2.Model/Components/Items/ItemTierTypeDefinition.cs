using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Items
{
    public class ItemTierTypeDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public ItemTierTypeInfusionBlock InfusionProcess { get; set; }
        public long Hash { get; set; }
        public int Index { get; set; }
        public bool Redacted { get; set; }
    }
}
