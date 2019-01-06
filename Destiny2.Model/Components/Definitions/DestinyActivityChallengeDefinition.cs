using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyActivityChallengeDefinition
    {
        public long ObjectiveHash { get; set; }
        public IEnumerable<DestinyItemQuantity> DummyRewards { get; set; }
    }
}
