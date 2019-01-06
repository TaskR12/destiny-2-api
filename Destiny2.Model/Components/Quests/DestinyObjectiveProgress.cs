using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Quests
{
    public class DestinyObjectiveProgress
    {
        public long ObjectiveHash { get; set; }
        public long DestinationHash { get; set; }
        public long ActivityHash { get; set; }
        public int? Progress { get; set; }
        public int CompletionValue { get; set; }
        public bool Complete { get; set; }
        public bool Visible { get; set; }
    }
}
