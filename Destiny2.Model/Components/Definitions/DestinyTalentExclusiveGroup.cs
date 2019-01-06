using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyTalentExclusiveGroup
    {
        public long GroupHash { get; set; }
        public long LoreHash { get; set; }
        public IEnumerable<long> NodeHashes { get; set; }
        public IEnumerable<long> OpposingGroupHashes { get; set; }
        public IEnumerable<long> OpposingNodeHashes { get; set; }

    }
}
