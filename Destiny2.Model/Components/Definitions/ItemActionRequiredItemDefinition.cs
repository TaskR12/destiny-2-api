using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemActionRequiredItemDefinition
    {
        public int Count { get; set; }
        public long ItemHash { get; set; }
        public bool DeleteOnAction { get; set; }

    }
}
