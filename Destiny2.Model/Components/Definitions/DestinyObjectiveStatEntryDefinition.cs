using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyObjectiveStatEntryDefinition
    {
        public DestinyItemInvestmentStatDefinition Stat { get; set; }
        public EDestinyObjectiveGrantStyle Style { get; set; }
    }
}
