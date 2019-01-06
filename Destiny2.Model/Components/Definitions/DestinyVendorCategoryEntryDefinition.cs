using System.Collections.Generic;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorCategoryEntryDefinition
    {
        public int CategoryIndex { get; set; }
        public string CategoryId { get; set; }
        public int SortValue { get; set; }
        public long CategoryHash { get; set; }
        public int QuantityAvailable { get; set; }
        public bool ShowUnavailableItems { get; set; }
        public bool HideIfNoCurrency { get; set; }
        public bool HideFromRegularPurchase { get; set; }
        public string BuyStringOverride { get; set; }
        public string DisabledDescription { get; set; }
        public string DisplayTitle { get; set; }
        public DestinyVendorCategoryOverlayDefinition Overlay { get; set; }
        public IEnumerable<int> VendorItemIndexes { get; set; }
        public bool IsPreview { get; set; }
        public bool IsDisplayOnly { get; set; }
        public int ResetIntervalMinutesOverride { get; set; }
        public int ResetOffsetMinutesOverride { get; set; }
    }
}
