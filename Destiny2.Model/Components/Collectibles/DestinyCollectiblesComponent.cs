using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Collectibles
{
    public class DestinyCollectiblesComponent
    {
        public Dictionary<long,DestinyCollectibleComponent> Collectibles { get; set; }
    }
}
