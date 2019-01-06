using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorGroupDefinition : Definition
    {
        public int Order { get; set; }
        public string CategoryName { get; set; }
    }
}
