using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Milestones
{
    public class DestinyMilestoneActivityVariant
    {
        public long ActivityHash { get; set; }
        public DestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }
        public long ActivityModeHash { get; set; }
        public EActivityModeType ActivityModeType { get; set; }
    }
}
