using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyActivityMatchmakingBlockDefinition
    {
        public bool IsMatchmade { get; set; }
        public int MinParty { get; set; }
        public int MaxParty { get; set; }
        public int MaxPlayers { get; set; }
        public bool RequiresGuardianOath { get; set; }
    }
}
