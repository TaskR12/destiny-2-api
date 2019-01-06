using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class InventoryItemStatDefinition
    {
        public long StatHash { get; set; }
        public int Value { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}
