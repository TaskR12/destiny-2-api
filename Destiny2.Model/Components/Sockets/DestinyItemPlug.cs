using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Sockets
{
    public class DestinyItemPlug
    {
        public long PlugItemHash { get; set; }
        public IEnumerable<DestinyObjectiveProgress> PlugObjectives { get; set; }
        public bool CanInsert { get; set; }
        public bool Enabled { get; set; }
        public IEnumerable<int> InsertFailIndexes { get; set; }
        public IEnumerable<int> EnableFailIndexes { get; set; }
    }
}
