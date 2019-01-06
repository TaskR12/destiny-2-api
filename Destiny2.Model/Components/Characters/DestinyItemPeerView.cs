using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Characters
{
    public class DestinyItemPeerView
    {
        public long ItemHash { get; set; }
        public IEnumerable<DyeReference> Dyes { get; set; }
    }
}
