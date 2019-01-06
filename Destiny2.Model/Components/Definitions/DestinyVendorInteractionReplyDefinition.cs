using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorInteractionReplyDefinition
    {
        public EDestinyVendorInteractionRewardSelection ItemRewardsSelection { get; set; }
        public string Reply { get; set; }
        public EDestinyVendorReplyType ReplyType { get; set; }
    }
}
