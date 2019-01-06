using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyFactionVendorDefinition
    {
        public long VendorHash { get; set; }
        public long DestinationHash { get; set; }
        public string BackgroundImagePath { get; set; }
    }
}
