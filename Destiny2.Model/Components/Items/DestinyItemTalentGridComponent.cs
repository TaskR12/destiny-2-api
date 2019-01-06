using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemTalentGridComponent
    {
        public long TalentGridHash { get; set; }
        public IEnumerable<DestinyTalentNode> Nodes { get; set; }
        public bool IsGridComplete { get; set; }
        public DestinyProgression GridProgression { get; set; }

    }
}
