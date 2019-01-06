using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemStatsComponent
    {
        public Dictionary<long, DestinyStat> Stats { get; set; }
    }
}
