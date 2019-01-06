using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyItemInvestmentStatDefinition
    {
        public long StatTypeHash { get; set; }
        public int Value { get; set; }
        public bool IsConditionallyActive { get; set; }
    }
}
