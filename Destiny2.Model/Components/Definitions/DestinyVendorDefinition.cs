using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Dates;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Definitions.Vendors;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string BuyString { get; set; }
        public string SellString { get; set; }
        public long DisplayItemHash { get; set; }
        public bool InhibitBuying { get; set; }
        public bool InhibitSelling { get; set; }
        public long FactionHash { get; set; }
        public int ResetIntervalMinutes { get; set; }
        public int ResetOffsetMinutes { get; set; }
        public IEnumerable<string> FailureStrings { get; set; }
        public IEnumerable<DateRange> UnlockRanges { get; set; }
        public string VendorIdentifier { get; set; }
        public string VendorPortrait { get; set; }
        public string VendorBanner { get; set; }
        public bool Enabled { get; set; }
        public bool Visible { get; set; }
        public string VendorSubcategoryIdentifier { get; set; }
        public bool ConsolidateCategories { get; set; }
        public IEnumerable<DestinyVendorActionDefinition> Actions { get; set; }
        public IEnumerable<DestinyVendorCategoryEntryDefinition> Categories { get; set; }
        public IEnumerable<DestinyVendorCategoryEntryDefinition> OriginalCategories { get; set; }
        public IEnumerable<DestinyDisplayCategoryDefinition> DisplayCategories { get; set; }
        public IEnumerable<DestinyVendorInteractionDefinition> Interactions { get; set; }
        public IEnumerable<DestinyVendorInventoryFlyoutDefinition> InventoryFlyouts { get; set; }
        public IEnumerable<DestinyVendorItemDefinition> ItemList { get; set; }
        public IEnumerable<DestinyVendorServiceDefinition> Services { get; set; }
        public IEnumerable<DestinyVendorAcceptedItemDefinition> AcceptedItems { get; set; }
        public bool ReturnWithVendorRequest { get; set; }
        public IEnumerable<DestinyVendorLocationDefinition> Locations { get; set; }
        public IEnumerable<DestinyVendorGroupReference> Groups { get; set; }
        public IEnumerable<long> IgnoreSaleItemHashes { get; set; }

        public override string ToString()
        {
            return $"{DisplayProperties.Name} : {DisplayProperties.Description}";
        }
    }
}
