using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Inventory
{
    public class StatDescription
    {
        public long StatHash { get; set; }

        public int Value { get; set; }

        public int MaximumValue { get; set; }
    }
}
