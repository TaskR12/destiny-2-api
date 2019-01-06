using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyEquipmentSlotDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long EquipmentCategoryHash { get; set; }
        public long BucketTypeHash { get; set; }
        public bool ApplyCustomArtDyes { get; set; }
        public IEnumerable<DestinyArtDyeReference> ArtDyeChannels { get; set; }
    }
}
