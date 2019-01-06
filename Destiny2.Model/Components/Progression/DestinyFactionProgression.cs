using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Progression
{
    public class DestinyFactionProgression : DestinyProgression
    {
        public long FactionHash { get; set; }
        public int FactionVendorIndex { get; set; }
    }
}
