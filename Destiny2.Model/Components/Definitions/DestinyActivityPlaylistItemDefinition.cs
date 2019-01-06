using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Milestones;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyActivityPlaylistItemDefinition
    {
        public long ActivityHash { get; set; }
        public long DirectActivityModeHash { get; set; }
        public EActivityModeType DirectActivityModeType { get; set; }
        public IEnumerable<long> ActivityModeHashes { get; set; }
        public IEnumerable<EActivityModeType> ActivityModeTypes { get; set; }
    }
}
