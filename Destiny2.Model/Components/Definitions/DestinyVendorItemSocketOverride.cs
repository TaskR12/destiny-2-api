using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorItemSocketOverride
    {
        public long SingleItemHash { get; set; }
        public int RandomizedOptionsCount { get; set; }
        public long SocketTypeHash { get; set; }

    }
}
