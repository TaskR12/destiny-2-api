using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyVendorInteractionDefinition
    {
        public int InteractionIndex { get; set; }
        public IEnumerable<DestinyVendorInteractionReplyDefinition> Replies { get; set; }
        public int VendorCategoryIndex { get; set; }
        public long QuestlineItemHash { get; set; }
        public IEnumerable<DestinyVendorInteractionSackEntryDefinition> SackInteractionList { get; set; }
        public long UiInteractionType { get; set; }
        public EVendorInteractionType InteractionType { get; set; }
        public string RewardBlockLabel { get; set; }
        public int RewardVendorCategoryIndex { get; set; }
        public string FlavorLineOne { get; set; }
        public string FlavorLineTwo { get; set; }
        public DestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; set; }
        public string Instructions { get; set; }



    }
}
