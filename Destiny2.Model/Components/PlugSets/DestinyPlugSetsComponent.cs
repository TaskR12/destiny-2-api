using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.PlugSets
{
    public class DestinyPlugSetsComponent
    {
        public Dictionary<long,IEnumerable<long>> Plugs { get; set; }
    }
}
