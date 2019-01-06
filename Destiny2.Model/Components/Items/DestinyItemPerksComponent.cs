using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Perks;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemPerksComponent
    {
        public IEnumerable<DestinyPerkReference> Perks { get; set; }
    }
}
