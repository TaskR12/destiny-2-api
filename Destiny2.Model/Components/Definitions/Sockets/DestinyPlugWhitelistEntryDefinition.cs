using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions.Sockets
{
    public class DestinyPlugWhitelistEntryDefinition
    {
        public long CategoryHash { get; set; }
        public string CategoryIdentifier { get; set; }
        public IEnumerable<long> ReinitializationPossiblePlugHashes { get; set; }
    }
}
