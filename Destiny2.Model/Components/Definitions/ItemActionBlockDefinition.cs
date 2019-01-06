using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemActionBlockDefinition
    {
        public string VerbName { get; set; }
        public string VerbDescription { get; set; }
        public bool IsPositive { get; set; }
        public string OverlayScreenName { get; set; }
        public string OverlayIcon { get; set; }
        public int RequiredCooldownSeconds { get; set; }
        public IEnumerable<ItemActionRequiredItemDefinition> RequiredItems { get; set; }
        public IEnumerable<ProgressionRewardDefinition> ProgressionRewards { get; set; }
        public string ActionTypeLabel { get; set; }
        public string RequiredLocation { get; set; }
        public uint RequiredCooldownHash { get; set; }
        public bool DeleteOnAction { get; set; }
        public bool ConsumeEntireStack { get; set; }
        public bool UseOnAcquire { get; set; }



    }
}
