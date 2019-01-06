using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Vendors
{
    public enum EDestinyVendorItemRefundPolicy
    {
        NotRefundable = 0,
        DeletesItem = 1,
        RevokesLicence = 2,
    }

    public class DestinyVendorReceipt
    {
        public DestinyItemQuantity CurrencyPaid { get; set; }
        public DestinyItemQuantity ItemReceived { get; set; }
        public long LicenseUnlockHash { get; set; }
        public long PurchasedByCharacterId { get; set; }
        public EDestinyVendorItemRefundPolicy RefundPolicy { get; set; }
        public int SequenceNumber { get; set; }
        public long TimeToExpiration { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
