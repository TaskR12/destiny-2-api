using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions.Milestones
{
    public class DestinyMilestoneValueDefinition
    {
        public string Key { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
    }
}
