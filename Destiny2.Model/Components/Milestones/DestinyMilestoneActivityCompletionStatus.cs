using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Milestones
{
    public class DestinyMilestoneActivityCompletionStatus
    {
        public bool Completed { get; set; }
        public IEnumerable<DestinyMilestoneActivityPhase> Phases { get; set; }
    }
}
