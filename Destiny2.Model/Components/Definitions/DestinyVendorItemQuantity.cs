using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorItemQuantity
    {
        public long ItemHash { get; set; }
        public long? ItemInstanceId { get; set; }
        public int Quantity { get; set; }
    }
}
