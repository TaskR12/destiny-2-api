using System.Collections.Generic;
using Destiny2.Api.Model.Quests;
using Destiny2.Api.Model.Sockets;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemSocketState
    {
        public long PlugHash { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public IEnumerable<int> EnableFailIndexes { get; set; }
        public IEnumerable<long> ReusablePlugHashes { get; set; }
        public IEnumerable<DestinyObjectiveProgress> PlugObjectives { get; set; }
        public IEnumerable<DestinyItemPlug> ReusablePlugs { get; set; }




    }
}
