using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Vendors;

namespace Destiny2.Api.Model.Profiles
{
    public class DestinyVendorReceiptsComponent
    {
        public IEnumerable<DestinyVendorReceipt> Receipts { get; set; }
    }
}
