using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Misc;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyProgressionDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EDestinyProgressionScope ReusablePlugItems { get; set; }
        public bool RepeatLastStep { get; set; }
        public string Source { get; set; }
        public IEnumerable<DestinyProgressionStepDefinition> Steps { get; set; }
        public bool Visible { get; set; }
        public long FactionHash { get; set; }
        public Color Color { get; set; }
        public string RankIcon { get; set; }
    }
}
