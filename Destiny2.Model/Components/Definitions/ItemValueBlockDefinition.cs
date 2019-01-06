using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemValueBlockDefinition
    {
        public IEnumerable<DestinyItemQuantity> ItemValue { get; set; }
        public string ValueDescription { get; set; }
    }
}
