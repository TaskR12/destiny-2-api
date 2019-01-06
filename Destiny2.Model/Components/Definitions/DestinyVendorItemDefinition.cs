using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorItemDefinition
    {
        public int VendorItemIndex { get; set; }
        public long ItemHash { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<int> FailureIndexes { get; set; }
        public IEnumerable<DestinyVendorItemQuantity> Currencies { get; set; }
        public EDestinyVendorItemRefundPolicy RefundPolicy { get; set; }
        public int RefundTimeLimit { get; set; }
        public IEnumerable<DestinyItemCreationEntryLevelDefinition> CreationLevels { get; set; }
        public int DisplayCategoryIndex { get; set; }
        public int CategoryIndex { get; set; }
        public int OriginalCategoryIndex { get; set; }
        public int MinimumLevel { get; set; }
        public int MaximumLevel { get; set; }
        public DestinyVendorSaleItemActionBlockDefinition Action { get; set; }
        public string DisplayCategory { get; set; }
        public long InventoryBucketHash { get; set; }
        public EDestinyGatingScope VisibilityScope { get; set; }
        public EDestinyGatingScope PurchaseScope { get; set; }
        public EBungieMembershipType Exclusivity { get; set; }
        public bool? IsOffer { get; set; }
        public bool? IsCrm { get; set; }
        public int SortValue { get; set; }
        public string ExpirationTooltip { get; set; }
        public IEnumerable<int> RedirectToSaleIndexes { get; set; }
        public IEnumerable<DestinyVendorItemSocketOverride> SocketOverrides { get; set; }


    }
}
