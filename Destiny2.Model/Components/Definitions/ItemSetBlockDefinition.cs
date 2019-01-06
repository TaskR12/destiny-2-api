using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemSetBlockDefinition
    {
        public IEnumerable<ItemSetBlockEntryDefinition> ItemList { get; set; }
        public bool RequireOrderedSetItemAdd { get; set; }
        public bool SetIsFeatured { get; set; }
        public string SetType { get; set; }
    }
}
