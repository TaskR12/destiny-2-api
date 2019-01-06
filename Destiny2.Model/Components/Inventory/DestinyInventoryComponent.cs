using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Items;

namespace Destiny2.Api.Model.Inventory
{
    public class DestinyInventoryComponent
    {
        public IEnumerable<DestinyItemComponent> Items { get; set; }
    }
}
