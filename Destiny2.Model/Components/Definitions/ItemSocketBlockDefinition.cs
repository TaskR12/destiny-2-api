using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemSocketBlockDefinition
    {
        public string Detail { get; set; }
        public IEnumerable<ItemSocketEntryDefinition> SocketEntries { get; set; }
        public IEnumerable<ItemIntrinsicSocketEntryDefinition> IntrinsicSockets { get; set; } 
        public IEnumerable<ItemSocketCategoryDefinition> SocketCategories { get; set; }
    }
}
