using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Checklists
{
    public class DestinyChecklistEntryDefinition
    {
        public long Hash { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public long DestinationHash { get; set; }
        public long LocationHash { get; set; }
        public long? BubbleHash { get; set; }
        public long? ActivityHash { get; set; }
        public long? ItemHash { get; set; }
        public long? VendorHash { get; set; }
        public int VendorInteractionIndex { get; set; }
        public EDestinyScope Scope { get; set; }
    }
}
