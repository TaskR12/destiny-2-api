using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public enum ESocketPlugSources
    {
        None = 0,
        InventorySourced = 1,
        ReusablePlugItem = 2,
        ProfilePlugSet = 4,
        CharacterPlugSet = 8,
    }

    public class ItemSocketEntryDefinition
    {
        public long SocketTypeHash { get; set; }
        public long SingleInitialItemHash { get; set; }
        public IEnumerable<ItemSocketEntryPlugItemDefinition> ReusablePlugItems { get; set; }
        public bool PreventInitializationOnVendorPurchase { get; set; }
        public bool HidePerksInItemTooltip { get; set; }
        public ESocketPlugSources PlugSources { get; set; }
        public long ReusablePlugSetHash { get; set; }
        public IEnumerable<ItemSocketEntryPlugItemRandomizedDefinition> RandomizedPlugItems { get; set; }
        public bool DefaultVisible { get; set; }
    }
}
