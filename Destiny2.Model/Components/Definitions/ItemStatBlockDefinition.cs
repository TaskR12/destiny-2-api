using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemStatBlockDefinition
    {
        public bool DisablePrimaryStatDisplay { get; set; }
        public long StatGroupHash { get; set; }
        public Dictionary<string, InventoryItemStatDefinition> Stats { get; set; }
        public bool HasDisplayableStats { get; set; }
        public long PrimaryBaseStatHash { get; set; }
    }
}
