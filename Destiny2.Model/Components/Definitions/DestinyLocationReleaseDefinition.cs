using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyLocationReleaseDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string SmallTransparentIcon { get; set; }
        public string MapIcon { get; set; }
        public string LargeTransparentIcon { get; set; }
        public long SpawnPoint { get; set; }
        public long DestinationHash { get; set; }
        public long ActivityHash { get; set; }
        public long ActivityGraphHash { get; set; }
        public long ActivityGraphNodeHash { get; set; }
        public long ActivityBubbleName { get; set; }
        public long ActivityPathBundle { get; set; }
        public long ActivityPathDestination { get; set; }
        public EDestinyActivityNavPointType NavPointType { get; set; }
        public IEnumerable<int> WorldPosition { get; set; }

    }
}
