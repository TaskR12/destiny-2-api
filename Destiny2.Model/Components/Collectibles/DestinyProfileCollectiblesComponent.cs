using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Collectibles
{
    public class DestinyProfileCollectiblesComponent
    {
        public IEnumerable<long> RecentCollectibleHashes { get; set; }

        public IEnumerable<long> NewnessFlaggedCollectibleHashes { get; set; }

        public Dictionary<long,DestinyCollectibleComponent> Collectibles { get; set; }
    }
}
