using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyStatGroupDefinition : Definition
    {
        public int MaximumValue { get; set; }
        public int UiPosition { get; set; }
        //public DestinyStatDisplayDefinition ScaledStats { get; set; }
        //Todo:  Overrides aren't added as not used
    }
}
