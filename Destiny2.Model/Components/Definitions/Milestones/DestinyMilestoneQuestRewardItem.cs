using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneQuestRewardItem
    {
        public long? VendorHash { get; set; }
        public int? VendorItemIndex { get; set; }
        public long ItemHash { get; set; }
        public long? ItemInstanceId { get; set; }
        public int Quantity { get; set; }
    }
}
